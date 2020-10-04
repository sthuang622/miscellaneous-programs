namespace Math_is_Hard {
    partial class TicTacToe {
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
            this.ButtonA1 = new System.Windows.Forms.Button();
            this.ButtonA2 = new System.Windows.Forms.Button();
            this.ButtonA3 = new System.Windows.Forms.Button();
            this.ButtonB3 = new System.Windows.Forms.Button();
            this.ButtonB2 = new System.Windows.Forms.Button();
            this.ButtonB1 = new System.Windows.Forms.Button();
            this.ButtonC3 = new System.Windows.Forms.Button();
            this.ButtonC2 = new System.Windows.Forms.Button();
            this.ButtonC1 = new System.Windows.Forms.Button();
            this.TTTBoard = new System.Windows.Forms.GroupBox();
            this.SymbolX = new System.Windows.Forms.RadioButton();
            this.SymbolO = new System.Windows.Forms.RadioButton();
            this.PlayerSymbol = new System.Windows.Forms.GroupBox();
            this.DebuggerLabel = new System.Windows.Forms.Label();
            this.ButtonPlayAgain = new System.Windows.Forms.Button();
            this.ComputerDifficulity = new System.Windows.Forms.GroupBox();
            this.Difficulity0 = new System.Windows.Forms.RadioButton();
            this.Difficulity1 = new System.Windows.Forms.RadioButton();
            this.RecordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TTTBoard.SuspendLayout();
            this.PlayerSymbol.SuspendLayout();
            this.ComputerDifficulity.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Math_is_Hard.Properties.Resources.tictactoeboard;
            this.pictureBox1.Location = new System.Drawing.Point(26, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 332);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonA1
            // 
            this.ButtonA1.Location = new System.Drawing.Point(26, 24);
            this.ButtonA1.Name = "ButtonA1";
            this.ButtonA1.Size = new System.Drawing.Size(109, 109);
            this.ButtonA1.TabIndex = 1;
            this.ButtonA1.Text = "Select";
            this.ButtonA1.UseVisualStyleBackColor = true;
            this.ButtonA1.Click += new System.EventHandler(this.ButtonA1_Click);
            // 
            // ButtonA2
            // 
            this.ButtonA2.Location = new System.Drawing.Point(141, 24);
            this.ButtonA2.Name = "ButtonA2";
            this.ButtonA2.Size = new System.Drawing.Size(106, 109);
            this.ButtonA2.TabIndex = 2;
            this.ButtonA2.Text = "Select";
            this.ButtonA2.UseVisualStyleBackColor = true;
            this.ButtonA2.Click += new System.EventHandler(this.ButtonA2_Click);
            // 
            // ButtonA3
            // 
            this.ButtonA3.Location = new System.Drawing.Point(253, 24);
            this.ButtonA3.Name = "ButtonA3";
            this.ButtonA3.Size = new System.Drawing.Size(107, 109);
            this.ButtonA3.TabIndex = 3;
            this.ButtonA3.Text = "Select";
            this.ButtonA3.UseVisualStyleBackColor = true;
            this.ButtonA3.Click += new System.EventHandler(this.ButtonA3_Click);
            // 
            // ButtonB3
            // 
            this.ButtonB3.Location = new System.Drawing.Point(253, 139);
            this.ButtonB3.Name = "ButtonB3";
            this.ButtonB3.Size = new System.Drawing.Size(107, 105);
            this.ButtonB3.TabIndex = 6;
            this.ButtonB3.Text = "Select";
            this.ButtonB3.UseVisualStyleBackColor = true;
            this.ButtonB3.Click += new System.EventHandler(this.ButtonB3_Click);
            // 
            // ButtonB2
            // 
            this.ButtonB2.Location = new System.Drawing.Point(141, 139);
            this.ButtonB2.Name = "ButtonB2";
            this.ButtonB2.Size = new System.Drawing.Size(106, 105);
            this.ButtonB2.TabIndex = 5;
            this.ButtonB2.Text = "Select";
            this.ButtonB2.UseVisualStyleBackColor = true;
            this.ButtonB2.Click += new System.EventHandler(this.ButtonB2_Click);
            // 
            // ButtonB1
            // 
            this.ButtonB1.Location = new System.Drawing.Point(26, 139);
            this.ButtonB1.Name = "ButtonB1";
            this.ButtonB1.Size = new System.Drawing.Size(109, 105);
            this.ButtonB1.TabIndex = 4;
            this.ButtonB1.Text = "Select";
            this.ButtonB1.UseVisualStyleBackColor = true;
            this.ButtonB1.Click += new System.EventHandler(this.ButtonB1_Click);
            // 
            // ButtonC3
            // 
            this.ButtonC3.Location = new System.Drawing.Point(253, 250);
            this.ButtonC3.Name = "ButtonC3";
            this.ButtonC3.Size = new System.Drawing.Size(107, 106);
            this.ButtonC3.TabIndex = 9;
            this.ButtonC3.Text = "Select";
            this.ButtonC3.UseVisualStyleBackColor = true;
            this.ButtonC3.Click += new System.EventHandler(this.ButtonC3_Click);
            // 
            // ButtonC2
            // 
            this.ButtonC2.Location = new System.Drawing.Point(141, 250);
            this.ButtonC2.Name = "ButtonC2";
            this.ButtonC2.Size = new System.Drawing.Size(106, 106);
            this.ButtonC2.TabIndex = 8;
            this.ButtonC2.Text = "Select";
            this.ButtonC2.UseVisualStyleBackColor = true;
            this.ButtonC2.Click += new System.EventHandler(this.ButtonC2_Click);
            // 
            // ButtonC1
            // 
            this.ButtonC1.Location = new System.Drawing.Point(26, 250);
            this.ButtonC1.Name = "ButtonC1";
            this.ButtonC1.Size = new System.Drawing.Size(109, 106);
            this.ButtonC1.TabIndex = 7;
            this.ButtonC1.Text = "Select";
            this.ButtonC1.UseVisualStyleBackColor = true;
            this.ButtonC1.Click += new System.EventHandler(this.ButtonC1_Click);
            // 
            // TTTBoard
            // 
            this.TTTBoard.Controls.Add(this.ButtonC3);
            this.TTTBoard.Controls.Add(this.ButtonC2);
            this.TTTBoard.Controls.Add(this.ButtonC1);
            this.TTTBoard.Controls.Add(this.ButtonB3);
            this.TTTBoard.Controls.Add(this.ButtonB2);
            this.TTTBoard.Controls.Add(this.ButtonB1);
            this.TTTBoard.Controls.Add(this.ButtonA3);
            this.TTTBoard.Controls.Add(this.ButtonA2);
            this.TTTBoard.Controls.Add(this.ButtonA1);
            this.TTTBoard.Controls.Add(this.pictureBox1);
            this.TTTBoard.Location = new System.Drawing.Point(12, 59);
            this.TTTBoard.Name = "TTTBoard";
            this.TTTBoard.Size = new System.Drawing.Size(412, 379);
            this.TTTBoard.TabIndex = 10;
            this.TTTBoard.TabStop = false;
            this.TTTBoard.Text = "Board";
            // 
            // SymbolX
            // 
            this.SymbolX.AutoSize = true;
            this.SymbolX.Checked = true;
            this.SymbolX.Location = new System.Drawing.Point(6, 19);
            this.SymbolX.Name = "SymbolX";
            this.SymbolX.Size = new System.Drawing.Size(32, 17);
            this.SymbolX.TabIndex = 11;
            this.SymbolX.TabStop = true;
            this.SymbolX.Text = "X";
            this.SymbolX.UseVisualStyleBackColor = true;
            this.SymbolX.CheckedChanged += new System.EventHandler(this.SymbolX_CheckedChanged);
            // 
            // SymbolO
            // 
            this.SymbolO.AutoSize = true;
            this.SymbolO.Location = new System.Drawing.Point(6, 43);
            this.SymbolO.Name = "SymbolO";
            this.SymbolO.Size = new System.Drawing.Size(33, 17);
            this.SymbolO.TabIndex = 12;
            this.SymbolO.Text = "O";
            this.SymbolO.UseVisualStyleBackColor = true;
            this.SymbolO.CheckedChanged += new System.EventHandler(this.SymbolO_CheckedChanged);
            // 
            // PlayerSymbol
            // 
            this.PlayerSymbol.Controls.Add(this.SymbolX);
            this.PlayerSymbol.Controls.Add(this.SymbolO);
            this.PlayerSymbol.Location = new System.Drawing.Point(430, 59);
            this.PlayerSymbol.Name = "PlayerSymbol";
            this.PlayerSymbol.Size = new System.Drawing.Size(111, 84);
            this.PlayerSymbol.TabIndex = 13;
            this.PlayerSymbol.TabStop = false;
            this.PlayerSymbol.Text = "Player Symbol";
            this.PlayerSymbol.Enter += new System.EventHandler(this.PlayerSymbol_Enter);
            // 
            // DebuggerLabel
            // 
            this.DebuggerLabel.Location = new System.Drawing.Point(430, 172);
            this.DebuggerLabel.Name = "DebuggerLabel";
            this.DebuggerLabel.Size = new System.Drawing.Size(303, 90);
            this.DebuggerLabel.TabIndex = 14;
            this.DebuggerLabel.Text = "debugger";
            // 
            // ButtonPlayAgain
            // 
            this.ButtonPlayAgain.Location = new System.Drawing.Point(430, 146);
            this.ButtonPlayAgain.Name = "ButtonPlayAgain";
            this.ButtonPlayAgain.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlayAgain.TabIndex = 15;
            this.ButtonPlayAgain.Text = "PlayAgain";
            this.ButtonPlayAgain.UseVisualStyleBackColor = true;
            this.ButtonPlayAgain.Click += new System.EventHandler(this.ButtonPlayAgain_Click);
            // 
            // ComputerDifficulity
            // 
            this.ComputerDifficulity.Controls.Add(this.Difficulity0);
            this.ComputerDifficulity.Controls.Add(this.Difficulity1);
            this.ComputerDifficulity.Location = new System.Drawing.Point(547, 59);
            this.ComputerDifficulity.Name = "ComputerDifficulity";
            this.ComputerDifficulity.Size = new System.Drawing.Size(111, 84);
            this.ComputerDifficulity.TabIndex = 14;
            this.ComputerDifficulity.TabStop = false;
            this.ComputerDifficulity.Text = "Computer Difficulity";
            // 
            // Difficulity0
            // 
            this.Difficulity0.AutoSize = true;
            this.Difficulity0.Checked = true;
            this.Difficulity0.Location = new System.Drawing.Point(6, 19);
            this.Difficulity0.Name = "Difficulity0";
            this.Difficulity0.Size = new System.Drawing.Size(67, 17);
            this.Difficulity0.TabIndex = 11;
            this.Difficulity0.TabStop = true;
            this.Difficulity0.Text = "Beginner";
            this.Difficulity0.UseVisualStyleBackColor = true;
            this.Difficulity0.CheckedChanged += new System.EventHandler(this.Difficulity0_CheckedChanged);
            // 
            // Difficulity1
            // 
            this.Difficulity1.AutoSize = true;
            this.Difficulity1.Location = new System.Drawing.Point(6, 43);
            this.Difficulity1.Name = "Difficulity1";
            this.Difficulity1.Size = new System.Drawing.Size(75, 17);
            this.Difficulity1.TabIndex = 12;
            this.Difficulity1.Text = "Calculated";
            this.Difficulity1.UseVisualStyleBackColor = true;
            this.Difficulity1.CheckedChanged += new System.EventHandler(this.Difficulity1_CheckedChanged);
            // 
            // RecordLabel
            // 
            this.RecordLabel.Location = new System.Drawing.Point(12, 9);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(412, 47);
            this.RecordLabel.TabIndex = 16;
            this.RecordLabel.Text = "Record";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RecordLabel);
            this.Controls.Add(this.ComputerDifficulity);
            this.Controls.Add(this.ButtonPlayAgain);
            this.Controls.Add(this.DebuggerLabel);
            this.Controls.Add(this.PlayerSymbol);
            this.Controls.Add(this.TTTBoard);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TTTBoard.ResumeLayout(false);
            this.PlayerSymbol.ResumeLayout(false);
            this.PlayerSymbol.PerformLayout();
            this.ComputerDifficulity.ResumeLayout(false);
            this.ComputerDifficulity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonA1;
        private System.Windows.Forms.Button ButtonA2;
        private System.Windows.Forms.Button ButtonA3;
        private System.Windows.Forms.Button ButtonB3;
        private System.Windows.Forms.Button ButtonB2;
        private System.Windows.Forms.Button ButtonB1;
        private System.Windows.Forms.Button ButtonC3;
        private System.Windows.Forms.Button ButtonC2;
        private System.Windows.Forms.Button ButtonC1;
        private System.Windows.Forms.GroupBox TTTBoard;
        private System.Windows.Forms.RadioButton SymbolX;
        private System.Windows.Forms.RadioButton SymbolO;
        private System.Windows.Forms.GroupBox PlayerSymbol;
        private System.Windows.Forms.Label DebuggerLabel;
        private System.Windows.Forms.Button ButtonPlayAgain;
        private System.Windows.Forms.GroupBox ComputerDifficulity;
        private System.Windows.Forms.RadioButton Difficulity0;
        private System.Windows.Forms.RadioButton Difficulity1;
        private System.Windows.Forms.Label RecordLabel;
    }
}