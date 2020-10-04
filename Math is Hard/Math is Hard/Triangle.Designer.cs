namespace Math_is_Hard {
    partial class Triangle {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aAInput = new System.Windows.Forms.NumericUpDown();
            this.aBInput = new System.Windows.Forms.NumericUpDown();
            this.aCInput = new System.Windows.Forms.NumericUpDown();
            this.BInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CInput = new System.Windows.Forms.NumericUpDown();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label12312 = new System.Windows.Forms.Label();
            this.ErrorTextField = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CInput)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Math_is_Hard.Properties.Resources.Triangle;
            this.pictureBox1.Location = new System.Drawing.Point(40, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "aA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "aB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "aC";
            // 
            // aAInput
            // 
            this.aAInput.DecimalPlaces = 2;
            this.aAInput.Location = new System.Drawing.Point(219, 80);
            this.aAInput.Maximum = new decimal(new int[] {
            177,
            0,
            0,
            0});
            this.aAInput.Name = "aAInput";
            this.aAInput.Size = new System.Drawing.Size(67, 20);
            this.aAInput.TabIndex = 4;
            this.aAInput.ValueChanged += new System.EventHandler(this.aAInput_ValueChanged);
            this.aAInput.Click += new System.EventHandler(this.aAInput_Click);
            this.aAInput.Leave += new System.EventHandler(this.aALeave);
            // 
            // aBInput
            // 
            this.aBInput.DecimalPlaces = 2;
            this.aBInput.Location = new System.Drawing.Point(126, 291);
            this.aBInput.Maximum = new decimal(new int[] {
            177,
            0,
            0,
            0});
            this.aBInput.Name = "aBInput";
            this.aBInput.Size = new System.Drawing.Size(67, 20);
            this.aBInput.TabIndex = 5;
            this.aBInput.ValueChanged += new System.EventHandler(this.aBInput_ValueChanged);
            this.aBInput.Click += new System.EventHandler(this.aBInput_Click);
            this.aBInput.Leave += new System.EventHandler(this.aBLeave);
            // 
            // aCInput
            // 
            this.aCInput.DecimalPlaces = 2;
            this.aCInput.Location = new System.Drawing.Point(394, 291);
            this.aCInput.Maximum = new decimal(new int[] {
            177,
            0,
            0,
            0});
            this.aCInput.Name = "aCInput";
            this.aCInput.Size = new System.Drawing.Size(67, 20);
            this.aCInput.TabIndex = 6;
            this.aCInput.ValueChanged += new System.EventHandler(this.aCInput_ValueChanged);
            this.aCInput.Click += new System.EventHandler(this.aCInput_Click);
            this.aCInput.Leave += new System.EventHandler(this.aCLeave);
            // 
            // BInput
            // 
            this.BInput.DecimalPlaces = 2;
            this.BInput.Location = new System.Drawing.Point(420, 157);
            this.BInput.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.BInput.Name = "BInput";
            this.BInput.Size = new System.Drawing.Size(67, 20);
            this.BInput.TabIndex = 7;
            this.BInput.ValueChanged += new System.EventHandler(this.BInput_ValueChanged);
            this.BInput.Click += new System.EventHandler(this.BInput_Click);
            this.BInput.Leave += new System.EventHandler(this.Bleave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "A";
            // 
            // AInput
            // 
            this.AInput.DecimalPlaces = 2;
            this.AInput.Location = new System.Drawing.Point(240, 332);
            this.AInput.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.AInput.Name = "AInput";
            this.AInput.Size = new System.Drawing.Size(67, 20);
            this.AInput.TabIndex = 9;
            this.AInput.ValueChanged += new System.EventHandler(this.AInput_ValueChanged);
            this.AInput.Click += new System.EventHandler(this.AInput_Click);
            this.AInput.Leave += new System.EventHandler(this.ALeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "C";
            // 
            // CInput
            // 
            this.CInput.DecimalPlaces = 2;
            this.CInput.Location = new System.Drawing.Point(77, 157);
            this.CInput.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.CInput.Name = "CInput";
            this.CInput.Size = new System.Drawing.Size(67, 20);
            this.CInput.TabIndex = 11;
            this.CInput.ValueChanged += new System.EventHandler(this.CInput_ValueChanged);
            this.CInput.Click += new System.EventHandler(this.CInput_Click);
            this.CInput.Leave += new System.EventHandler(this.CLeave);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.Location = new System.Drawing.Point(465, 334);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 13;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "How to use: Provide 3 Positive Values, NO MORE, NO LESS. \r\n                      " +
    "Leave rest of the values as 0s";
            // 
            // label12312
            // 
            this.label12312.AutoSize = true;
            this.label12312.Location = new System.Drawing.Point(547, 26);
            this.label12312.Name = "label12312";
            this.label12312.Size = new System.Drawing.Size(32, 13);
            this.label12312.TabIndex = 15;
            this.label12312.Text = "Error:";
            // 
            // ErrorTextField
            // 
            this.ErrorTextField.Location = new System.Drawing.Point(586, 26);
            this.ErrorTextField.Name = "ErrorTextField";
            this.ErrorTextField.Size = new System.Drawing.Size(202, 415);
            this.ErrorTextField.TabIndex = 16;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(465, 359);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 17;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.ErrorTextField);
            this.Controls.Add(this.label12312);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BInput);
            this.Controls.Add(this.aCInput);
            this.Controls.Add(this.aBInput);
            this.Controls.Add(this.aAInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Triangle";
            this.Text = "Triangle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown aAInput;
        private System.Windows.Forms.NumericUpDown aBInput;
        private System.Windows.Forms.NumericUpDown aCInput;
        private System.Windows.Forms.NumericUpDown BInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown AInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CInput;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12312;
        private System.Windows.Forms.Label ErrorTextField;
        private System.Windows.Forms.Button Reset;
    }
}