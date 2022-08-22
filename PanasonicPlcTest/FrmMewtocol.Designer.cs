namespace PanasonicPlcTest
{
    partial class FrmMewtocol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label16 = new System.Windows.Forms.Label();
            this.cbWritePointValue = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtWriteRegisterValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnWritePoint = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWritePointAddress = new System.Windows.Forms.TextBox();
            this.btnWriteRegister = new System.Windows.Forms.Button();
            this.cbWritePointType = new System.Windows.Forms.ComboBox();
            this.cbWriteRegisterValueType = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbReadRegisterType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReadRegisterAddress = new System.Windows.Forms.TextBox();
            this.cbReadRegisterValueType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReadPoint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReadPointAddress = new System.Windows.Forms.TextBox();
            this.cbReadPointType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWriteRegisterAddress = new System.Windows.Forms.TextBox();
            this.cbWriteRegisterType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnGetPlcInfo = new System.Windows.Forms.Button();
            this.rbTcpIp = new System.Windows.Forms.RadioButton();
            this.rbSerial = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(298, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 34;
            this.label16.Text = "Value:";
            // 
            // cbWritePointValue
            // 
            this.cbWritePointValue.FormattingEnabled = true;
            this.cbWritePointValue.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbWritePointValue.Location = new System.Drawing.Point(340, 92);
            this.cbWritePointValue.Name = "cbWritePointValue";
            this.cbWritePointValue.Size = new System.Drawing.Size(121, 20);
            this.cbWritePointValue.TabIndex = 33;
            this.cbWritePointValue.Text = "true";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 32;
            this.label15.Text = "Value:";
            // 
            // txtWriteRegisterValue
            // 
            this.txtWriteRegisterValue.Location = new System.Drawing.Point(98, 118);
            this.txtWriteRegisterValue.Name = "txtWriteRegisterValue";
            this.txtWriteRegisterValue.Size = new System.Drawing.Size(121, 22);
            this.txtWriteRegisterValue.TabIndex = 31;
            this.txtWriteRegisterValue.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "Write Contact Area Single Point";
            // 
            // btnWritePoint
            // 
            this.btnWritePoint.Location = new System.Drawing.Point(340, 118);
            this.btnWritePoint.Name = "btnWritePoint";
            this.btnWritePoint.Size = new System.Drawing.Size(121, 23);
            this.btnWritePoint.TabIndex = 30;
            this.btnWritePoint.Text = "Write Point";
            this.btnWritePoint.UseVisualStyleBackColor = true;
            this.btnWritePoint.Click += new System.EventHandler(this.btnWritePoint_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "Write Data Area Register Value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 26;
            this.label13.Text = "Point Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "Value Type:";
            // 
            // txtWritePointAddress
            // 
            this.txtWritePointAddress.Location = new System.Drawing.Point(340, 64);
            this.txtWritePointAddress.Name = "txtWritePointAddress";
            this.txtWritePointAddress.Size = new System.Drawing.Size(121, 22);
            this.txtWritePointAddress.TabIndex = 29;
            this.txtWritePointAddress.Text = "3";
            // 
            // btnWriteRegister
            // 
            this.btnWriteRegister.Location = new System.Drawing.Point(98, 146);
            this.btnWriteRegister.Name = "btnWriteRegister";
            this.btnWriteRegister.Size = new System.Drawing.Size(121, 23);
            this.btnWriteRegister.TabIndex = 16;
            this.btnWriteRegister.Text = "Write Register";
            this.btnWriteRegister.UseVisualStyleBackColor = true;
            this.btnWriteRegister.Click += new System.EventHandler(this.btnWriteRegister_Click);
            // 
            // cbWritePointType
            // 
            this.cbWritePointType.FormattingEnabled = true;
            this.cbWritePointType.Items.AddRange(new object[] {
            "X",
            "Y",
            "R",
            "L",
            "T",
            "C"});
            this.cbWritePointType.Location = new System.Drawing.Point(340, 38);
            this.cbWritePointType.Name = "cbWritePointType";
            this.cbWritePointType.Size = new System.Drawing.Size(47, 20);
            this.cbWritePointType.TabIndex = 27;
            this.cbWritePointType.Text = "X";
            // 
            // cbWriteRegisterValueType
            // 
            this.cbWriteRegisterValueType.FormattingEnabled = true;
            this.cbWriteRegisterValueType.Items.AddRange(new object[] {
            "short"});
            this.cbWriteRegisterValueType.Location = new System.Drawing.Point(98, 92);
            this.cbWriteRegisterValueType.Name = "cbWriteRegisterValueType";
            this.cbWriteRegisterValueType.Size = new System.Drawing.Size(121, 20);
            this.cbWriteRegisterValueType.TabIndex = 22;
            this.cbWriteRegisterValueType.Text = "short";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnReadRegister);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbReadRegisterType);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtReadRegisterAddress);
            this.tabPage1.Controls.Add(this.cbReadRegisterValueType);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnReadPoint);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtReadPointAddress);
            this.tabPage1.Controls.Add(this.cbReadPointType);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(674, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Read Data Area Register Value";
            // 
            // btnReadRegister
            // 
            this.btnReadRegister.Location = new System.Drawing.Point(96, 116);
            this.btnReadRegister.Name = "btnReadRegister";
            this.btnReadRegister.Size = new System.Drawing.Size(121, 23);
            this.btnReadRegister.TabIndex = 2;
            this.btnReadRegister.Text = "Read Register";
            this.btnReadRegister.UseVisualStyleBackColor = true;
            this.btnReadRegister.Click += new System.EventHandler(this.btnReadRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Register Type:";
            // 
            // cbReadRegisterType
            // 
            this.cbReadRegisterType.FormattingEnabled = true;
            this.cbReadRegisterType.Items.AddRange(new object[] {
            "DT",
            "LD",
            "FL"});
            this.cbReadRegisterType.Location = new System.Drawing.Point(96, 36);
            this.cbReadRegisterType.Name = "cbReadRegisterType";
            this.cbReadRegisterType.Size = new System.Drawing.Size(121, 20);
            this.cbReadRegisterType.TabIndex = 5;
            this.cbReadRegisterType.Text = "DT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address:";
            // 
            // txtReadRegisterAddress
            // 
            this.txtReadRegisterAddress.Location = new System.Drawing.Point(96, 62);
            this.txtReadRegisterAddress.Name = "txtReadRegisterAddress";
            this.txtReadRegisterAddress.Size = new System.Drawing.Size(121, 22);
            this.txtReadRegisterAddress.TabIndex = 7;
            this.txtReadRegisterAddress.Text = "0";
            // 
            // cbReadRegisterValueType
            // 
            this.cbReadRegisterValueType.FormattingEnabled = true;
            this.cbReadRegisterValueType.Items.AddRange(new object[] {
            "short"});
            this.cbReadRegisterValueType.Location = new System.Drawing.Point(96, 90);
            this.cbReadRegisterValueType.Name = "cbReadRegisterValueType";
            this.cbReadRegisterValueType.Size = new System.Drawing.Size(121, 20);
            this.cbReadRegisterValueType.TabIndex = 8;
            this.cbReadRegisterValueType.Text = "short";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Value Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Read Contact Area Single Point";
            // 
            // btnReadPoint
            // 
            this.btnReadPoint.Location = new System.Drawing.Point(345, 93);
            this.btnReadPoint.Name = "btnReadPoint";
            this.btnReadPoint.Size = new System.Drawing.Size(121, 23);
            this.btnReadPoint.TabIndex = 15;
            this.btnReadPoint.Text = "Read Point";
            this.btnReadPoint.UseVisualStyleBackColor = true;
            this.btnReadPoint.Click += new System.EventHandler(this.btnReadPoint_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Point Type:";
            // 
            // txtReadPointAddress
            // 
            this.txtReadPointAddress.Location = new System.Drawing.Point(345, 62);
            this.txtReadPointAddress.Name = "txtReadPointAddress";
            this.txtReadPointAddress.Size = new System.Drawing.Size(121, 22);
            this.txtReadPointAddress.TabIndex = 14;
            this.txtReadPointAddress.Text = "3";
            // 
            // cbReadPointType
            // 
            this.cbReadPointType.FormattingEnabled = true;
            this.cbReadPointType.Items.AddRange(new object[] {
            "X",
            "Y",
            "R",
            "L",
            "T",
            "C"});
            this.cbReadPointType.Location = new System.Drawing.Point(345, 36);
            this.cbReadPointType.Name = "cbReadPointType";
            this.cbReadPointType.Size = new System.Drawing.Size(47, 20);
            this.cbReadPointType.TabIndex = 12;
            this.cbReadPointType.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "Register Type:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.cbWritePointValue);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtWriteRegisterValue);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnWritePoint);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtWritePointAddress);
            this.tabPage2.Controls.Add(this.btnWriteRegister);
            this.tabPage2.Controls.Add(this.cbWritePointType);
            this.tabPage2.Controls.Add(this.cbWriteRegisterValueType);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtWriteRegisterAddress);
            this.tabPage2.Controls.Add(this.cbWriteRegisterType);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(674, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Write";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(288, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "Address:";
            // 
            // txtWriteRegisterAddress
            // 
            this.txtWriteRegisterAddress.Location = new System.Drawing.Point(98, 64);
            this.txtWriteRegisterAddress.Name = "txtWriteRegisterAddress";
            this.txtWriteRegisterAddress.Size = new System.Drawing.Size(121, 22);
            this.txtWriteRegisterAddress.TabIndex = 21;
            this.txtWriteRegisterAddress.Text = "0";
            // 
            // cbWriteRegisterType
            // 
            this.cbWriteRegisterType.FormattingEnabled = true;
            this.cbWriteRegisterType.Items.AddRange(new object[] {
            "DT",
            "LD",
            "FL"});
            this.cbWriteRegisterType.Location = new System.Drawing.Point(98, 38);
            this.cbWriteRegisterType.Name = "cbWriteRegisterType";
            this.cbWriteRegisterType.Size = new System.Drawing.Size(121, 20);
            this.cbWriteRegisterType.TabIndex = 19;
            this.cbWriteRegisterType.Text = "DT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "Address:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 149);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(682, 206);
            this.tabControl1.TabIndex = 27;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(12, 361);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(678, 262);
            this.txtMessage.TabIndex = 26;
            // 
            // btnGetPlcInfo
            // 
            this.btnGetPlcInfo.Location = new System.Drawing.Point(292, 94);
            this.btnGetPlcInfo.Name = "btnGetPlcInfo";
            this.btnGetPlcInfo.Size = new System.Drawing.Size(137, 23);
            this.btnGetPlcInfo.TabIndex = 25;
            this.btnGetPlcInfo.Text = "Read PLC Info";
            this.btnGetPlcInfo.UseVisualStyleBackColor = true;
            this.btnGetPlcInfo.Click += new System.EventHandler(this.GetPlcInfo_Click);
            // 
            // rbTcpIp
            // 
            this.rbTcpIp.AutoSize = true;
            this.rbTcpIp.Location = new System.Drawing.Point(16, 25);
            this.rbTcpIp.Name = "rbTcpIp";
            this.rbTcpIp.Size = new System.Drawing.Size(60, 16);
            this.rbTcpIp.TabIndex = 28;
            this.rbTcpIp.Text = "Tcp / IP";
            this.rbTcpIp.UseVisualStyleBackColor = true;
            this.rbTcpIp.CheckedChanged += new System.EventHandler(this.connectType_CheckedChanged);
            // 
            // rbSerial
            // 
            this.rbSerial.AutoSize = true;
            this.rbSerial.Location = new System.Drawing.Point(16, 58);
            this.rbSerial.Name = "rbSerial";
            this.rbSerial.Size = new System.Drawing.Size(71, 16);
            this.rbSerial.TabIndex = 29;
            this.rbSerial.Text = "Serial Port";
            this.rbSerial.UseVisualStyleBackColor = true;
            this.rbSerial.CheckedChanged += new System.EventHandler(this.connectType_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 94);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(137, 23);
            this.btnConnect.TabIndex = 30;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(173, 21);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(178, 22);
            this.txtIpAddress.TabIndex = 31;
            this.txtIpAddress.Text = "192.168.10.88";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(404, 21);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(82, 22);
            this.txtPort.TabIndex = 32;
            this.txtPort.Text = "32769";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(109, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 12);
            this.label17.TabIndex = 33;
            this.label17.Text = "IP Address:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(371, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 12);
            this.label18.TabIndex = 34;
            this.label18.Text = "Port:";
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(173, 53);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(178, 20);
            this.cbSerialPort.TabIndex = 35;
            this.cbSerialPort.Text = "COM1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.rbTcpIp);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbSerialPort);
            this.groupBox1.Controls.Add(this.btnGetPlcInfo);
            this.groupBox1.Controls.Add(this.rbSerial);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtIpAddress);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 130);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect To PLC";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(149, 94);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(137, 23);
            this.btnDisconnect.TabIndex = 36;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // FrmMewtocol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtMessage);
            this.Name = "FrmMewtocol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panasonic Mewtocol Test";
            this.Load += new System.EventHandler(this.FrmTcp_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbWritePointValue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtWriteRegisterValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnWritePoint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWritePointAddress;
        private System.Windows.Forms.Button btnWriteRegister;
        private System.Windows.Forms.ComboBox cbWritePointType;
        private System.Windows.Forms.ComboBox cbWriteRegisterValueType;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbReadRegisterType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReadRegisterAddress;
        private System.Windows.Forms.ComboBox cbReadRegisterValueType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReadPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReadPointAddress;
        private System.Windows.Forms.ComboBox cbReadPointType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtWriteRegisterAddress;
        private System.Windows.Forms.ComboBox cbWriteRegisterType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnGetPlcInfo;
        private System.Windows.Forms.RadioButton rbTcpIp;
        private System.Windows.Forms.RadioButton rbSerial;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDisconnect;
    }
}