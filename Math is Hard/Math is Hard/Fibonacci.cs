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
    public partial class Fibonacci : Form {
        public Fibonacci() {
            InitializeComponent();
        }

        private void InputNumber_ValueChanged(object sender, EventArgs e) {

        }
        ulong FibonacciCalculation(ulong x) {
            if(x == 0) { return 0; } 
            else if(x == 1) { return 1; } 
            else { return FibonacciCalculation(x - 1) + FibonacciCalculation(x - 2); }
        }

        private void CalculateButton_Click(object sender, EventArgs e) {
            ulong answer = FibonacciCalculation((ulong)InputNumber.Value);

            Error.Text = "";
            if(InputNumber.Value != 0 && answer == 0) {
                Error.Text += "\nNumerical Value is too Large";
            }

            AnswerLabel.Text = "" + answer;
        }
    }
}
