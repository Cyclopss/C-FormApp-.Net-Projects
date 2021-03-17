
namespace Calculator.Main
{
    partial class CalculatorMain
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
            this.resultTbox = new System.Windows.Forms.TextBox();
            this.dxBtn = new System.Windows.Forms.Button();
            this.fcBtn = new System.Windows.Forms.Button();
            this.modeBtn = new System.Windows.Forms.Button();
            this.lcBtn = new System.Windows.Forms.Button();
            this.powBtn = new System.Windows.Forms.Button();
            this.sqrtBtn = new System.Windows.Forms.Button();
            this.devideBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.processLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultTbox
            // 
            this.resultTbox.Enabled = false;
            this.resultTbox.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTbox.Location = new System.Drawing.Point(12, 12);
            this.resultTbox.Multiline = true;
            this.resultTbox.Name = "resultTbox";
            this.resultTbox.Size = new System.Drawing.Size(258, 94);
            this.resultTbox.TabIndex = 0;
            this.resultTbox.Text = "0";
            this.resultTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dxBtn
            // 
            this.dxBtn.BackColor = System.Drawing.SystemColors.Control;
            this.dxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dxBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dxBtn.ForeColor = System.Drawing.Color.Navy;
            this.dxBtn.Location = new System.Drawing.Point(41, 163);
            this.dxBtn.Name = "dxBtn";
            this.dxBtn.Size = new System.Drawing.Size(45, 45);
            this.dxBtn.TabIndex = 2;
            this.dxBtn.Text = "1/x";
            this.dxBtn.UseVisualStyleBackColor = false;
            this.dxBtn.Click += new System.EventHandler(this.dxBtn_Click);
            // 
            // fcBtn
            // 
            this.fcBtn.BackColor = System.Drawing.SystemColors.Control;
            this.fcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fcBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fcBtn.ForeColor = System.Drawing.Color.Navy;
            this.fcBtn.Location = new System.Drawing.Point(41, 112);
            this.fcBtn.Name = "fcBtn";
            this.fcBtn.Size = new System.Drawing.Size(45, 45);
            this.fcBtn.TabIndex = 3;
            this.fcBtn.Text = "C";
            this.fcBtn.UseVisualStyleBackColor = false;
            this.fcBtn.Click += new System.EventHandler(this.fcBtn_Click);
            // 
            // modeBtn
            // 
            this.modeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.modeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modeBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeBtn.ForeColor = System.Drawing.Color.Navy;
            this.modeBtn.Location = new System.Drawing.Point(92, 112);
            this.modeBtn.Name = "modeBtn";
            this.modeBtn.Size = new System.Drawing.Size(45, 45);
            this.modeBtn.TabIndex = 4;
            this.modeBtn.Text = "%";
            this.modeBtn.UseVisualStyleBackColor = false;
            this.modeBtn.Click += new System.EventHandler(this.modeBtn_Click);
            // 
            // lcBtn
            // 
            this.lcBtn.BackColor = System.Drawing.SystemColors.Control;
            this.lcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lcBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcBtn.ForeColor = System.Drawing.Color.Navy;
            this.lcBtn.Location = new System.Drawing.Point(143, 112);
            this.lcBtn.Name = "lcBtn";
            this.lcBtn.Size = new System.Drawing.Size(96, 45);
            this.lcBtn.TabIndex = 5;
            this.lcBtn.Text = "←";
            this.lcBtn.UseVisualStyleBackColor = false;
            this.lcBtn.Click += new System.EventHandler(this.lcBtn_Click_1);
            // 
            // powBtn
            // 
            this.powBtn.BackColor = System.Drawing.SystemColors.Control;
            this.powBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.powBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powBtn.ForeColor = System.Drawing.Color.Navy;
            this.powBtn.Location = new System.Drawing.Point(92, 163);
            this.powBtn.Name = "powBtn";
            this.powBtn.Size = new System.Drawing.Size(45, 45);
            this.powBtn.TabIndex = 6;
            this.powBtn.Text = "x^2";
            this.powBtn.UseVisualStyleBackColor = false;
            this.powBtn.Click += new System.EventHandler(this.powBtn_Click);
            // 
            // sqrtBtn
            // 
            this.sqrtBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sqrtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sqrtBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtBtn.ForeColor = System.Drawing.Color.Navy;
            this.sqrtBtn.Location = new System.Drawing.Point(143, 163);
            this.sqrtBtn.Name = "sqrtBtn";
            this.sqrtBtn.Size = new System.Drawing.Size(45, 45);
            this.sqrtBtn.TabIndex = 7;
            this.sqrtBtn.Text = "√";
            this.sqrtBtn.UseVisualStyleBackColor = false;
            this.sqrtBtn.Click += new System.EventHandler(this.sqrtBtn_Click);
            // 
            // devideBtn
            // 
            this.devideBtn.BackColor = System.Drawing.SystemColors.Control;
            this.devideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.devideBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devideBtn.ForeColor = System.Drawing.Color.Navy;
            this.devideBtn.Location = new System.Drawing.Point(194, 163);
            this.devideBtn.Name = "devideBtn";
            this.devideBtn.Size = new System.Drawing.Size(45, 45);
            this.devideBtn.TabIndex = 8;
            this.devideBtn.Text = "÷";
            this.devideBtn.UseVisualStyleBackColor = false;
            this.devideBtn.Click += new System.EventHandler(this.devideBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.BackColor = System.Drawing.SystemColors.Control;
            this.oneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oneBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.ForeColor = System.Drawing.Color.Navy;
            this.oneBtn.Location = new System.Drawing.Point(41, 214);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(45, 45);
            this.oneBtn.TabIndex = 9;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = false;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.BackColor = System.Drawing.SystemColors.Control;
            this.twoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twoBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.ForeColor = System.Drawing.Color.Navy;
            this.twoBtn.Location = new System.Drawing.Point(92, 214);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(45, 45);
            this.twoBtn.TabIndex = 10;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = false;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.threeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.threeBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.ForeColor = System.Drawing.Color.Navy;
            this.threeBtn.Location = new System.Drawing.Point(143, 214);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(45, 45);
            this.threeBtn.TabIndex = 11;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = false;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.BackColor = System.Drawing.SystemColors.Control;
            this.fourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fourBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.ForeColor = System.Drawing.Color.Navy;
            this.fourBtn.Location = new System.Drawing.Point(41, 265);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(45, 45);
            this.fourBtn.TabIndex = 12;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = false;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.fiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fiveBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.ForeColor = System.Drawing.Color.Navy;
            this.fiveBtn.Location = new System.Drawing.Point(92, 265);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(45, 45);
            this.fiveBtn.TabIndex = 13;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = false;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sixBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.ForeColor = System.Drawing.Color.Navy;
            this.sixBtn.Location = new System.Drawing.Point(143, 265);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(45, 45);
            this.sixBtn.TabIndex = 14;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = false;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sevenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sevenBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.ForeColor = System.Drawing.Color.Navy;
            this.sevenBtn.Location = new System.Drawing.Point(41, 316);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(45, 45);
            this.sevenBtn.TabIndex = 15;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = false;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.BackColor = System.Drawing.SystemColors.Control;
            this.eightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eightBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.ForeColor = System.Drawing.Color.Navy;
            this.eightBtn.Location = new System.Drawing.Point(92, 316);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(45, 45);
            this.eightBtn.TabIndex = 16;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = false;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.BackColor = System.Drawing.SystemColors.Control;
            this.nineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nineBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.ForeColor = System.Drawing.Color.Navy;
            this.nineBtn.Location = new System.Drawing.Point(143, 316);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(45, 45);
            this.nineBtn.TabIndex = 17;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = false;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.BackColor = System.Drawing.SystemColors.Control;
            this.zeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zeroBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.ForeColor = System.Drawing.Color.Navy;
            this.zeroBtn.Location = new System.Drawing.Point(41, 367);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(45, 45);
            this.zeroBtn.TabIndex = 18;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = false;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.BackColor = System.Drawing.SystemColors.Control;
            this.multiplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplyBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.ForeColor = System.Drawing.Color.Navy;
            this.multiplyBtn.Location = new System.Drawing.Point(194, 214);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(45, 45);
            this.multiplyBtn.TabIndex = 19;
            this.multiplyBtn.Text = "*";
            this.multiplyBtn.UseVisualStyleBackColor = false;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.SystemColors.Control;
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minusBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.ForeColor = System.Drawing.Color.Navy;
            this.minusBtn.Location = new System.Drawing.Point(194, 265);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(45, 45);
            this.minusBtn.TabIndex = 20;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.SystemColors.Control;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.ForeColor = System.Drawing.Color.Navy;
            this.plusBtn.Location = new System.Drawing.Point(194, 316);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(45, 45);
            this.plusBtn.TabIndex = 21;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.equalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equalBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.ForeColor = System.Drawing.Color.White;
            this.equalBtn.Location = new System.Drawing.Point(92, 367);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(147, 45);
            this.equalBtn.TabIndex = 22;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = false;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // processLbl
            // 
            this.processLbl.AutoSize = true;
            this.processLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.processLbl.Location = new System.Drawing.Point(18, 72);
            this.processLbl.Name = "processLbl";
            this.processLbl.Size = new System.Drawing.Size(39, 32);
            this.processLbl.TabIndex = 24;
            this.processLbl.Text = "...";
            // 
            // CalculatorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(282, 424);
            this.Controls.Add(this.processLbl);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.devideBtn);
            this.Controls.Add(this.sqrtBtn);
            this.Controls.Add(this.powBtn);
            this.Controls.Add(this.lcBtn);
            this.Controls.Add(this.modeBtn);
            this.Controls.Add(this.fcBtn);
            this.Controls.Add(this.dxBtn);
            this.Controls.Add(this.resultTbox);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CalculatorMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTbox;
        private System.Windows.Forms.Button dxBtn;
        private System.Windows.Forms.Button fcBtn;
        private System.Windows.Forms.Button modeBtn;
        private System.Windows.Forms.Button lcBtn;
        private System.Windows.Forms.Button powBtn;
        private System.Windows.Forms.Button sqrtBtn;
        private System.Windows.Forms.Button devideBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Label processLbl;
    }
}

