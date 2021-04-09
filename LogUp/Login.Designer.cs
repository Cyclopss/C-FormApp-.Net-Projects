
namespace LogUp
{
    partial class Login
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
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.usernmLbl = new System.Windows.Forms.Label();
            this.usernameTbox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.newaccountBtn = new System.Windows.Forms.Button();
            this.contactusBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.Color.Purple;
            this.welcomeLbl.Location = new System.Drawing.Point(362, 44);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(342, 83);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome";
            this.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomeLbl.Click += new System.EventHandler(this.welcomeLbl_Click);
            // 
            // usernmLbl
            // 
            this.usernmLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernmLbl.AutoSize = true;
            this.usernmLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernmLbl.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernmLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.usernmLbl.Location = new System.Drawing.Point(370, 190);
            this.usernmLbl.Name = "usernmLbl";
            this.usernmLbl.Size = new System.Drawing.Size(150, 36);
            this.usernmLbl.TabIndex = 1;
            this.usernmLbl.Text = "Username";
            this.usernmLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernameTbox
            // 
            this.usernameTbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTbox.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTbox.Location = new System.Drawing.Point(376, 238);
            this.usernameTbox.Multiline = true;
            this.usernameTbox.Name = "usernameTbox";
            this.usernameTbox.Size = new System.Drawing.Size(328, 40);
            this.usernameTbox.TabIndex = 2;
            this.usernameTbox.Text = "Username ";
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.passwordLbl.Location = new System.Drawing.Point(370, 290);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(142, 36);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password";
            // 
            // passwordTbox
            // 
            this.passwordTbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTbox.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTbox.Location = new System.Drawing.Point(376, 329);
            this.passwordTbox.Multiline = true;
            this.passwordTbox.Name = "passwordTbox";
            this.passwordTbox.Size = new System.Drawing.Size(328, 40);
            this.passwordTbox.TabIndex = 4;
            this.passwordTbox.Text = "Password";
            this.passwordTbox.TextChanged += new System.EventHandler(this.passwordTbox_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(449, 437);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(170, 60);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // newaccountBtn
            // 
            this.newaccountBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newaccountBtn.BackColor = System.Drawing.Color.Teal;
            this.newaccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newaccountBtn.FlatAppearance.BorderSize = 0;
            this.newaccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newaccountBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newaccountBtn.ForeColor = System.Drawing.Color.White;
            this.newaccountBtn.Location = new System.Drawing.Point(350, 556);
            this.newaccountBtn.Name = "newaccountBtn";
            this.newaccountBtn.Size = new System.Drawing.Size(170, 53);
            this.newaccountBtn.TabIndex = 6;
            this.newaccountBtn.Text = "New account";
            this.newaccountBtn.UseVisualStyleBackColor = false;
            this.newaccountBtn.Click += new System.EventHandler(this.newaccountBtn_Click);
            // 
            // contactusBtn
            // 
            this.contactusBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contactusBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contactusBtn.BackColor = System.Drawing.Color.Teal;
            this.contactusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactusBtn.FlatAppearance.BorderSize = 0;
            this.contactusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactusBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactusBtn.ForeColor = System.Drawing.Color.White;
            this.contactusBtn.Location = new System.Drawing.Point(534, 556);
            this.contactusBtn.Name = "contactusBtn";
            this.contactusBtn.Size = new System.Drawing.Size(170, 53);
            this.contactusBtn.TabIndex = 7;
            this.contactusBtn.Text = "Contact us";
            this.contactusBtn.UseCompatibleTextRendering = true;
            this.contactusBtn.UseVisualStyleBackColor = false;
            this.contactusBtn.Click += new System.EventHandler(this.contactusBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorLbl.AutoSize = true;
            this.errorLbl.BackColor = System.Drawing.Color.Red;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.White;
            this.errorLbl.Location = new System.Drawing.Point(353, 393);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(382, 31);
            this.errorLbl.TabIndex = 8;
            this.errorLbl.Text = "Incorrect password or username";
            this.errorLbl.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = global::LogUp.Properties.Resources.login1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 723);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.contactusBtn);
            this.Controls.Add(this.newaccountBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTbox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameTbox);
            this.Controls.Add(this.usernmLbl);
            this.Controls.Add(this.welcomeLbl);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label usernmLbl;
        private System.Windows.Forms.TextBox usernameTbox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTbox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button newaccountBtn;
        private System.Windows.Forms.Button contactusBtn;
        private System.Windows.Forms.Label errorLbl;
    }
}

