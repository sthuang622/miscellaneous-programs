using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Math_is_Hard {
    public partial class TicTacToe : Form {
        public enum eRegion {
            A1, A2, A3,
            B1, B2, B3,
            C1, C2, C3
        }
        public enum eSymbol { None, X, O }

        
        


        public TicTacToe() {
            InitializeComponent();
            TicTacToeAI.StartScript(ButtonA1, ButtonA2, ButtonA3,
                                    ButtonB1, ButtonB2, ButtonB3,
                                    ButtonC1, ButtonC2, ButtonC3, DebuggerLabel, RecordLabel);
            SetSymbol();
        }

        private void ButtonA1_Click(object sender, EventArgs e) {
            SelectRegion(eRegion.A1);
        }

        private void ButtonA2_Click(object sender, EventArgs e) {
            SelectRegion(eRegion.A2);
        }

        private void ButtonA3_Click(object sender, EventArgs e) {
            SelectRegion(eRegion.A3);
        }

        private void ButtonB1_Click(object sender, EventArgs e) {
            SelectRegion(eRegion.B1);
        }

        private void ButtonB2_Click(object sender, EventArgs e) {
            SelectRegion(eRegion.B2);
        }

        private void ButtonB3_Click(object sender, EventArgs e) {
            SelectRegion(eRegion.B3);
        }

        private void ButtonC1_Click(object sender, EventArgs e) {
            SelectRegion(eRegion.C1);
        }

        private void ButtonC2_Click(object sender, EventArgs e) {
            SelectRegion(eRegion.C2);
        }

        private void ButtonC3_Click(object sender, EventArgs e) {
            SelectRegion(eRegion.C3);
        }

        void SelectRegion(eRegion _region) {
            TicTacToeAI.Input(TicTacToeAI.PlayerSymbol, _region);
        }

        private void PlayerSymbol_Enter(object sender, EventArgs e) {

        }

        private void SymbolX_CheckedChanged(object sender, EventArgs e) {
            SetSymbol();
        }

        private void SymbolO_CheckedChanged(object sender, EventArgs e) {
            SetSymbol();
        }
        void SetSymbol() {
            if(SymbolX.Checked) {
                TicTacToeAI.PlayerSymbol = eSymbol.X;
            } else { TicTacToeAI.PlayerSymbol = eSymbol.O; }
            TicTacToeAI.ChangeSetting();

        }

        private void ButtonPlayAgain_Click(object sender, EventArgs e) {
            TicTacToeAI.ResetBoard();
        }

        private void Difficulity0_CheckedChanged(object sender, EventArgs e) {

            SetDifficulity(); TicTacToeAI.ChangeSetting();
        }

        private void Difficulity1_CheckedChanged(object sender, EventArgs e) {
            SetDifficulity(); TicTacToeAI.ChangeSetting();
        }
        void SetDifficulity() {
            if(Difficulity0.Checked) {
                TicTacToeAI.CompDifficulity = 0;
            } else if(Difficulity1.Checked) {
                TicTacToeAI.CompDifficulity = 1;
            }
            TicTacToeAI.ChangeSetting();

        }

    }
}

