
namespace StartMenu
{
    partial class shutdownmanager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shutdownmanager));
            this.timeGbox = new System.Windows.Forms.GroupBox();
            this.timerLbl = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.settimeGbox = new System.Windows.Forms.GroupBox();
            this.setsecondTbox = new System.Windows.Forms.TextBox();
            this.setminuteTbox = new System.Windows.Forms.TextBox();
            this.sethourTbox = new System.Windows.Forms.TextBox();
            this.setsecondLbl = new System.Windows.Forms.Label();
            this.setminuteLbl = new System.Windows.Forms.Label();
            this.sethourLbl = new System.Windows.Forms.Label();
            this.processGbox = new System.Windows.Forms.GroupBox();
            this.extBtn = new System.Windows.Forms.Button();
            this.powersaveRbtn = new System.Windows.Forms.RadioButton();
            this.restartRbtn = new System.Windows.Forms.RadioButton();
            this.shutdownRbtn = new System.Windows.Forms.RadioButton();
            this.shutdowntimer = new System.Windows.Forms.Timer(this.components);
            this.timeGbox.SuspendLayout();
            this.settimeGbox.SuspendLayout();
            this.processGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeGbox
            // 
            this.timeGbox.Controls.Add(this.timerLbl);
            this.timeGbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeGbox.Location = new System.Drawing.Point(13, 13);
            this.timeGbox.Name = "timeGbox";
            this.timeGbox.Size = new System.Drawing.Size(300, 210);
            this.timeGbox.TabIndex = 0;
            this.timeGbox.TabStop = false;
            this.timeGbox.Text = "Timer";
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLbl.Location = new System.Drawing.Point(40, 87);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(173, 54);
            this.timerLbl.TabIndex = 0;
            this.timerLbl.Text = "00:00:00";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startBtn.Location = new System.Drawing.Point(13, 230);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(117, 106);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.ForeColor = System.Drawing.Color.Red;
            this.stopBtn.Location = new System.Drawing.Point(196, 230);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(117, 106);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // settimeGbox
            // 
            this.settimeGbox.Controls.Add(this.setsecondTbox);
            this.settimeGbox.Controls.Add(this.setminuteTbox);
            this.settimeGbox.Controls.Add(this.sethourTbox);
            this.settimeGbox.Controls.Add(this.setsecondLbl);
            this.settimeGbox.Controls.Add(this.setminuteLbl);
            this.settimeGbox.Controls.Add(this.sethourLbl);
            this.settimeGbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settimeGbox.Location = new System.Drawing.Point(319, 13);
            this.settimeGbox.Name = "settimeGbox";
            this.settimeGbox.Size = new System.Drawing.Size(300, 323);
            this.settimeGbox.TabIndex = 3;
            this.settimeGbox.TabStop = false;
            this.settimeGbox.Text = "Set Timer";
            // 
            // setsecondTbox
            // 
            this.setsecondTbox.Location = new System.Drawing.Point(197, 238);
            this.setsecondTbox.Name = "setsecondTbox";
            this.setsecondTbox.Size = new System.Drawing.Size(97, 34);
            this.setsecondTbox.TabIndex = 5;
            // 
            // setminuteTbox
            // 
            this.setminuteTbox.Location = new System.Drawing.Point(197, 154);
            this.setminuteTbox.Name = "setminuteTbox";
            this.setminuteTbox.Size = new System.Drawing.Size(97, 34);
            this.setminuteTbox.TabIndex = 4;
            // 
            // sethourTbox
            // 
            this.sethourTbox.Location = new System.Drawing.Point(197, 76);
            this.sethourTbox.Name = "sethourTbox";
            this.sethourTbox.Size = new System.Drawing.Size(97, 34);
            this.sethourTbox.TabIndex = 3;
            // 
            // setsecondLbl
            // 
            this.setsecondLbl.AutoSize = true;
            this.setsecondLbl.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setsecondLbl.Location = new System.Drawing.Point(6, 217);
            this.setsecondLbl.Name = "setsecondLbl";
            this.setsecondLbl.Size = new System.Drawing.Size(173, 59);
            this.setsecondLbl.TabIndex = 2;
            this.setsecondLbl.Text = "Second:";
            // 
            // setminuteLbl
            // 
            this.setminuteLbl.AutoSize = true;
            this.setminuteLbl.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setminuteLbl.Location = new System.Drawing.Point(6, 133);
            this.setminuteLbl.Name = "setminuteLbl";
            this.setminuteLbl.Size = new System.Drawing.Size(168, 59);
            this.setminuteLbl.TabIndex = 1;
            this.setminuteLbl.Text = "Minute:";
            // 
            // sethourLbl
            // 
            this.sethourLbl.AutoSize = true;
            this.sethourLbl.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sethourLbl.Location = new System.Drawing.Point(6, 55);
            this.sethourLbl.Name = "sethourLbl";
            this.sethourLbl.Size = new System.Drawing.Size(129, 59);
            this.sethourLbl.TabIndex = 0;
            this.sethourLbl.Text = "Hour:";
            // 
            // processGbox
            // 
            this.processGbox.Controls.Add(this.extBtn);
            this.processGbox.Controls.Add(this.powersaveRbtn);
            this.processGbox.Controls.Add(this.restartRbtn);
            this.processGbox.Controls.Add(this.shutdownRbtn);
            this.processGbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processGbox.Location = new System.Drawing.Point(626, 13);
            this.processGbox.Name = "processGbox";
            this.processGbox.Size = new System.Drawing.Size(300, 323);
            this.processGbox.TabIndex = 4;
            this.processGbox.TabStop = false;
            this.processGbox.Text = "Process";
            // 
            // extBtn
            // 
            this.extBtn.ForeColor = System.Drawing.Color.Red;
            this.extBtn.Location = new System.Drawing.Point(199, 274);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(95, 43);
            this.extBtn.TabIndex = 3;
            this.extBtn.Text = "Back";
            this.extBtn.UseVisualStyleBackColor = true;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // powersaveRbtn
            // 
            this.powersaveRbtn.AutoSize = true;
            this.powersaveRbtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powersaveRbtn.Location = new System.Drawing.Point(7, 181);
            this.powersaveRbtn.Name = "powersaveRbtn";
            this.powersaveRbtn.Size = new System.Drawing.Size(189, 42);
            this.powersaveRbtn.TabIndex = 2;
            this.powersaveRbtn.TabStop = true;
            this.powersaveRbtn.Text = "Power Saver";
            this.powersaveRbtn.UseVisualStyleBackColor = true;
            // 
            // restartRbtn
            // 
            this.restartRbtn.AutoSize = true;
            this.restartRbtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartRbtn.Location = new System.Drawing.Point(6, 133);
            this.restartRbtn.Name = "restartRbtn";
            this.restartRbtn.Size = new System.Drawing.Size(123, 42);
            this.restartRbtn.TabIndex = 1;
            this.restartRbtn.TabStop = true;
            this.restartRbtn.Text = "Restart";
            this.restartRbtn.UseVisualStyleBackColor = true;
            // 
            // shutdownRbtn
            // 
            this.shutdownRbtn.AutoSize = true;
            this.shutdownRbtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownRbtn.Location = new System.Drawing.Point(6, 85);
            this.shutdownRbtn.Name = "shutdownRbtn";
            this.shutdownRbtn.Size = new System.Drawing.Size(162, 42);
            this.shutdownRbtn.TabIndex = 0;
            this.shutdownRbtn.TabStop = true;
            this.shutdownRbtn.Text = "Shutdown";
            this.shutdownRbtn.UseVisualStyleBackColor = true;
            // 
            // shutdowntimer
            // 
            this.shutdowntimer.Interval = 1000;
            this.shutdowntimer.Tick += new System.EventHandler(this.shutdowntimer_Tick);
            // 
            // shutdownmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 361);
            this.Controls.Add(this.processGbox);
            this.Controls.Add(this.settimeGbox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.timeGbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "shutdownmanager";
            this.Text = "Shutdown Manager";
            this.timeGbox.ResumeLayout(false);
            this.timeGbox.PerformLayout();
            this.settimeGbox.ResumeLayout(false);
            this.settimeGbox.PerformLayout();
            this.processGbox.ResumeLayout(false);
            this.processGbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox timeGbox;
        private System.Windows.Forms.Label timerLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.GroupBox settimeGbox;
        private System.Windows.Forms.TextBox setsecondTbox;
        private System.Windows.Forms.TextBox setminuteTbox;
        private System.Windows.Forms.TextBox sethourTbox;
        private System.Windows.Forms.Label setsecondLbl;
        private System.Windows.Forms.Label setminuteLbl;
        private System.Windows.Forms.Label sethourLbl;
        private System.Windows.Forms.GroupBox processGbox;
        private System.Windows.Forms.Timer shutdowntimer;
        private System.Windows.Forms.RadioButton powersaveRbtn;
        private System.Windows.Forms.RadioButton restartRbtn;
        private System.Windows.Forms.RadioButton shutdownRbtn;
        private System.Windows.Forms.Button extBtn;
    }
}