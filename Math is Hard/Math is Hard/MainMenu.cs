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
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
        }

        private void RecurrsionButton_Click(object sender, EventArgs e) {

        }

        private void FactorialButton_Click(object sender, EventArgs e) {
            new Factorial().Show();
        }

        private void FibonacciButton_Click(object sender, EventArgs e) {
            new Fibonacci().Show();
        }

        private void TriangleButton_Click(object sender, EventArgs e) {
            new Triangle().Show();
        }

        private void WordFrequencyButton_Click(object sender, EventArgs e) {
            new WordFrequency().Show();
        }

        private void ButtonTicTacToe_Click(object sender, EventArgs e) {
            new TicTacToe().Show();
        }
    }
}
