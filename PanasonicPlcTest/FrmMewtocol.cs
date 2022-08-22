using PanasonicPlcTest.Mewtocol;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace PanasonicPlcTest
{
    public partial class FrmMewtocol : Form
    {
        EngineBase engine = null;

        bool isConnect = false;
        public bool IsConnect
        {
            get { return isConnect; }
            set 
            { 
                isConnect = value;
                btnDisconnect.Enabled = isConnect;
                btnGetPlcInfo.Enabled = isConnect;
                tabControl1.Enabled = isConnect;
            }
        }

        public FrmMewtocol()
        {
            InitializeComponent();
            foreach (string s in SerialPort.GetPortNames())
            {
                cbSerialPort.Items.Add(s);
            }
        }

        private void FrmTcp_Load(object sender, EventArgs e)
        {
            rbTcpIp.Checked = true;
            connectType_CheckedChanged(rbTcpIp, null);
            IsConnect = false;
           
        }

        private void GetPlcInfo_Click(object sender, EventArgs e)
        {
            //Test read PLC info
            var plcInfo = engine.GetPLCInfo();
            if (plcInfo != null)
            {
                foreach (var p in plcInfo.GetType().GetProperties())
                {
                    if (p.GetType().IsEnum)
                        ShowMessage($"{p.Name}: {Enum.GetName(p.GetType(), p.GetValue(plcInfo))}");
                    else
                        ShowMessage($"{p.Name}: {p.GetValue(plcInfo)}");
                }
            }
        }

        private void btnReadRegister_Click(object sender, EventArgs e)
        {
            string code = cbReadRegisterType.Text.Substring(0, 1);
            int address = Convert.ToInt32(txtReadRegisterAddress.Text);
            Type type = null;
            if (cbReadRegisterValueType.Text == "short")
                type = typeof(short);

            ShowMessage($"Read Data Area Resister.");
            ShowMessage($"Register Type: {cbReadRegisterType.Text}");
            ShowMessage($"Address: {txtReadRegisterAddress.Text}");
            ShowMessage($"Value Type: {type.Name}");

            var r = engine.ReadDataAreaRegister(code, address, type);

            ShowMessage($"Succcess: {r.Result.Success}");
            ShowMessage($"Response: {r.Result.Response}");
            ShowMessage($"Error: {r.Result.Error}");
            ShowMessage($"Error Description: {r.Result.ErrorDescription}");

            if (type == typeof(short))
                ShowMessage($"Value: {(short)(r.Value)}");
            else
                ShowMessage($"Value: {r.Value}");

            ShowMessage($" \r\n");
        }

        private void btnReadPoint_Click(object sender, EventArgs e)
        {
            string code = cbReadPointType.Text.Substring(0, 1);
            int address = Convert.ToInt32(txtReadPointAddress.Text);

            ShowMessage($"Read Contact Area Single Point.");
            ShowMessage($"Point Type: {code}");
            ShowMessage($"Address: {address}");

            var r = engine.ReadContactAreaSinglePoint(code, address);

            ShowMessage($"Succcess: {r.Result.Success}");
            ShowMessage($"Response: {r.Result.Response}");
            ShowMessage($"Error: {r.Result.Error}");
            ShowMessage($"Error Description: {r.Result.ErrorDescription}");
            ShowMessage($"Value: {r.Value}");

            ShowMessage($" \r\n");
        }

        private void btnWriteRegister_Click(object sender, EventArgs e)
        {
            string code = cbWriteRegisterType.Text.Substring(0, 1);
            int address = Convert.ToInt32(txtWriteRegisterAddress.Text);
            Type type = null;
            if (cbWriteRegisterValueType.Text == "short")
                type = typeof(short);
            object value = txtWriteRegisterValue.Text;

            ShowMessage($"Write Data Area Resister.");
            ShowMessage($"Register Type: {cbWriteRegisterType.Text}");
            ShowMessage($"Address: {address}");
            ShowMessage($"Value Type: {type.Name}");
            ShowMessage($"Value: {value}");

            var r = engine.WriteDataAreaRegister(code, address, type, value);

            ShowMessage($"Succcess: {r.Success}");
            ShowMessage($"Response: {r.Response}");
            ShowMessage($"Error: {r.Error}");
            ShowMessage($"Error Description: {r.ErrorDescription}");

            ShowMessage($" \r\n");
        }

        private void btnWritePoint_Click(object sender, EventArgs e)
        {
            string code = cbWritePointType.Text.Substring(0, 1);
            int address = Convert.ToInt32(txtWritePointAddress.Text);
            bool value = cbWritePointValue.Text == "true";

            ShowMessage($"Write Contact Area Single Point.");
            ShowMessage($"Point Type: {code}");
            ShowMessage($"Address: {address}");
            ShowMessage($"Value: {value}");

            var r = engine.WriteContactAreaSinglePoint(code, address, value);

            ShowMessage($"Succcess: {r.Success}");
            ShowMessage($"Response: {r.Response}");
            ShowMessage($"Error: {r.Error}");
            ShowMessage($"Error Description: {r.ErrorDescription}");

            ShowMessage($" \r\n");
        }

        private void ShowMessage(string message)
        {
            txtMessage.AppendText($"{message} \r\n");
        }

        private void connectType_CheckedChanged(object sender, EventArgs e)
        {
            txtIpAddress.Enabled = rbTcpIp.Checked;
            txtPort.Enabled = rbTcpIp.Checked;
            cbSerialPort.Enabled = !rbTcpIp.Checked;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbTcpIp.Checked)
                    engine = new TcpEngine(txtIpAddress.Text, Convert.ToInt32(txtPort.Text));
                else
                    engine = new ComEngine(cbSerialPort.Text, 115200, Parity.Odd, StopBits.One, 8);
                engine.Connect();
                IsConnect = engine.IsConnected;
                ShowMessage($"Connected. \r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            engine.Disconnect();
            ShowMessage($"Disconnected. \r\n");
        }
    }
}
