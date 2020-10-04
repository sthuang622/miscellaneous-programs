using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_is_Hard {
    public partial class Factorial : Form {
        public Factorial() {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void CalculateButton_Click(object sender, EventArgs e) {
            ulong answer = FactorialCalculation((ulong)numericUpDown1.Value);

            Error.Text = "";
            if (answer == 0) {
                Error.Text += "\nNumerical Value is too Large";
            }

            AnswerLabel.Text = "" + answer;
        }
        ulong FactorialCalculation(ulong x) {
            if (x == 1) {
                return 1;
            } else {
                return x * FactorialCalculation(x - 1);
            }
        }

        private void AnswerLabel_Click(object sender, EventArgs e) {

        }

        private void Disclaimer_Click(object sender, EventArgs e) {

        }

        private void Error_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
