namespace Modbus_String
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtIpAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPort = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            txtSlaveID = new TextBox();
            label4 = new Label();
            txtFirstRegister = new TextBox();
            panel3 = new Panel();
            btnReadFromModbus = new Button();
            btnWriteToModbus = new Button();
            lblReg1 = new Label();
            txtReg1 = new TextBox();
            txtReg2 = new TextBox();
            lblReg2 = new Label();
            txtReg3 = new TextBox();
            lblReg3 = new Label();
            txtReg4 = new TextBox();
            lblReg4 = new Label();
            txtReg8 = new TextBox();
            lblReg8 = new Label();
            txtReg7 = new TextBox();
            lblReg7 = new Label();
            txtReg6 = new TextBox();
            lblReg6 = new Label();
            txtReg5 = new TextBox();
            lblReg5 = new Label();
            txtReg12 = new TextBox();
            lblReg12 = new Label();
            txtReg11 = new TextBox();
            lblReg11 = new Label();
            txtReg10 = new TextBox();
            lblReg10 = new Label();
            txtReg9 = new TextBox();
            lblReg9 = new Label();
            txtReg16 = new TextBox();
            lblReg16 = new Label();
            txtReg15 = new TextBox();
            lblReg15 = new Label();
            txtReg14 = new TextBox();
            lblReg14 = new Label();
            txtReg13 = new TextBox();
            lblReg13 = new Label();
            txtString = new TextBox();
            label36 = new Label();
            label37 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            btnTable = new Button();
            btnGenerate = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtIpAddress
            // 
            txtIpAddress.Location = new Point(12, 32);
            txtIpAddress.MaxLength = 15;
            txtIpAddress.Name = "txtIpAddress";
            txtIpAddress.Size = new Size(121, 27);
            txtIpAddress.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "Indirizzo IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 3;
            label2.Text = "Porta";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(155, 32);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(63, 27);
            txtPort.TabIndex = 4;
            txtPort.KeyPress += txtPort_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 5;
            label3.Text = "Slave ID";
            // 
            // panel1
            // 
            panel1.Location = new Point(139, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 27);
            panel1.TabIndex = 6;
            // 
            // txtSlaveID
            // 
            txtSlaveID.Location = new Point(12, 85);
            txtSlaveID.MaxLength = 3;
            txtSlaveID.Name = "txtSlaveID";
            txtSlaveID.Size = new Size(63, 27);
            txtSlaveID.TabIndex = 8;
            txtSlaveID.KeyPress += txtSlaveID_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 62);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 9;
            label4.Text = "Primo registro";
            // 
            // txtFirstRegister
            // 
            txtFirstRegister.Location = new Point(97, 85);
            txtFirstRegister.MaxLength = 4;
            txtFirstRegister.Name = "txtFirstRegister";
            txtFirstRegister.Size = new Size(121, 27);
            txtFirstRegister.TabIndex = 10;
            txtFirstRegister.KeyPress += txtFirstRegister_KeyPress;
            // 
            // panel3
            // 
            panel3.Location = new Point(81, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 27);
            panel3.TabIndex = 7;
            // 
            // btnReadFromModbus
            // 
            btnReadFromModbus.Location = new Point(260, 62);
            btnReadFromModbus.Name = "btnReadFromModbus";
            btnReadFromModbus.Size = new Size(110, 29);
            btnReadFromModbus.TabIndex = 15;
            btnReadFromModbus.Text = "Leggi";
            btnReadFromModbus.UseVisualStyleBackColor = true;
            btnReadFromModbus.Click += btnReadFromModbus_Click;
            // 
            // btnWriteToModbus
            // 
            btnWriteToModbus.Location = new Point(260, 97);
            btnWriteToModbus.Name = "btnWriteToModbus";
            btnWriteToModbus.Size = new Size(110, 29);
            btnWriteToModbus.TabIndex = 16;
            btnWriteToModbus.Text = "Scrivi";
            btnWriteToModbus.UseVisualStyleBackColor = true;
            btnWriteToModbus.Click += btnWriteToModbus_Click;
            // 
            // lblReg1
            // 
            lblReg1.AutoSize = true;
            lblReg1.Location = new Point(12, 159);
            lblReg1.Name = "lblReg1";
            lblReg1.Size = new Size(45, 20);
            lblReg1.TabIndex = 17;
            lblReg1.Text = "4xxxx";
            // 
            // txtReg1
            // 
            txtReg1.Location = new Point(67, 156);
            txtReg1.Name = "txtReg1";
            txtReg1.ReadOnly = true;
            txtReg1.Size = new Size(90, 27);
            txtReg1.TabIndex = 18;
            txtReg1.TabStop = false;
            // 
            // txtReg2
            // 
            txtReg2.Location = new Point(67, 189);
            txtReg2.Name = "txtReg2";
            txtReg2.ReadOnly = true;
            txtReg2.Size = new Size(90, 27);
            txtReg2.TabIndex = 20;
            txtReg2.TabStop = false;
            // 
            // lblReg2
            // 
            lblReg2.AutoSize = true;
            lblReg2.Location = new Point(12, 192);
            lblReg2.Name = "lblReg2";
            lblReg2.Size = new Size(45, 20);
            lblReg2.TabIndex = 19;
            lblReg2.Text = "4xxxx";
            // 
            // txtReg3
            // 
            txtReg3.Location = new Point(67, 222);
            txtReg3.Name = "txtReg3";
            txtReg3.ReadOnly = true;
            txtReg3.Size = new Size(90, 27);
            txtReg3.TabIndex = 22;
            // 
            // lblReg3
            // 
            lblReg3.AutoSize = true;
            lblReg3.Location = new Point(12, 225);
            lblReg3.Name = "lblReg3";
            lblReg3.Size = new Size(45, 20);
            lblReg3.TabIndex = 21;
            lblReg3.Text = "4xxxx";
            // 
            // txtReg4
            // 
            txtReg4.Location = new Point(67, 255);
            txtReg4.Name = "txtReg4";
            txtReg4.ReadOnly = true;
            txtReg4.Size = new Size(90, 27);
            txtReg4.TabIndex = 24;
            // 
            // lblReg4
            // 
            lblReg4.AutoSize = true;
            lblReg4.Location = new Point(12, 258);
            lblReg4.Name = "lblReg4";
            lblReg4.Size = new Size(45, 20);
            lblReg4.TabIndex = 23;
            lblReg4.Text = "4xxxx";
            // 
            // txtReg8
            // 
            txtReg8.Location = new Point(224, 255);
            txtReg8.Name = "txtReg8";
            txtReg8.ReadOnly = true;
            txtReg8.Size = new Size(90, 27);
            txtReg8.TabIndex = 40;
            // 
            // lblReg8
            // 
            lblReg8.AutoSize = true;
            lblReg8.Location = new Point(169, 258);
            lblReg8.Name = "lblReg8";
            lblReg8.Size = new Size(45, 20);
            lblReg8.TabIndex = 39;
            lblReg8.Text = "4xxxx";
            // 
            // txtReg7
            // 
            txtReg7.Location = new Point(224, 222);
            txtReg7.Name = "txtReg7";
            txtReg7.ReadOnly = true;
            txtReg7.Size = new Size(90, 27);
            txtReg7.TabIndex = 38;
            // 
            // lblReg7
            // 
            lblReg7.AutoSize = true;
            lblReg7.Location = new Point(169, 225);
            lblReg7.Name = "lblReg7";
            lblReg7.Size = new Size(45, 20);
            lblReg7.TabIndex = 37;
            lblReg7.Text = "4xxxx";
            // 
            // txtReg6
            // 
            txtReg6.Location = new Point(224, 189);
            txtReg6.Name = "txtReg6";
            txtReg6.ReadOnly = true;
            txtReg6.Size = new Size(90, 27);
            txtReg6.TabIndex = 36;
            // 
            // lblReg6
            // 
            lblReg6.AutoSize = true;
            lblReg6.Location = new Point(169, 192);
            lblReg6.Name = "lblReg6";
            lblReg6.Size = new Size(45, 20);
            lblReg6.TabIndex = 35;
            lblReg6.Text = "4xxxx";
            // 
            // txtReg5
            // 
            txtReg5.Location = new Point(224, 156);
            txtReg5.Name = "txtReg5";
            txtReg5.ReadOnly = true;
            txtReg5.Size = new Size(90, 27);
            txtReg5.TabIndex = 34;
            // 
            // lblReg5
            // 
            lblReg5.AutoSize = true;
            lblReg5.Location = new Point(169, 159);
            lblReg5.Name = "lblReg5";
            lblReg5.Size = new Size(45, 20);
            lblReg5.TabIndex = 33;
            lblReg5.Text = "4xxxx";
            // 
            // txtReg12
            // 
            txtReg12.Location = new Point(395, 254);
            txtReg12.Name = "txtReg12";
            txtReg12.ReadOnly = true;
            txtReg12.Size = new Size(90, 27);
            txtReg12.TabIndex = 56;
            // 
            // lblReg12
            // 
            lblReg12.AutoSize = true;
            lblReg12.Location = new Point(340, 257);
            lblReg12.Name = "lblReg12";
            lblReg12.Size = new Size(45, 20);
            lblReg12.TabIndex = 55;
            lblReg12.Text = "4xxxx";
            // 
            // txtReg11
            // 
            txtReg11.Location = new Point(395, 221);
            txtReg11.Name = "txtReg11";
            txtReg11.ReadOnly = true;
            txtReg11.Size = new Size(90, 27);
            txtReg11.TabIndex = 54;
            // 
            // lblReg11
            // 
            lblReg11.AutoSize = true;
            lblReg11.Location = new Point(340, 224);
            lblReg11.Name = "lblReg11";
            lblReg11.Size = new Size(45, 20);
            lblReg11.TabIndex = 53;
            lblReg11.Text = "4xxxx";
            // 
            // txtReg10
            // 
            txtReg10.Location = new Point(395, 188);
            txtReg10.Name = "txtReg10";
            txtReg10.ReadOnly = true;
            txtReg10.Size = new Size(90, 27);
            txtReg10.TabIndex = 52;
            // 
            // lblReg10
            // 
            lblReg10.AutoSize = true;
            lblReg10.Location = new Point(340, 191);
            lblReg10.Name = "lblReg10";
            lblReg10.Size = new Size(45, 20);
            lblReg10.TabIndex = 51;
            lblReg10.Text = "4xxxx";
            // 
            // txtReg9
            // 
            txtReg9.Location = new Point(395, 155);
            txtReg9.Name = "txtReg9";
            txtReg9.ReadOnly = true;
            txtReg9.Size = new Size(90, 27);
            txtReg9.TabIndex = 50;
            // 
            // lblReg9
            // 
            lblReg9.AutoSize = true;
            lblReg9.Location = new Point(340, 158);
            lblReg9.Name = "lblReg9";
            lblReg9.Size = new Size(45, 20);
            lblReg9.TabIndex = 49;
            lblReg9.Text = "4xxxx";
            // 
            // txtReg16
            // 
            txtReg16.Location = new Point(565, 255);
            txtReg16.Name = "txtReg16";
            txtReg16.ReadOnly = true;
            txtReg16.Size = new Size(90, 27);
            txtReg16.TabIndex = 72;
            // 
            // lblReg16
            // 
            lblReg16.AutoSize = true;
            lblReg16.Location = new Point(510, 258);
            lblReg16.Name = "lblReg16";
            lblReg16.Size = new Size(45, 20);
            lblReg16.TabIndex = 71;
            lblReg16.Text = "4xxxx";
            // 
            // txtReg15
            // 
            txtReg15.Location = new Point(565, 222);
            txtReg15.Name = "txtReg15";
            txtReg15.ReadOnly = true;
            txtReg15.Size = new Size(90, 27);
            txtReg15.TabIndex = 70;
            // 
            // lblReg15
            // 
            lblReg15.AutoSize = true;
            lblReg15.Location = new Point(510, 225);
            lblReg15.Name = "lblReg15";
            lblReg15.Size = new Size(45, 20);
            lblReg15.TabIndex = 69;
            lblReg15.Text = "4xxxx";
            // 
            // txtReg14
            // 
            txtReg14.Location = new Point(565, 189);
            txtReg14.Name = "txtReg14";
            txtReg14.ReadOnly = true;
            txtReg14.Size = new Size(90, 27);
            txtReg14.TabIndex = 68;
            // 
            // lblReg14
            // 
            lblReg14.AutoSize = true;
            lblReg14.Location = new Point(510, 192);
            lblReg14.Name = "lblReg14";
            lblReg14.Size = new Size(45, 20);
            lblReg14.TabIndex = 67;
            lblReg14.Text = "4xxxx";
            // 
            // txtReg13
            // 
            txtReg13.Location = new Point(565, 156);
            txtReg13.Name = "txtReg13";
            txtReg13.ReadOnly = true;
            txtReg13.Size = new Size(90, 27);
            txtReg13.TabIndex = 66;
            // 
            // lblReg13
            // 
            lblReg13.AutoSize = true;
            lblReg13.Location = new Point(510, 159);
            lblReg13.Name = "lblReg13";
            lblReg13.Size = new Size(45, 20);
            lblReg13.TabIndex = 65;
            lblReg13.Text = "4xxxx";
            // 
            // txtString
            // 
            txtString.Location = new Point(260, 32);
            txtString.MaxLength = 32;
            txtString.Name = "txtString";
            txtString.Size = new Size(226, 27);
            txtString.TabIndex = 81;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(12, 124);
            label36.Name = "label36";
            label36.Size = new Size(226, 20);
            label36.TabIndex = 82;
            label36.Text = "Elenco holding registers Modbus";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(260, 9);
            label37.Name = "label37";
            label37.Size = new Size(229, 20);
            label37.TabIndex = 83;
            label37.Text = "Stringa Industry 4.0 (32 char max)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(505, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(159, 114);
            groupBox1.TabIndex = 84;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 33);
            label5.Name = "label5";
            label5.Size = new Size(131, 60);
            label5.TabIndex = 0;
            label5.Text = "Un altro software\r\nscritto da Ivan ;)\r\nIvanMazzoli @ GH\r\n";
            // 
            // btnTable
            // 
            btnTable.Location = new Point(376, 97);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(110, 29);
            btnTable.TabIndex = 85;
            btnTable.Text = "Tabella";
            btnTable.UseVisualStyleBackColor = true;
            btnTable.Click += btnTest_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(375, 62);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(110, 29);
            btnGenerate.TabIndex = 86;
            btnGenerate.Text = "Genera valori";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 300);
            Controls.Add(btnGenerate);
            Controls.Add(btnTable);
            Controls.Add(groupBox1);
            Controls.Add(label37);
            Controls.Add(label36);
            Controls.Add(txtString);
            Controls.Add(txtReg16);
            Controls.Add(lblReg16);
            Controls.Add(txtReg15);
            Controls.Add(lblReg15);
            Controls.Add(txtReg14);
            Controls.Add(lblReg14);
            Controls.Add(txtReg13);
            Controls.Add(lblReg13);
            Controls.Add(txtReg12);
            Controls.Add(lblReg12);
            Controls.Add(txtReg11);
            Controls.Add(lblReg11);
            Controls.Add(txtReg10);
            Controls.Add(lblReg10);
            Controls.Add(txtReg9);
            Controls.Add(lblReg9);
            Controls.Add(txtReg8);
            Controls.Add(lblReg8);
            Controls.Add(txtReg7);
            Controls.Add(lblReg7);
            Controls.Add(txtReg6);
            Controls.Add(lblReg6);
            Controls.Add(txtReg5);
            Controls.Add(lblReg5);
            Controls.Add(txtReg4);
            Controls.Add(lblReg4);
            Controls.Add(txtReg3);
            Controls.Add(lblReg3);
            Controls.Add(txtReg2);
            Controls.Add(lblReg2);
            Controls.Add(txtReg1);
            Controls.Add(lblReg1);
            Controls.Add(btnWriteToModbus);
            Controls.Add(btnReadFromModbus);
            Controls.Add(panel3);
            Controls.Add(txtFirstRegister);
            Controls.Add(label4);
            Controls.Add(txtSlaveID);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(txtPort);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIpAddress);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modbus String";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIpAddress;
        private Label label1;
        private Label label2;
        private TextBox txtPort;
        private Label label3;
        private Panel panel1;
        private TextBox txtSlaveID;
        private Label label4;
        private TextBox txtFirstRegister;
        private Panel panel3;
        private Button btnReadFromModbus;
        private Button btnWriteToModbus;
        private Label lblReg1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblReg2;
        private TextBox textBox4;
        private Label lblReg3;
        private TextBox textBox5;
        private Label lblReg4;
        private TextBox textBox14;
        private Label lblReg8;
        private TextBox textBox15;
        private Label lblReg7;
        private TextBox textBox16;
        private Label lblReg6;
        private TextBox textBox17;
        private Label lblReg5;
        private TextBox textBox22;
        private Label lblReg12;
        private TextBox textBox23;
        private Label lblReg11;
        private TextBox textBox24;
        private Label lblReg10;
        private TextBox textBox25;
        private Label lblReg9;
        private TextBox textBox30;
        private Label lblReg16;
        private TextBox textBox31;
        private Label lblReg15;
        private TextBox textBox32;
        private Label lblReg14;
        private TextBox textBox33;
        private Label lblReg13;
        private TextBox txtString;
        private Label label36;
        private Label label37;
        private GroupBox groupBox1;
        private TextBox txtReg1;
        private TextBox txtReg2;
        private TextBox txtReg3;
        private TextBox txtReg4;
        private TextBox txtReg8;
        private TextBox txtReg7;
        private TextBox txtReg6;
        private TextBox txtReg5;
        private TextBox txtReg12;
        private TextBox txtReg11;
        private TextBox txtReg10;
        private TextBox txtReg9;
        private TextBox txtReg16;
        private TextBox txtReg15;
        private TextBox txtReg14;
        private TextBox txtReg13;
        private Label label5;
        private Button btnTable;
        private Button btnGenerate;
    }
}