
namespace StartMenu
{
    partial class tictactoe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tictactoe));
            this.gamePnl = new System.Windows.Forms.Panel();
            this.tictactoeLbl = new System.Windows.Forms.Label();
            this.gamemenuPnl = new System.Windows.Forms.Panel();
            this.gameresultPnl = new System.Windows.Forms.Panel();
            this.gamestartPnl = new System.Windows.Forms.Panel();
            this.newgameBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.gamescorePnl = new System.Windows.Forms.Panel();
            this.ploscLbl = new System.Windows.Forms.Label();
            this.plxscLbl = new System.Windows.Forms.Label();
            this.ploLbl = new System.Windows.Forms.Label();
            this.plxLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gameplayPnl = new System.Windows.Forms.Panel();
            this.tic9Btn = new System.Windows.Forms.Button();
            this.tic8Btn = new System.Windows.Forms.Button();
            this.tic7Btn = new System.Windows.Forms.Button();
            this.tic6Btn = new System.Windows.Forms.Button();
            this.tic5Btn = new System.Windows.Forms.Button();
            this.tic4Btn = new System.Windows.Forms.Button();
            this.tic3Btn = new System.Windows.Forms.Button();
            this.tic2Btn = new System.Windows.Forms.Button();
            this.tic1Btn = new System.Windows.Forms.Button();
            this.gamePnl.SuspendLayout();
            this.gamemenuPnl.SuspendLayout();
            this.gameresultPnl.SuspendLayout();
            this.gamestartPnl.SuspendLayout();
            this.gamescorePnl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gameplayPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePnl
            // 
            this.gamePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gamePnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamePnl.Controls.Add(this.tictactoeLbl);
            this.gamePnl.Location = new System.Drawing.Point(12, 13);
            this.gamePnl.Name = "gamePnl";
            this.gamePnl.Size = new System.Drawing.Size(1344, 111);
            this.gamePnl.TabIndex = 0;
            // 
            // tictactoeLbl
            // 
            this.tictactoeLbl.AutoSize = true;
            this.tictactoeLbl.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tictactoeLbl.ForeColor = System.Drawing.Color.Red;
            this.tictactoeLbl.Location = new System.Drawing.Point(452, 0);
            this.tictactoeLbl.Name = "tictactoeLbl";
            this.tictactoeLbl.Size = new System.Drawing.Size(421, 106);
            this.tictactoeLbl.TabIndex = 0;
            this.tictactoeLbl.Text = "Tic Tac Toe";
            // 
            // gamemenuPnl
            // 
            this.gamemenuPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamemenuPnl.Controls.Add(this.gameresultPnl);
            this.gamemenuPnl.Controls.Add(this.panel3);
            this.gamemenuPnl.Location = new System.Drawing.Point(12, 130);
            this.gamemenuPnl.Name = "gamemenuPnl";
            this.gamemenuPnl.Size = new System.Drawing.Size(1344, 599);
            this.gamemenuPnl.TabIndex = 1;
            // 
            // gameresultPnl
            // 
            this.gameresultPnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameresultPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameresultPnl.Controls.Add(this.gamestartPnl);
            this.gameresultPnl.Controls.Add(this.gamescorePnl);
            this.gameresultPnl.Location = new System.Drawing.Point(716, 3);
            this.gameresultPnl.Name = "gameresultPnl";
            this.gameresultPnl.Size = new System.Drawing.Size(621, 589);
            this.gameresultPnl.TabIndex = 1;
            // 
            // gamestartPnl
            // 
            this.gamestartPnl.BackColor = System.Drawing.Color.Cyan;
            this.gamestartPnl.Controls.Add(this.newgameBtn);
            this.gamestartPnl.Controls.Add(this.exitBtn);
            this.gamestartPnl.Controls.Add(this.restartBtn);
            this.gamestartPnl.Location = new System.Drawing.Point(3, 290);
            this.gamestartPnl.Name = "gamestartPnl";
            this.gamestartPnl.Size = new System.Drawing.Size(611, 292);
            this.gamestartPnl.TabIndex = 1;
            // 
            // newgameBtn
            // 
            this.newgameBtn.BackColor = System.Drawing.Color.Gray;
            this.newgameBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.newgameBtn.FlatAppearance.BorderSize = 0;
            this.newgameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newgameBtn.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgameBtn.ForeColor = System.Drawing.Color.White;
            this.newgameBtn.Location = new System.Drawing.Point(89, 3);
            this.newgameBtn.Name = "newgameBtn";
            this.newgameBtn.Size = new System.Drawing.Size(450, 166);
            this.newgameBtn.TabIndex = 2;
            this.newgameBtn.Text = "New Game";
            this.newgameBtn.UseVisualStyleBackColor = false;
            this.newgameBtn.Click += new System.EventHandler(this.newgameBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(329, 175);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(279, 112);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.restartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.restartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartBtn.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.ForeColor = System.Drawing.Color.White;
            this.restartBtn.Location = new System.Drawing.Point(3, 175);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(279, 114);
            this.restartBtn.TabIndex = 0;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // gamescorePnl
            // 
            this.gamescorePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gamescorePnl.Controls.Add(this.ploscLbl);
            this.gamescorePnl.Controls.Add(this.plxscLbl);
            this.gamescorePnl.Controls.Add(this.ploLbl);
            this.gamescorePnl.Controls.Add(this.plxLbl);
            this.gamescorePnl.Location = new System.Drawing.Point(3, 3);
            this.gamescorePnl.Name = "gamescorePnl";
            this.gamescorePnl.Size = new System.Drawing.Size(611, 281);
            this.gamescorePnl.TabIndex = 0;
            // 
            // ploscLbl
            // 
            this.ploscLbl.AutoSize = true;
            this.ploscLbl.BackColor = System.Drawing.Color.White;
            this.ploscLbl.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ploscLbl.Location = new System.Drawing.Point(367, 149);
            this.ploscLbl.Name = "ploscLbl";
            this.ploscLbl.Size = new System.Drawing.Size(88, 106);
            this.ploscLbl.TabIndex = 3;
            this.ploscLbl.Text = "0";
            this.ploscLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plxscLbl
            // 
            this.plxscLbl.AutoSize = true;
            this.plxscLbl.BackColor = System.Drawing.Color.White;
            this.plxscLbl.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plxscLbl.Location = new System.Drawing.Point(367, 10);
            this.plxscLbl.Name = "plxscLbl";
            this.plxscLbl.Size = new System.Drawing.Size(88, 106);
            this.plxscLbl.TabIndex = 2;
            this.plxscLbl.Text = "0";
            this.plxscLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ploLbl
            // 
            this.ploLbl.AutoSize = true;
            this.ploLbl.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ploLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ploLbl.Location = new System.Drawing.Point(3, 149);
            this.ploLbl.Name = "ploLbl";
            this.ploLbl.Size = new System.Drawing.Size(358, 106);
            this.ploLbl.TabIndex = 1;
            this.ploLbl.Text = "Player O:";
            // 
            // plxLbl
            // 
            this.plxLbl.AutoSize = true;
            this.plxLbl.BackColor = System.Drawing.Color.Transparent;
            this.plxLbl.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plxLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.plxLbl.Location = new System.Drawing.Point(3, 10);
            this.plxLbl.Name = "plxLbl";
            this.plxLbl.Size = new System.Drawing.Size(345, 106);
            this.plxLbl.TabIndex = 0;
            this.plxLbl.Text = "Player X:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.gameplayPnl);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 589);
            this.panel3.TabIndex = 1;
            // 
            // gameplayPnl
            // 
            this.gameplayPnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameplayPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameplayPnl.Controls.Add(this.tic9Btn);
            this.gameplayPnl.Controls.Add(this.tic8Btn);
            this.gameplayPnl.Controls.Add(this.tic7Btn);
            this.gameplayPnl.Controls.Add(this.tic6Btn);
            this.gameplayPnl.Controls.Add(this.tic5Btn);
            this.gameplayPnl.Controls.Add(this.tic4Btn);
            this.gameplayPnl.Controls.Add(this.tic3Btn);
            this.gameplayPnl.Controls.Add(this.tic2Btn);
            this.gameplayPnl.Controls.Add(this.tic1Btn);
            this.gameplayPnl.Location = new System.Drawing.Point(-2, -2);
            this.gameplayPnl.Name = "gameplayPnl";
            this.gameplayPnl.Size = new System.Drawing.Size(707, 589);
            this.gameplayPnl.TabIndex = 2;
            // 
            // tic9Btn
            // 
            this.tic9Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic9Btn.Location = new System.Drawing.Point(480, 402);
            this.tic9Btn.Name = "tic9Btn";
            this.tic9Btn.Size = new System.Drawing.Size(220, 158);
            this.tic9Btn.TabIndex = 8;
            this.tic9Btn.UseVisualStyleBackColor = true;
            this.tic9Btn.Click += new System.EventHandler(this.tic9Btn_Click);
            // 
            // tic8Btn
            // 
            this.tic8Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic8Btn.Location = new System.Drawing.Point(244, 402);
            this.tic8Btn.Name = "tic8Btn";
            this.tic8Btn.Size = new System.Drawing.Size(220, 158);
            this.tic8Btn.TabIndex = 7;
            this.tic8Btn.UseVisualStyleBackColor = true;
            this.tic8Btn.Click += new System.EventHandler(this.tic8Btn_Click);
            // 
            // tic7Btn
            // 
            this.tic7Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic7Btn.Location = new System.Drawing.Point(3, 402);
            this.tic7Btn.Name = "tic7Btn";
            this.tic7Btn.Size = new System.Drawing.Size(220, 158);
            this.tic7Btn.TabIndex = 6;
            this.tic7Btn.UseVisualStyleBackColor = true;
            this.tic7Btn.Click += new System.EventHandler(this.tic7Btn_Click);
            // 
            // tic6Btn
            // 
            this.tic6Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic6Btn.Location = new System.Drawing.Point(480, 218);
            this.tic6Btn.Name = "tic6Btn";
            this.tic6Btn.Size = new System.Drawing.Size(220, 158);
            this.tic6Btn.TabIndex = 5;
            this.tic6Btn.UseVisualStyleBackColor = true;
            this.tic6Btn.Click += new System.EventHandler(this.tic6Btn_Click);
            // 
            // tic5Btn
            // 
            this.tic5Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic5Btn.Location = new System.Drawing.Point(244, 218);
            this.tic5Btn.Name = "tic5Btn";
            this.tic5Btn.Size = new System.Drawing.Size(220, 158);
            this.tic5Btn.TabIndex = 4;
            this.tic5Btn.UseVisualStyleBackColor = true;
            this.tic5Btn.Click += new System.EventHandler(this.tic5Btn_Click);
            // 
            // tic4Btn
            // 
            this.tic4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic4Btn.Location = new System.Drawing.Point(3, 218);
            this.tic4Btn.Name = "tic4Btn";
            this.tic4Btn.Size = new System.Drawing.Size(220, 158);
            this.tic4Btn.TabIndex = 3;
            this.tic4Btn.UseVisualStyleBackColor = true;
            this.tic4Btn.Click += new System.EventHandler(this.tic4Btn_Click);
            // 
            // tic3Btn
            // 
            this.tic3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic3Btn.Location = new System.Drawing.Point(480, 23);
            this.tic3Btn.Name = "tic3Btn";
            this.tic3Btn.Size = new System.Drawing.Size(220, 158);
            this.tic3Btn.TabIndex = 2;
            this.tic3Btn.UseVisualStyleBackColor = true;
            this.tic3Btn.Click += new System.EventHandler(this.tic3Btn_Click);
            // 
            // tic2Btn
            // 
            this.tic2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic2Btn.Location = new System.Drawing.Point(244, 23);
            this.tic2Btn.Name = "tic2Btn";
            this.tic2Btn.Size = new System.Drawing.Size(220, 158);
            this.tic2Btn.TabIndex = 1;
            this.tic2Btn.UseVisualStyleBackColor = true;
            this.tic2Btn.Click += new System.EventHandler(this.tic2Btn_Click);
            // 
            // tic1Btn
            // 
            this.tic1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tic1Btn.Location = new System.Drawing.Point(3, 23);
            this.tic1Btn.Name = "tic1Btn";
            this.tic1Btn.Size = new System.Drawing.Size(220, 158);
            this.tic1Btn.TabIndex = 0;
            this.tic1Btn.UseVisualStyleBackColor = true;
            this.tic1Btn.Click += new System.EventHandler(this.tic1Btn_Click);
            // 
            // tictactoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.Controls.Add(this.gamemenuPnl);
            this.Controls.Add(this.gamePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tictactoe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.tictactoe_Load);
            this.gamePnl.ResumeLayout(false);
            this.gamePnl.PerformLayout();
            this.gamemenuPnl.ResumeLayout(false);
            this.gameresultPnl.ResumeLayout(false);
            this.gamestartPnl.ResumeLayout(false);
            this.gamescorePnl.ResumeLayout(false);
            this.gamescorePnl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gameplayPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePnl;
        private System.Windows.Forms.Label tictactoeLbl;
        private System.Windows.Forms.Panel gamemenuPnl;
        private System.Windows.Forms.Panel gameresultPnl;
        private System.Windows.Forms.Panel gamestartPnl;
        private System.Windows.Forms.Button newgameBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Panel gamescorePnl;
        private System.Windows.Forms.Label ploscLbl;
        private System.Windows.Forms.Label plxscLbl;
        private System.Windows.Forms.Label ploLbl;
        private System.Windows.Forms.Label plxLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel gameplayPnl;
        private System.Windows.Forms.Button tic9Btn;
        private System.Windows.Forms.Button tic8Btn;
        private System.Windows.Forms.Button tic7Btn;
        private System.Windows.Forms.Button tic6Btn;
        private System.Windows.Forms.Button tic5Btn;
        private System.Windows.Forms.Button tic4Btn;
        private System.Windows.Forms.Button tic3Btn;
        private System.Windows.Forms.Button tic2Btn;
        private System.Windows.Forms.Button tic1Btn;
    }
}