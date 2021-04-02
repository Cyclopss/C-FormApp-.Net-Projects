
namespace ClockAlarm
{
    partial class Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.currentTimeLbl = new System.Windows.Forms.Label();
            this.cAlrmLbl = new System.Windows.Forms.Label();
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.hAlrmLbl = new System.Windows.Forms.Label();
            this.mAlrmLbl = new System.Windows.Forms.Label();
            this.sAlrmLbl = new System.Windows.Forms.Label();
            this.hAlrmTbox = new System.Windows.Forms.TextBox();
            this.mAlarmTbox = new System.Windows.Forms.TextBox();
            this.sAlrmTbox = new System.Windows.Forms.TextBox();
            this.bckBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentTimeLbl
            // 
            this.currentTimeLbl.AutoSize = true;
            this.currentTimeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.currentTimeLbl.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLbl.ForeColor = System.Drawing.Color.White;
            this.currentTimeLbl.Location = new System.Drawing.Point(13, 13);
            this.currentTimeLbl.Name = "currentTimeLbl";
            this.currentTimeLbl.Size = new System.Drawing.Size(258, 45);
            this.currentTimeLbl.TabIndex = 0;
            this.currentTimeLbl.Text = "Current Time:";
            // 
            // cAlrmLbl
            // 
            this.cAlrmLbl.AutoSize = true;
            this.cAlrmLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.cAlrmLbl.Font = new System.Drawing.Font("DS-Digital", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAlrmLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cAlrmLbl.Location = new System.Drawing.Point(277, 15);
            this.cAlrmLbl.Name = "cAlrmLbl";
            this.cAlrmLbl.Size = new System.Drawing.Size(202, 42);
            this.cAlrmLbl.TabIndex = 1;
            this.cAlrmLbl.Text = "HH : mm : ss";
            // 
            // alarmTimer
            // 
            this.alarmTimer.Interval = 1000;
            this.alarmTimer.Tick += new System.EventHandler(this.alarmTimer_Tick);
            // 
            // hAlrmLbl
            // 
            this.hAlrmLbl.AutoSize = true;
            this.hAlrmLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.hAlrmLbl.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hAlrmLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hAlrmLbl.Location = new System.Drawing.Point(13, 116);
            this.hAlrmLbl.Name = "hAlrmLbl";
            this.hAlrmLbl.Size = new System.Drawing.Size(117, 45);
            this.hAlrmLbl.TabIndex = 2;
            this.hAlrmLbl.Text = "Hour:";
            // 
            // mAlrmLbl
            // 
            this.mAlrmLbl.AutoSize = true;
            this.mAlrmLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.mAlrmLbl.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAlrmLbl.ForeColor = System.Drawing.Color.Aqua;
            this.mAlrmLbl.Location = new System.Drawing.Point(13, 205);
            this.mAlrmLbl.Name = "mAlrmLbl";
            this.mAlrmLbl.Size = new System.Drawing.Size(150, 45);
            this.mAlrmLbl.TabIndex = 3;
            this.mAlrmLbl.Text = "Minute:";
            // 
            // sAlrmLbl
            // 
            this.sAlrmLbl.AutoSize = true;
            this.sAlrmLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.sAlrmLbl.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAlrmLbl.ForeColor = System.Drawing.Color.Aqua;
            this.sAlrmLbl.Location = new System.Drawing.Point(13, 297);
            this.sAlrmLbl.Name = "sAlrmLbl";
            this.sAlrmLbl.Size = new System.Drawing.Size(166, 45);
            this.sAlrmLbl.TabIndex = 4;
            this.sAlrmLbl.Text = "Second:";
            // 
            // hAlrmTbox
            // 
            this.hAlrmTbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.hAlrmTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hAlrmTbox.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hAlrmTbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hAlrmTbox.Location = new System.Drawing.Point(253, 119);
            this.hAlrmTbox.Name = "hAlrmTbox";
            this.hAlrmTbox.Size = new System.Drawing.Size(100, 40);
            this.hAlrmTbox.TabIndex = 5;
            this.hAlrmTbox.Text = "00";
            this.hAlrmTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hAlrmTbox.TextChanged += new System.EventHandler(this.hAlrmTbox_TextChanged);
            // 
            // mAlarmTbox
            // 
            this.mAlarmTbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.mAlarmTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mAlarmTbox.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAlarmTbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mAlarmTbox.Location = new System.Drawing.Point(253, 208);
            this.mAlarmTbox.Name = "mAlarmTbox";
            this.mAlarmTbox.Size = new System.Drawing.Size(100, 40);
            this.mAlarmTbox.TabIndex = 6;
            this.mAlarmTbox.Text = "00";
            this.mAlarmTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mAlarmTbox.TextChanged += new System.EventHandler(this.mAlarmTbox_TextChanged);
            // 
            // sAlrmTbox
            // 
            this.sAlrmTbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.sAlrmTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sAlrmTbox.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAlrmTbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sAlrmTbox.Location = new System.Drawing.Point(253, 300);
            this.sAlrmTbox.Name = "sAlrmTbox";
            this.sAlrmTbox.Size = new System.Drawing.Size(100, 40);
            this.sAlrmTbox.TabIndex = 7;
            this.sAlrmTbox.Text = "00";
            this.sAlrmTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sAlrmTbox.TextChanged += new System.EventHandler(this.sAlrmTbox_TextChanged);
            // 
            // bckBtn
            // 
            this.bckBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bckBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bckBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckBtn.ForeColor = System.Drawing.Color.White;
            this.bckBtn.Location = new System.Drawing.Point(663, 520);
            this.bckBtn.Name = "bckBtn";
            this.bckBtn.Size = new System.Drawing.Size(134, 46);
            this.bckBtn.TabIndex = 8;
            this.bckBtn.Text = "▶ Back";
            this.bckBtn.UseVisualStyleBackColor = false;
            this.bckBtn.Click += new System.EventHandler(this.bckBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startBtn.Location = new System.Drawing.Point(21, 363);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(109, 44);
            this.startBtn.TabIndex = 9;
            this.startBtn.Text = "Start";
            this.startBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Red;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.ForeColor = System.Drawing.Color.White;
            this.stopBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stopBtn.Location = new System.Drawing.Point(253, 363);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(109, 44);
            this.stopBtn.TabIndex = 10;
            this.stopBtn.Text = "Stop";
            this.stopBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(16)))), ((int)(((byte)(26)))));
            this.errorLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(12, 512);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(557, 54);
            this.errorLbl.TabIndex = 11;
            this.errorLbl.Text = "You must use single numbers suah as \"2\", with \"0\"\r\nExample 02 : 02: 02\r\n";
            this.errorLbl.Visible = false;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClockAlarm.Properties.Resources.alarmthemeps;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 578);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.bckBtn);
            this.Controls.Add(this.sAlrmTbox);
            this.Controls.Add(this.mAlarmTbox);
            this.Controls.Add(this.hAlrmTbox);
            this.Controls.Add(this.sAlrmLbl);
            this.Controls.Add(this.mAlrmLbl);
            this.Controls.Add(this.hAlrmLbl);
            this.Controls.Add(this.cAlrmLbl);
            this.Controls.Add(this.currentTimeLbl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTimeLbl;
        private System.Windows.Forms.Label cAlrmLbl;
        private System.Windows.Forms.Timer alarmTimer;
        private System.Windows.Forms.Label hAlrmLbl;
        private System.Windows.Forms.Label mAlrmLbl;
        private System.Windows.Forms.Label sAlrmLbl;
        private System.Windows.Forms.TextBox hAlrmTbox;
        private System.Windows.Forms.TextBox mAlarmTbox;
        private System.Windows.Forms.TextBox sAlrmTbox;
        private System.Windows.Forms.Button bckBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label errorLbl;
    }
}