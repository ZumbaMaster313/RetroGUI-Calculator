namespace CalculatorGUI
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
            this.CalculationBox = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.SubtractBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.DevideBtn = new System.Windows.Forms.Button();
            this.EqualBtn = new System.Windows.Forms.Button();
            this.Number1Btn = new System.Windows.Forms.Button();
            this.Number3Btn = new System.Windows.Forms.Button();
            this.Number4Btn = new System.Windows.Forms.Button();
            this.Number5Btn = new System.Windows.Forms.Button();
            this.Number6Btn = new System.Windows.Forms.Button();
            this.Number7Btn = new System.Windows.Forms.Button();
            this.Number8Btn = new System.Windows.Forms.Button();
            this.Number0Btn = new System.Windows.Forms.Button();
            this.DecimalBtn = new System.Windows.Forms.Button();
            this.Number2Btn = new System.Windows.Forms.Button();
            this.Number9Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculationBox
            // 
            this.CalculationBox.Location = new System.Drawing.Point(12, 27);
            this.CalculationBox.Multiline = true;
            this.CalculationBox.Name = "CalculationBox";
            this.CalculationBox.ReadOnly = true;
            this.CalculationBox.Size = new System.Drawing.Size(257, 85);
            this.CalculationBox.TabIndex = 0;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(295, 27);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(137, 44);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "A/C";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Location = new System.Drawing.Point(295, 105);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(154, 44);
            this.PlusBtn.TabIndex = 2;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.MathFunc_Click);
            // 
            // SubtractBtn
            // 
            this.SubtractBtn.Location = new System.Drawing.Point(295, 180);
            this.SubtractBtn.Name = "SubtractBtn";
            this.SubtractBtn.Size = new System.Drawing.Size(154, 44);
            this.SubtractBtn.TabIndex = 3;
            this.SubtractBtn.Text = "-";
            this.SubtractBtn.UseVisualStyleBackColor = true;
            this.SubtractBtn.Click += new System.EventHandler(this.MathFunc_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Location = new System.Drawing.Point(295, 261);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(154, 44);
            this.MultiplyBtn.TabIndex = 4;
            this.MultiplyBtn.Text = "*";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.MathFunc_Click);
            // 
            // DevideBtn
            // 
            this.DevideBtn.Location = new System.Drawing.Point(295, 337);
            this.DevideBtn.Name = "DevideBtn";
            this.DevideBtn.Size = new System.Drawing.Size(154, 44);
            this.DevideBtn.TabIndex = 5;
            this.DevideBtn.Text = "/";
            this.DevideBtn.UseVisualStyleBackColor = true;
            this.DevideBtn.Click += new System.EventHandler(this.MathFunc_Click);
            // 
            // EqualBtn
            // 
            this.EqualBtn.Location = new System.Drawing.Point(295, 419);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(154, 44);
            this.EqualBtn.TabIndex = 6;
            this.EqualBtn.Text = "=";
            this.EqualBtn.UseVisualStyleBackColor = true;
            this.EqualBtn.Click += new System.EventHandler(this.EqualBtn_Click);
            // 
            // Number1Btn
            // 
            this.Number1Btn.Location = new System.Drawing.Point(12, 162);
            this.Number1Btn.Name = "Number1Btn";
            this.Number1Btn.Size = new System.Drawing.Size(75, 62);
            this.Number1Btn.TabIndex = 7;
            this.Number1Btn.Text = "1";
            this.Number1Btn.UseVisualStyleBackColor = true;
            this.Number1Btn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // Number3Btn
            // 
            this.Number3Btn.Location = new System.Drawing.Point(194, 162);
            this.Number3Btn.Name = "Number3Btn";
            this.Number3Btn.Size = new System.Drawing.Size(75, 62);
            this.Number3Btn.TabIndex = 9;
            this.Number3Btn.Text = "3";
            this.Number3Btn.UseVisualStyleBackColor = true;
            this.Number3Btn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // Number4Btn
            // 
            this.Number4Btn.Location = new System.Drawing.Point(12, 272);
            this.Number4Btn.Name = "Number4Btn";
            this.Number4Btn.Size = new System.Drawing.Size(75, 62);
            this.Number4Btn.TabIndex = 10;
            this.Number4Btn.Text = "4";
            this.Number4Btn.UseVisualStyleBackColor = true;
            this.Number4Btn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // Number5Btn
            // 
            this.Number5Btn.Location = new System.Drawing.Point(103, 272);
            this.Number5Btn.Name = "Number5Btn";
            this.Number5Btn.Size = new System.Drawing.Size(75, 62);
            this.Number5Btn.TabIndex = 11;
            this.Number5Btn.Text = "5";
            this.Number5Btn.UseVisualStyleBackColor = true;
            this.Number5Btn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // Number6Btn
            // 
            this.Number6Btn.Location = new System.Drawing.Point(193, 272);
            this.Number6Btn.Name = "Number6Btn";
            this.Number6Btn.Size = new System.Drawing.Size(75, 62);
            this.Number6Btn.TabIndex = 12;
            this.Number6Btn.Text = "6";
            this.Number6Btn.UseVisualStyleBackColor = true;
            this.Number6Btn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // Number7Btn
            // 
            this.Number7Btn.Location = new System.Drawing.Point(12, 377);
            this.Number7Btn.Name = "Number7Btn";
            this.Number7Btn.Size = new System.Drawing.Size(75, 62);
            this.Number7Btn.TabIndex = 13;
            this.Number7Btn.Text = "7";
            this.Number7Btn.UseVisualStyleBackColor = true;
            this.Number7Btn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // Number8Btn
            // 
            this.Number8Btn.Location = new System.Drawing.Point(103, 377);
            this.Number8Btn.Name = "Number8Btn";
            this.Number8Btn.Size = new System.Drawing.Size(75, 62);
            this.Number8Btn.TabIndex = 14;
            this.Number8Btn.Text = "8";
            this.Number8Btn.UseVisualStyleBackColor = true;
            this.Number8Btn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // Number0Btn
            // 
            this.Number0Btn.Location = new System.Drawing.Point(12, 478);
            this.Number0Btn.Name = "Number0Btn";
            this.Number0Btn.Size = new System.Drawing.Size(166, 62);
            this.Number0Btn.TabIndex = 16;
            this.Number0Btn.Text = "0";
            this.Number0Btn.UseVisualStyleBackColor = true;
            this.Number0Btn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // DecimalBtn
            // 
            this.DecimalBtn.Location = new System.Drawing.Point(193, 478);
            this.DecimalBtn.Name = "DecimalBtn";
            this.DecimalBtn.Size = new System.Drawing.Size(75, 62);
            this.DecimalBtn.TabIndex = 17;
            this.DecimalBtn.Text = ".";
            this.DecimalBtn.UseVisualStyleBackColor = true;
            this.DecimalBtn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // Number2Btn
            // 
            this.Number2Btn.Location = new System.Drawing.Point(103, 162);
            this.Number2Btn.Name = "Number2Btn";
            this.Number2Btn.Size = new System.Drawing.Size(75, 62);
            this.Number2Btn.TabIndex = 18;
            this.Number2Btn.Text = "2";
            this.Number2Btn.UseVisualStyleBackColor = true;
            this.Number2Btn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // Number9Btn
            // 
            this.Number9Btn.Location = new System.Drawing.Point(194, 377);
            this.Number9Btn.Name = "Number9Btn";
            this.Number9Btn.Size = new System.Drawing.Size(75, 62);
            this.Number9Btn.TabIndex = 19;
            this.Number9Btn.Text = "9";
            this.Number9Btn.UseVisualStyleBackColor = true;
            this.Number9Btn.Click += new System.EventHandler(this.NumberBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 552);
            this.Controls.Add(this.Number9Btn);
            this.Controls.Add(this.Number2Btn);
            this.Controls.Add(this.DecimalBtn);
            this.Controls.Add(this.Number0Btn);
            this.Controls.Add(this.Number8Btn);
            this.Controls.Add(this.Number7Btn);
            this.Controls.Add(this.Number6Btn);
            this.Controls.Add(this.Number5Btn);
            this.Controls.Add(this.Number4Btn);
            this.Controls.Add(this.Number3Btn);
            this.Controls.Add(this.Number1Btn);
            this.Controls.Add(this.EqualBtn);
            this.Controls.Add(this.DevideBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.SubtractBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CalculationBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalculationBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button SubtractBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button DevideBtn;
        private System.Windows.Forms.Button EqualBtn;
        private System.Windows.Forms.Button Number1Btn;
        private System.Windows.Forms.Button Number3Btn;
        private System.Windows.Forms.Button Number4Btn;
        private System.Windows.Forms.Button Number5Btn;
        private System.Windows.Forms.Button Number6Btn;
        private System.Windows.Forms.Button Number7Btn;
        private System.Windows.Forms.Button Number8Btn;
        private System.Windows.Forms.Button Number0Btn;
        private System.Windows.Forms.Button DecimalBtn;
        private System.Windows.Forms.Button Number2Btn;
        private System.Windows.Forms.Button Number9Btn;
    }
}

