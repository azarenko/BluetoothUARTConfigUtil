namespace HCBTConfig
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._comportName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._communication_baudrate = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this._communication_stop_bits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._connect = new System.Windows.Forms.Button();
            this._disconnect = new System.Windows.Forms.Button();
            this._parity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._baudrate = new System.Windows.Forms.ComboBox();
            this._stopbits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._name = new System.Windows.Forms.TextBox();
            this._read = new System.Windows.Forms.Button();
            this._write = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this._password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._communication_baudrate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com port:";
            // 
            // _comportName
            // 
            this._comportName.FormattingEnabled = true;
            this._comportName.Location = new System.Drawing.Point(64, 24);
            this._comportName.Name = "_comportName";
            this._comportName.Size = new System.Drawing.Size(121, 21);
            this._comportName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate";
            // 
            // _communication_baudrate
            // 
            this._communication_baudrate.Controls.Add(this._disconnect);
            this._communication_baudrate.Controls.Add(this._connect);
            this._communication_baudrate.Controls.Add(this.comboBox3);
            this._communication_baudrate.Controls.Add(this.label4);
            this._communication_baudrate.Controls.Add(this.comboBox2);
            this._communication_baudrate.Controls.Add(this._communication_stop_bits);
            this._communication_baudrate.Controls.Add(this.label3);
            this._communication_baudrate.Controls.Add(this.label1);
            this._communication_baudrate.Controls.Add(this._comportName);
            this._communication_baudrate.Controls.Add(this.label2);
            this._communication_baudrate.Location = new System.Drawing.Point(12, 12);
            this._communication_baudrate.Name = "_communication_baudrate";
            this._communication_baudrate.Size = new System.Drawing.Size(270, 160);
            this._communication_baudrate.TabIndex = 4;
            this._communication_baudrate.TabStop = false;
            this._communication_baudrate.Text = "Configuration communication";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBox3.Location = new System.Drawing.Point(64, 103);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(76, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "234000",
            "460800",
            "921600",
            "1382400"});
            this.comboBox2.Location = new System.Drawing.Point(64, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // _communication_stop_bits
            // 
            this._communication_stop_bits.FormattingEnabled = true;
            this._communication_stop_bits.Items.AddRange(new object[] {
            "1",
            "2"});
            this._communication_stop_bits.Location = new System.Drawing.Point(64, 76);
            this._communication_stop_bits.Name = "_communication_stop_bits";
            this._communication_stop_bits.Size = new System.Drawing.Size(76, 21);
            this._communication_stop_bits.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stop Bits";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._password);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this._write);
            this.groupBox2.Controls.Add(this._read);
            this.groupBox2.Controls.Add(this._name);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this._parity);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this._baudrate);
            this.groupBox2.Controls.Add(this._stopbits);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 197);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Work communication";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 390);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(294, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // _connect
            // 
            this._connect.Location = new System.Drawing.Point(9, 130);
            this._connect.Name = "_connect";
            this._connect.Size = new System.Drawing.Size(75, 23);
            this._connect.TabIndex = 9;
            this._connect.Text = "Connect";
            this._connect.UseVisualStyleBackColor = true;
            // 
            // _disconnect
            // 
            this._disconnect.Location = new System.Drawing.Point(90, 130);
            this._disconnect.Name = "_disconnect";
            this._disconnect.Size = new System.Drawing.Size(75, 23);
            this._disconnect.TabIndex = 10;
            this._disconnect.Text = "Disconnect";
            this._disconnect.UseVisualStyleBackColor = true;
            // 
            // _parity
            // 
            this._parity.FormattingEnabled = true;
            this._parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this._parity.Location = new System.Drawing.Point(64, 133);
            this._parity.Name = "_parity";
            this._parity.Size = new System.Drawing.Size(76, 21);
            this._parity.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Parity";
            // 
            // _baudrate
            // 
            this._baudrate.FormattingEnabled = true;
            this._baudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "234000",
            "460800",
            "921600",
            "1382400"});
            this._baudrate.Location = new System.Drawing.Point(64, 81);
            this._baudrate.Name = "_baudrate";
            this._baudrate.Size = new System.Drawing.Size(121, 21);
            this._baudrate.TabIndex = 12;
            // 
            // _stopbits
            // 
            this._stopbits.FormattingEnabled = true;
            this._stopbits.Items.AddRange(new object[] {
            "1",
            "2"});
            this._stopbits.Location = new System.Drawing.Point(64, 106);
            this._stopbits.Name = "_stopbits";
            this._stopbits.Size = new System.Drawing.Size(76, 21);
            this._stopbits.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stop Bits";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Baudrate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Name";
            // 
            // _name
            // 
            this._name.Location = new System.Drawing.Point(64, 29);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(181, 20);
            this._name.TabIndex = 16;
            // 
            // _read
            // 
            this._read.Location = new System.Drawing.Point(8, 162);
            this._read.Name = "_read";
            this._read.Size = new System.Drawing.Size(75, 23);
            this._read.TabIndex = 17;
            this._read.Text = "Read";
            this._read.UseVisualStyleBackColor = true;
            // 
            // _write
            // 
            this._write.Location = new System.Drawing.Point(89, 162);
            this._write.Name = "_write";
            this._write.Size = new System.Drawing.Size(75, 23);
            this._write.TabIndex = 18;
            this._write.Text = "Write";
            this._write.UseVisualStyleBackColor = true;
            // 
            // _password
            // 
            this._password.Location = new System.Drawing.Point(64, 55);
            this._password.Name = "_password";
            this._password.Size = new System.Drawing.Size(121, 20);
            this._password.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 412);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._communication_baudrate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "HC module configuration (Azarenko S.A.)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this._communication_baudrate.ResumeLayout(false);
            this._communication_baudrate.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _comportName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox _communication_baudrate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox _communication_stop_bits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button _disconnect;
        private System.Windows.Forms.Button _connect;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox _parity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _baudrate;
        private System.Windows.Forms.ComboBox _stopbits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button _write;
        private System.Windows.Forms.Button _read;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox _password;
        private System.Windows.Forms.Label label9;
    }
}

