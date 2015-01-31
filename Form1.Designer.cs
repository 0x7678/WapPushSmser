namespace PDU
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_receiver = new System.Windows.Forms.TextBox();
            this.tb_header = new System.Windows.Forms.TextBox();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_startdate = new System.Windows.Forms.TextBox();
            this.tb_enddate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_rawpdu = new System.Windows.Forms.TextBox();
            this.btngen = new System.Windows.Forms.Button();
            this.lb_headercount = new System.Windows.Forms.Label();
            this.lb_smscount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_comports = new System.Windows.Forms.ComboBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnsendpdu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_mode = new System.Windows.Forms.ComboBox();
            this.btnpdumode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receiver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Header";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message";
            // 
            // tb_receiver
            // 
            this.tb_receiver.Location = new System.Drawing.Point(67, 30);
            this.tb_receiver.Name = "tb_receiver";
            this.tb_receiver.Size = new System.Drawing.Size(221, 20);
            this.tb_receiver.TabIndex = 3;
            this.tb_receiver.Text = "123456789012";
            // 
            // tb_header
            // 
            this.tb_header.Location = new System.Drawing.Point(67, 53);
            this.tb_header.Name = "tb_header";
            this.tb_header.Size = new System.Drawing.Size(119, 20);
            this.tb_header.TabIndex = 4;
            this.tb_header.Text = "18digitslen.com";
            this.tb_header.TextChanged += new System.EventHandler(this.OnTextChangeHeader);
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(67, 76);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(221, 34);
            this.tb_message.TabIndex = 5;
            this.tb_message.Text = "Hello world";
            this.tb_message.TextChanged += new System.EventHandler(this.OnMessageChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start Date";
            // 
            // tb_startdate
            // 
            this.tb_startdate.Location = new System.Drawing.Point(66, 113);
            this.tb_startdate.Name = "tb_startdate";
            this.tb_startdate.Size = new System.Drawing.Size(79, 20);
            this.tb_startdate.TabIndex = 7;
            this.tb_startdate.Text = "201412132221";
            // 
            // tb_enddate
            // 
            this.tb_enddate.Location = new System.Drawing.Point(208, 114);
            this.tb_enddate.Name = "tb_enddate";
            this.tb_enddate.Size = new System.Drawing.Size(79, 20);
            this.tb_enddate.TabIndex = 9;
            this.tb_enddate.Text = "201412282221";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Raw Pdu";
            // 
            // tb_rawpdu
            // 
            this.tb_rawpdu.Location = new System.Drawing.Point(67, 165);
            this.tb_rawpdu.Multiline = true;
            this.tb_rawpdu.Name = "tb_rawpdu";
            this.tb_rawpdu.Size = new System.Drawing.Size(221, 102);
            this.tb_rawpdu.TabIndex = 11;
            // 
            // btngen
            // 
            this.btngen.Location = new System.Drawing.Point(66, 272);
            this.btngen.Name = "btngen";
            this.btngen.Size = new System.Drawing.Size(75, 23);
            this.btngen.TabIndex = 12;
            this.btngen.Text = "Generate";
            this.btngen.UseVisualStyleBackColor = true;
            this.btngen.Click += new System.EventHandler(this.btngen_Click);
            // 
            // lb_headercount
            // 
            this.lb_headercount.AutoSize = true;
            this.lb_headercount.Location = new System.Drawing.Point(192, 56);
            this.lb_headercount.Name = "lb_headercount";
            this.lb_headercount.Size = new System.Drawing.Size(61, 13);
            this.lb_headercount.TabIndex = 13;
            this.lb_headercount.Text = "(18)Length:";
            // 
            // lb_smscount
            // 
            this.lb_smscount.AutoSize = true;
            this.lb_smscount.Location = new System.Drawing.Point(1, 91);
            this.lb_smscount.Name = "lb_smscount";
            this.lb_smscount.Size = new System.Drawing.Size(45, 13);
            this.lb_smscount.TabIndex = 14;
            this.lb_smscount.Text = "sms len:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Com Port";
            // 
            // cb_comports
            // 
            this.cb_comports.FormattingEnabled = true;
            this.cb_comports.Location = new System.Drawing.Point(68, 5);
            this.cb_comports.Name = "cb_comports";
            this.cb_comports.Size = new System.Drawing.Size(121, 21);
            this.cb_comports.TabIndex = 16;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(196, 4);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 17;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnsendpdu
            // 
            this.btnsendpdu.Location = new System.Drawing.Point(147, 272);
            this.btnsendpdu.Name = "btnsendpdu";
            this.btnsendpdu.Size = new System.Drawing.Size(75, 23);
            this.btnsendpdu.TabIndex = 18;
            this.btnsendpdu.Text = "Send Pdu";
            this.btnsendpdu.UseVisualStyleBackColor = true;
            this.btnsendpdu.Click += new System.EventHandler(this.btnsendpdu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mode:";
            // 
            // cb_mode
            // 
            this.cb_mode.FormattingEnabled = true;
            this.cb_mode.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "0A",
            "0B",
            "0C",
            "0D",
            "0E",
            "0F"});
            this.cb_mode.Location = new System.Drawing.Point(70, 139);
            this.cb_mode.Name = "cb_mode";
            this.cb_mode.Size = new System.Drawing.Size(43, 21);
            this.cb_mode.TabIndex = 20;
            // 
            // btnpdumode
            // 
            this.btnpdumode.Location = new System.Drawing.Point(10, 174);
            this.btnpdumode.Name = "btnpdumode";
            this.btnpdumode.Size = new System.Drawing.Size(54, 38);
            this.btnpdumode.TabIndex = 21;
            this.btnpdumode.Text = "Pdu Mode";
            this.btnpdumode.UseVisualStyleBackColor = true;
            this.btnpdumode.Click += new System.EventHandler(this.btnpdumode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 298);
            this.Controls.Add(this.btnpdumode);
            this.Controls.Add(this.cb_mode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnsendpdu);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.cb_comports);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_smscount);
            this.Controls.Add(this.lb_headercount);
            this.Controls.Add(this.btngen);
            this.Controls.Add(this.tb_rawpdu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_enddate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_startdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.tb_header);
            this.Controls.Add(this.tb_receiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WapPush Sms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_receiver;
        private System.Windows.Forms.TextBox tb_header;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_startdate;
        private System.Windows.Forms.TextBox tb_enddate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_rawpdu;
        private System.Windows.Forms.Button btngen;
        private System.Windows.Forms.Label lb_headercount;
        private System.Windows.Forms.Label lb_smscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_comports;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnsendpdu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_mode;
        private System.Windows.Forms.Button btnpdumode;
    }
}

