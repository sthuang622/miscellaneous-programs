namespace Math_is_Hard {
    partial class MainMenu {
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
            this.TriangleButton = new System.Windows.Forms.Button();
            this.FactorialButton = new System.Windows.Forms.Button();
            this.WordFrequencyButton = new System.Windows.Forms.Button();
            this.FibonacciButton = new System.Windows.Forms.Button();
            this.ButtonTicTacToe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TriangleButton
            // 
            this.TriangleButton.Location = new System.Drawing.Point(12, 70);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(75, 23);
            this.TriangleButton.TabIndex = 3;
            this.TriangleButton.Text = "Triangle";
            this.TriangleButton.UseVisualStyleBackColor = true;
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // FactorialButton
            // 
            this.FactorialButton.Location = new System.Drawing.Point(12, 12);
            this.FactorialButton.Name = "FactorialButton";
            this.FactorialButton.Size = new System.Drawing.Size(75, 23);
            this.FactorialButton.TabIndex = 2;
            this.FactorialButton.Text = "Factorial";
            this.FactorialButton.UseVisualStyleBackColor = true;
            this.FactorialButton.Click += new System.EventHandler(this.FactorialButton_Click);
            // 
            // WordFrequencyButton
            // 
            this.WordFrequencyButton.Location = new System.Drawing.Point(12, 157);
            this.WordFrequencyButton.Name = "WordFrequencyButton";
            this.WordFrequencyButton.Size = new System.Drawing.Size(108, 23);
            this.WordFrequencyButton.TabIndex = 7;
            this.WordFrequencyButton.Text = "Word Frequency";
            this.WordFrequencyButton.UseVisualStyleBackColor = true;
            this.WordFrequencyButton.Click += new System.EventHandler(this.WordFrequencyButton_Click);
            // 
            // FibonacciButton
            // 
            this.FibonacciButton.Location = new System.Drawing.Point(12, 41);
            this.FibonacciButton.Name = "FibonacciButton";
            this.FibonacciButton.Size = new System.Drawing.Size(75, 23);
            this.FibonacciButton.TabIndex = 6;
            this.FibonacciButton.Text = "Fibonacci";
            this.FibonacciButton.UseVisualStyleBackColor = true;
            this.FibonacciButton.Click += new System.EventHandler(this.FibonacciButton_Click);
            // 
            // ButtonTicTacToe
            // 
            this.ButtonTicTacToe.Location = new System.Drawing.Point(13, 187);
            this.ButtonTicTacToe.Name = "ButtonTicTacToe";
            this.ButtonTicTacToe.Size = new System.Drawing.Size(107, 23);
            this.ButtonTicTacToe.TabIndex = 8;
            this.ButtonTicTacToe.Text = "Tic Tac Toe";
            this.ButtonTicTacToe.UseVisualStyleBackColor = true;
            this.ButtonTicTacToe.Click += new System.EventHandler(this.ButtonTicTacToe_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonTicTacToe);
            this.Controls.Add(this.WordFrequencyButton);
            this.Controls.Add(this.FibonacciButton);
            this.Controls.Add(this.TriangleButton);
            this.Controls.Add(this.FactorialButton);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.Button FactorialButton;
        private System.Windows.Forms.Button WordFrequencyButton;
        private System.Windows.Forms.Button FibonacciButton;
        private System.Windows.Forms.Button ButtonTicTacToe;
    }
}

