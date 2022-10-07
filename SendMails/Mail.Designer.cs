namespace SendMails
{
    partial class Mail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsender = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtSMPTServer = new System.Windows.Forms.TextBox();
            this.txtportNo = new System.Windows.Forms.TextBox();
            this.txtreceiver = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.cbxSSl = new System.Windows.Forms.CheckBox();
            this.btnSendmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sender Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "SMTP Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Server Port No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reciever Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Subject";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Body";
            // 
            // txtsender
            // 
            this.txtsender.BackColor = System.Drawing.Color.Cyan;
            this.txtsender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsender.Location = new System.Drawing.Point(221, 52);
            this.txtsender.Name = "txtsender";
            this.txtsender.Size = new System.Drawing.Size(292, 27);
            this.txtsender.TabIndex = 7;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Cyan;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Location = new System.Drawing.Point(221, 91);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(292, 27);
            this.txtpassword.TabIndex = 7;
            // 
            // txtSMPTServer
            // 
            this.txtSMPTServer.BackColor = System.Drawing.Color.Cyan;
            this.txtSMPTServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSMPTServer.Location = new System.Drawing.Point(221, 130);
            this.txtSMPTServer.Name = "txtSMPTServer";
            this.txtSMPTServer.PlaceholderText = "smtp.gmail.com";
            this.txtSMPTServer.Size = new System.Drawing.Size(292, 27);
            this.txtSMPTServer.TabIndex = 7;
            // 
            // txtportNo
            // 
            this.txtportNo.BackColor = System.Drawing.Color.Cyan;
            this.txtportNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtportNo.Location = new System.Drawing.Point(221, 169);
            this.txtportNo.Name = "txtportNo";
            this.txtportNo.PlaceholderText = "587";
            this.txtportNo.Size = new System.Drawing.Size(292, 27);
            this.txtportNo.TabIndex = 7;
            // 
            // txtreceiver
            // 
            this.txtreceiver.BackColor = System.Drawing.Color.Cyan;
            this.txtreceiver.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtreceiver.Location = new System.Drawing.Point(221, 266);
            this.txtreceiver.Name = "txtreceiver";
            this.txtreceiver.Size = new System.Drawing.Size(292, 27);
            this.txtreceiver.TabIndex = 7;
            // 
            // txtsubject
            // 
            this.txtsubject.BackColor = System.Drawing.Color.Cyan;
            this.txtsubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsubject.Location = new System.Drawing.Point(221, 302);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(292, 27);
            this.txtsubject.TabIndex = 7;
            // 
            // txtbody
            // 
            this.txtbody.BackColor = System.Drawing.Color.Cyan;
            this.txtbody.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbody.Location = new System.Drawing.Point(221, 338);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(705, 206);
            this.txtbody.TabIndex = 7;
            // 
            // cbxSSl
            // 
            this.cbxSSl.AutoSize = true;
            this.cbxSSl.Location = new System.Drawing.Point(223, 220);
            this.cbxSSl.Name = "cbxSSl";
            this.cbxSSl.Size = new System.Drawing.Size(54, 27);
            this.cbxSSl.TabIndex = 8;
            this.cbxSSl.Text = "SSL";
            this.cbxSSl.UseVisualStyleBackColor = true;
            // 
            // btnSendmail
            // 
            this.btnSendmail.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSendmail.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnSendmail.Location = new System.Drawing.Point(221, 596);
            this.btnSendmail.Name = "btnSendmail";
            this.btnSendmail.Size = new System.Drawing.Size(123, 43);
            this.btnSendmail.TabIndex = 9;
            this.btnSendmail.Text = "SEND";
            this.btnSendmail.UseVisualStyleBackColor = false;
            this.btnSendmail.Click += new System.EventHandler(this.btnSendmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(964, 663);
            this.Controls.Add(this.btnSendmail);
            this.Controls.Add(this.cbxSSl);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtreceiver);
            this.Controls.Add(this.txtportNo);
            this.Controls.Add(this.txtSMPTServer);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtsender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtsender;
        private TextBox txtpassword;
        private TextBox txtSMPTServer;
        private TextBox txtportNo;
        private TextBox txtreceiver;
        private TextBox txtsubject;
        private TextBox txtbody;
        private CheckBox cbxSSl;
        private Button btnSendmail;
    }
}