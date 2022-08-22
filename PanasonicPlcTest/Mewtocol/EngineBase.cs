using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static PanasonicPlcTest.Mewtocol.LinkedData;

namespace PanasonicPlcTest.Mewtocol
{
    public abstract class EngineBase : IDisposable
    {
        public string StationNumber { get; set;} = "01";
        public abstract bool IsConnected { get; }
        public abstract void Connect();
        public abstract void Disconnect();
        public void Dispose()
        {
            OnDisposing();
        }
        protected internal abstract void OnDisposing();

        #region Low level command handling

        protected internal abstract Task<string> OnCommandSending(byte[] request);

        protected internal async Task<CommandResult> SendCommandAsync(string command)
        {
            CommandResult result = new CommandResult();
            try
            {
                command = command.BuildBCCFrame();
                command += "\r";
                var message = command.ToHexASCIIBytes();
                var response = await OnCommandSending(message);
                if (string.IsNullOrEmpty(response))
                {
                    result.Error = "0";
                    result.ErrorDescription = ErrorCodes[Convert.ToInt32(result.Error)];
                }                    
                else
                {
                    Regex errorcheck = new Regex(@"\%[0-9]{2}\!([0-9]{2})", RegexOptions.IgnoreCase);
                    Match m = errorcheck.Match(response);
                    if (m.Success)
                    {
                        result.Error = m.Groups[1].Value;
                        result.ErrorDescription = ErrorCodes[Convert.ToInt32(result.Error)];
                    }
                    else
                    {
                        result.Success = true;
                        result.Response = response;
                    }
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// Covert response value to specify type
        /// </summary>
        /// <param name="result"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private (object, CommandResult) CommandResultValueTypeCovert(CommandResult result, Type type)
        {
            try
            {
                if (type == typeof(short))
                {
                    var resultBytes = result.Response.ParseDTByteString(4).ReverseByteOrder();
                    if (resultBytes != null)
                        return (short.Parse(resultBytes, NumberStyles.HexNumber), result);
                }
                else if (type == typeof(ushort))
                {
                    var resultBytes = result.Response.ParseDTByteString(4).ReverseByteOrder();
                    if (resultBytes != null)
                        return (ushort.Parse(resultBytes, NumberStyles.HexNumber), result);
                }
                else if (type == typeof(int))
                {
                    var resultBytes = result.Response.ParseDTByteString(8).ReverseByteOrder();
                    if (resultBytes != null)
                        return (int.Parse(resultBytes, NumberStyles.HexNumber), result);
                }
                else if (type == typeof(uint))
                {
                    var resultBytes = result.Response.ParseDTByteString(8).ReverseByteOrder();
                    if (resultBytes != null)
                        return (uint.Parse(resultBytes, NumberStyles.HexNumber), result);
                }
                else if (type == typeof(float))
                {
                    var resultBytes = result.Response.ParseDTByteString(8).ReverseByteOrder();
                    if (resultBytes != null)
                    {
                        var val = uint.Parse(resultBytes, NumberStyles.HexNumber);
                        byte[] floatVals = BitConverter.GetBytes(val);
                        float finalFloat = BitConverter.ToSingle(floatVals, 0);
                        return (finalFloat, result);
                    }
                }
                else if (type == typeof(TimeSpan))
                {
                    var resultBytes = result.Response.ParseDTByteString(8).ReverseByteOrder();
                    if (resultBytes != null)
                    {
                        var vallong = long.Parse(resultBytes, NumberStyles.HexNumber);
                        var valMillis = vallong * 10;
                        var ts = TimeSpan.FromMilliseconds(valMillis);
                        return (ts, result);
                    }
                }
                else if (type == typeof(string))
                    return (result.Response.ParseDTString(), result);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = "0000";
                result.ErrorDescription = ex.Message;
                return (null, result);
            }
            return (null, result);
        }

        #endregion

        #region public command

        /// <summary>
        /// Get PLC Controller Information
        /// </summary>
        /// <returns></returns>
        public PLCInfo GetPLCInfo()
        {
            var result = SendCommandAsync($"%{StationNumber}#RT").Result;
            if (!result.Success) return null;
            var reg = new Regex(@"\%([0-9]{2})\$RT([0-9]{2})([0-9]{2})([0-9]{2})([0-9]{2})([0-9]{2})([0-9]{2})([0-9]{4})..", RegexOptions.IgnoreCase);
            Match m = reg.Match(result.Response);
            if (m.Success)
            {
                string station = m.Groups[1].Value;
                string cpu = m.Groups[2].Value;
                string version = m.Groups[3].Value;
                string capacity = m.Groups[4].Value;
                string operation = m.Groups[5].Value;
                string errorflag = m.Groups[7].Value;
                string error = m.Groups[8].Value;

                PLCInfo retInfo = new PLCInfo
                {
                    CpuInformation = CpuInfo.BuildFromHexString(cpu, version, capacity),
                    OperationMode = PLCMode.BuildFromHex(operation),
                    ErrorCode = error,
                    StationNumber = int.Parse(station ?? "0"),
                };
                return retInfo;
            }
            return null;
        }

        #endregion

        #region Data read

        /// <summary>
        /// This reads the on and off status for only one contact.
        /// External input X: X
        /// External output Y: Y
        /// Internal relay R: R
        /// Link relay L: L
        /// Timer T: T
        /// Count C: C
        /// </summary>
        /// <param name="code"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public (bool? Value, CommandResult Result) ReadContactAreaSinglePoint(string code, int address)
        {
            string[] allow = { "X", "Y", "R", "L", "T", "C" };
            if (allow.Contains(code))
            {
                StringBuilder asciistring = new StringBuilder(code);
                asciistring.Append(address.ToString().PadLeft(4, '0'));
                string requeststring = $"%{StationNumber}#RCS{asciistring}";
                var result = SendCommandAsync(requeststring).Result;
                if (result.Success)
                {
                    return (result.Response.ParseRCSingleBit(), result);
                }
                return (null, result);
            }
            else
                return (null, new CommandResult { Success = false, Error = "0000", ErrorDescription = "Code is not allow." });
        }

        /// <summary>
        /// To read the contents of DT, LD, and FL.
        /// DT: D
        /// LD: L
        /// FL: F
        /// </summary>
        /// <param name="code"></param>
        /// <param name="address"></param>
        /// <param name="length"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public (object Value, CommandResult Result) ReadDataAreaRegister(string code, int address, Type type, int length = 1)
        {
            string[] allow = { "D", "F", "L" };
            if (allow.Contains(code))
            {
                StringBuilder asciistring = new StringBuilder(code);
                asciistring.Append(address.ToString().PadLeft(5, '0'));
                asciistring.Append((address + length - 1).ToString().PadLeft(5, '0'));
                string requeststring = $"%{StationNumber}#RD{asciistring}";
                var result = SendCommandAsync(requeststring).Result;
                if (result.Success)
                    return CommandResultValueTypeCovert(result, type);
                else
                    return (null, result);
            }
            else
                return (null, new CommandResult { Success = false, Error = "0000", ErrorDescription = "Code is not allow." });
        }

        #endregion

        #region Data write

        /// <summary>
        /// Write contact area (single point): This turns only one contact on or off.
        /// External input X: X
        /// External output Y: Y
        /// Internal relay R: R
        /// Link relay L: L
        /// Timer T: T
        /// Count C: C
        /// </summary>
        /// <param name="code"></param>
        /// <param name="address"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public CommandResult WriteContactAreaSinglePoint(string code, int address, bool value)
        {
            string[] allow = { "X", "Y", "R", "L", "T", "C" };
            if (allow.Contains(code))
            {
                StringBuilder asciistring = new StringBuilder(code);
                asciistring.Append(address.ToString().PadLeft(4, '0'));
                string requeststring = $"%{StationNumber}#WCS{asciistring}{(value ? "1" : "0")}";
                return SendCommandAsync(requeststring).Result;
            }
            else
                return new CommandResult { Success = false, Error = "0000", ErrorDescription = "Code is not allow." };
        }

        /// <summary>
        /// Writ to the contents of DT, LD, and FL.
        /// DT: D
        /// LD: L
        /// FL: F
        /// </summary>
        /// <param name="code"></param>
        /// <param name="address"></param>
        /// <param name="type"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public CommandResult WriteDataAreaRegister(string code, int address, Type type, object value, int length = 1)
        {
            string[] allow = { "D", "F", "L" };
            if (allow.Contains(code))
            {
                byte[] toWriteVal;
                if (type == typeof(short))
                {
                    toWriteVal = BitConverter.GetBytes(Convert.ToInt16(value));
                }
                else if (type == typeof(ushort))
                {
                    toWriteVal = BitConverter.GetBytes(Convert.ToUInt16(value));
                }
                else if (type == typeof(int))
                {
                    toWriteVal = BitConverter.GetBytes(Convert.ToInt32(value));
                }
                else if (type == typeof(uint))
                {
                    toWriteVal = BitConverter.GetBytes(Convert.ToUInt32(value));
                }
                else if (type == typeof(float))
                {
                    var fl = value as float?;
                    if (fl == null)
                        throw new NullReferenceException("Float cannot be null");
                    toWriteVal = BitConverter.GetBytes(fl.Value);
                }
                else if (type == typeof(TimeSpan))
                {
                    var fl = value as TimeSpan?;
                    if (fl == null)
                        throw new NullReferenceException("Timespan cannot be null");
                    var tLong = (uint)(fl.Value.TotalMilliseconds / 10);
                    toWriteVal = BitConverter.GetBytes(tLong);
                }
                else
                    toWriteVal = null;

                StringBuilder asciistring = new StringBuilder(code);
                asciistring.Append(address.ToString().PadLeft(5, '0'));
                asciistring.Append((address + length - 1).ToString().PadLeft(5, '0'));
                string requeststring = $"%{StationNumber}#WD{asciistring}{toWriteVal.ToHexString()}";
                return SendCommandAsync(requeststring).Result;
            }
            else
                return new CommandResult { Success = false, Error = "0000", ErrorDescription = "Code is not allow." };
        }

        #endregion

    }
}
