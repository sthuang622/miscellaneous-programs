using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_is_Hard {
    public partial class TicTacToe : Form {

        public class TTTRegion {
            public eSymbol owner;
            public Button button;
            public double IndependentValue { get; protected set; }
            public double Value;
            public List<WinCon> WinCons;
            string id;

            public TTTRegion(Button _button, double value, string _id) {
                id = _id;
                IndependentValue = value;
                button = _button;
                WinCons = new List<WinCon>();
            }


            public void WinningMoveCheck(eSymbol _sym) {
                if(owner == eSymbol.None) {
                    foreach(WinCon child in WinCons) {
                        child.WinningMoveCheck(this, _sym);
                        child.PriorityPickCheck(this);
                    }
                }
            }
            public void CalcValue(eSymbol _sym) {
                if(owner == eSymbol.None) {
                    Value = IndependentValue * 2;


                    foreach(WinCon child in WinCons) {
                        child.CalcValue(this, _sym);

                    }
                    if(TicTacToeAI.CompPicks.Count > 0) {
                        if(TicTacToeAI.CompPicks[0].Value == Value) {
                            TicTacToeAI.CompPicks.Add(this);
                        } else if (TicTacToeAI.CompPicks[0].Value < Value) {
                            TicTacToeAI.CompPicks.Clear();
                            TicTacToeAI.CompPicks.Add(this);
                        }
                    } else { TicTacToeAI.CompPicks.Add(this); }
                }
            }


            public bool WinChecker() {
                foreach(WinCon child in WinCons) {
                    if(child.WinChecker()) { return true; }
                }
                return false;
            }
            
            public void Reset() {
                SetOwner(eSymbol.None);
                Value = 0;
                button.UseVisualStyleBackColor = true;
            }
            public void SetOwner(eSymbol _sym) {
                Value = 0;
                owner = _sym;
                if(_sym == eSymbol.None) {
                    button.Enabled = true;
                    button.Text = "Select";
                } else {
                    button.Enabled = false;
                    button.Text = owner.ToString();
                }
                TicTacToeAI.debugger.Text = "select " + id;
            }

        }
    }
}
