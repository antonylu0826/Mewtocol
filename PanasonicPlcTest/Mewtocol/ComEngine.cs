using System;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanasonicPlcTest.Mewtocol
{
    public class ComEngine : EngineBase
    {
        internal SerialPort serialPort = null;
        bool serialPortIsReceiving = false;
        readonly int timeOut = 0;

        public ComEngine(string portName, int baudRate, Parity parity, StopBits stopBits, int dataBits, int timeOutSeconds = 5, string station = "01")
        {
            serialPort = new SerialPort(portName, baudRate)
            {
                Parity = parity,
                DataBits = dataBits,
                StopBits = stopBits,
                ReadTimeout = timeOutSeconds * 1000,
                WriteTimeout = timeOutSeconds * 1000
            };
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPortDataReceived);
            timeOut = timeOutSeconds;
            StationNumber = station;
        }

        #region Serial Port Data Receive

        string response = "";

        /// <summary>
        /// Wait and read serial port response
        /// </summary>
        /// <returns></returns>
        private string ReadResponse()
        {
            response = null;
            DateTime sendT = DateTime.Now;
            DateTime scanT = DateTime.Now;
            while ((scanT - sendT).TotalSeconds <= timeOut)
            {
                if (!string.IsNullOrEmpty(response))
                    break;
                scanT = DateTime.Now;
            }
            return response;
        }

        /// <summary>
        /// SerialPort Component DataReceived event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int rslength = 0;
            bool loop = true;
            byte[] readBuffer;
            serialPortIsReceiving = true;

            try
            {
                Thread.Sleep(30);
                while (loop)
                {
                    if (serialPort.BytesToRead == rslength)
                    {
                        loop = false;
                    }
                    else
                    {
                        rslength = serialPort.BytesToRead;
                    }
                    Thread.Sleep(30);
                }
                readBuffer = new byte[rslength];
                serialPort.Read(readBuffer, 0, rslength);
                serialPort.DiscardInBuffer();
                rslength = 0;
                response = Encoding.ASCII.GetString(readBuffer);
            }
            catch { }
            finally
            {
                serialPortIsReceiving = false;
            }
        }

        #endregion        

        public override bool IsConnected { get => serialPort.IsOpen; }

        public override void Connect() => serialPort.Open();

        public override void Disconnect() => serialPort.Close();

        protected internal override Task<string> OnCommandSending(byte[] request)
        {
            serialPort.Write(request, 0, request.Length);
            return Task.FromResult(ReadResponse());
        }

        protected internal override void OnDisposing()
        {
            serialPort.DataReceived -= serialPortDataReceived;
            while (serialPortIsReceiving)
            {
                Application.DoEvents();
            }
            Disconnect();
            serialPort = null;
        }
    }
}
