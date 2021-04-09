
namespace LogUp
{
    partial class ContactUs
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
            this.contactusLbl = new System.Windows.Forms.Label();
            this.senderGbox = new System.Windows.Forms.GroupBox();
            this.sendmailLbl = new System.Windows.Forms.Label();
            this.sendmailTbox = new System.Windows.Forms.TextBox();
            this.sendpasswordTbox = new System.Windows.Forms.TextBox();
            this.sendpasswordLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.subjectLbl = new System.Windows.Forms.Label();
            this.subjectTbox = new System.Windows.Forms.TextBox();
            this.mesageGbox = new System.Windows.Forms.GroupBox();
            this.messageTbox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.sslCbox = new System.Windows.Forms.CheckBox();
            this.senderGbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mesageGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactusLbl
            // 
            this.contactusLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contactusLbl.AutoSize = true;
            this.contactusLbl.BackColor = System.Drawing.Color.Transparent;
            this.contactusLbl.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactusLbl.Location = new System.Drawing.Point(480, 13);
            this.contactusLbl.Name = "contactusLbl";
            this.contactusLbl.Size = new System.Drawing.Size(214, 50);
            this.contactusLbl.TabIndex = 0;
            this.contactusLbl.Text = "Contact us";
            // 
            // senderGbox
            // 
            this.senderGbox.BackColor = System.Drawing.Color.Transparent;
            this.senderGbox.Controls.Add(this.sendmailLbl);
            this.senderGbox.Controls.Add(this.sslCbox);
            this.senderGbox.Controls.Add(this.sendmailTbox);
            this.senderGbox.Controls.Add(this.sendpasswordTbox);
            this.senderGbox.Controls.Add(this.sendpasswordLbl);
            this.senderGbox.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderGbox.ForeColor = System.Drawing.Color.Yellow;
            this.senderGbox.Location = new System.Drawing.Point(13, 68);
            this.senderGbox.Name = "senderGbox";
            this.senderGbox.Size = new System.Drawing.Size(560, 202);
            this.senderGbox.TabIndex = 1;
            this.senderGbox.TabStop = false;
            this.senderGbox.Text = "Sender Info";
            // 
            // sendmailLbl
            // 
            this.sendmailLbl.AutoSize = true;
            this.sendmailLbl.Location = new System.Drawing.Point(10, 53);
            this.sendmailLbl.Name = "sendmailLbl";
            this.sendmailLbl.Size = new System.Drawing.Size(80, 31);
            this.sendmailLbl.TabIndex = 2;
            this.sendmailLbl.Text = "Email:";
            // 
            // sendmailTbox
            // 
            this.sendmailTbox.Location = new System.Drawing.Point(183, 50);
            this.sendmailTbox.Name = "sendmailTbox";
            this.sendmailTbox.Size = new System.Drawing.Size(371, 38);
            this.sendmailTbox.TabIndex = 3;
            // 
            // sendpasswordTbox
            // 
            this.sendpasswordTbox.Location = new System.Drawing.Point(183, 94);
            this.sendpasswordTbox.Name = "sendpasswordTbox";
            this.sendpasswordTbox.PasswordChar = '*';
            this.sendpasswordTbox.Size = new System.Drawing.Size(368, 38);
            this.sendpasswordTbox.TabIndex = 3;
            // 
            // sendpasswordLbl
            // 
            this.sendpasswordLbl.AutoSize = true;
            this.sendpasswordLbl.Location = new System.Drawing.Point(6, 97);
            this.sendpasswordLbl.Name = "sendpasswordLbl";
            this.sendpasswordLbl.Size = new System.Drawing.Size(128, 31);
            this.sendpasswordLbl.TabIndex = 2;
            this.sendpasswordLbl.Text = "Password:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.subjectLbl);
            this.groupBox2.Controls.Add(this.subjectTbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(13, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 117);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email Details";
            // 
            // subjectLbl
            // 
            this.subjectLbl.AutoSize = true;
            this.subjectLbl.Location = new System.Drawing.Point(7, 59);
            this.subjectLbl.Name = "subjectLbl";
            this.subjectLbl.Size = new System.Drawing.Size(105, 31);
            this.subjectLbl.TabIndex = 2;
            this.subjectLbl.Text = "Subject:";
            // 
            // subjectTbox
            // 
            this.subjectTbox.Location = new System.Drawing.Point(183, 56);
            this.subjectTbox.Name = "subjectTbox";
            this.subjectTbox.Size = new System.Drawing.Size(368, 38);
            this.subjectTbox.TabIndex = 3;
            // 
            // mesageGbox
            // 
            this.mesageGbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mesageGbox.BackColor = System.Drawing.Color.Transparent;
            this.mesageGbox.Controls.Add(this.messageTbox);
            this.mesageGbox.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesageGbox.ForeColor = System.Drawing.Color.Yellow;
            this.mesageGbox.Location = new System.Drawing.Point(612, 68);
            this.mesageGbox.Name = "mesageGbox";
            this.mesageGbox.Size = new System.Drawing.Size(517, 521);
            this.mesageGbox.TabIndex = 4;
            this.mesageGbox.TabStop = false;
            this.mesageGbox.Text = "Message";
            // 
            // messageTbox
            // 
            this.messageTbox.Location = new System.Drawing.Point(7, 38);
            this.messageTbox.Multiline = true;
            this.messageTbox.Name = "messageTbox";
            this.messageTbox.Size = new System.Drawing.Size(504, 477);
            this.messageTbox.TabIndex = 0;
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(1029, 589);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(100, 40);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(12, 584);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 40);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // sslCbox
            // 
            this.sslCbox.AutoSize = true;
            this.sslCbox.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sslCbox.Location = new System.Drawing.Point(249, 138);
            this.sslCbox.Name = "sslCbox";
            this.sslCbox.Size = new System.Drawing.Size(88, 43);
            this.sslCbox.TabIndex = 8;
            this.sslCbox.Text = "SSL";
            this.sslCbox.UseVisualStyleBackColor = true;
            // 
            // ContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LogUp.Properties.Resources.contuctus;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 636);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.mesageGbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.senderGbox);
            this.Controls.Add(this.contactusLbl);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "ContactUs";
            this.Text = "Contact us";
            this.senderGbox.ResumeLayout(false);
            this.senderGbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.mesageGbox.ResumeLayout(false);
            this.mesageGbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contactusLbl;
        private System.Windows.Forms.GroupBox senderGbox;
        private System.Windows.Forms.TextBox sendpasswordTbox;
        private System.Windows.Forms.Label sendpasswordLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label subjectLbl;
        private System.Windows.Forms.TextBox subjectTbox;
        private System.Windows.Forms.GroupBox mesageGbox;
        private System.Windows.Forms.TextBox messageTbox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label sendmailLbl;
        private System.Windows.Forms.TextBox sendmailTbox;
        private System.Windows.Forms.CheckBox sslCbox;
    }
}