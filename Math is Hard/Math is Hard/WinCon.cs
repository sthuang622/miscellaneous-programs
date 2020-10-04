using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_is_Hard {
    public partial class TicTacToe : Form {
        public class WinCon {
            public TTTRegion T1, T2, T3;
            public eSymbol owner {
                get {
                    if(T1.owner == T2.owner && T2.owner == T3.owner && T1.owner != eSymbol.None) {
                        T1.button.BackColor = Color.Red;
                        T2.button.BackColor = Color.Red;
                        T3.button.BackColor = Color.Red;
                        return T1.owner;
                    } else { return eSymbol.None; }
                }
            }
            public WinCon(TTTRegion t1, TTTRegion t2, TTTRegion t3) {
                T1 = t1;
                T2 = t2;
                T3 = t3;
                T1.WinCons.Add(this);
                T2.WinCons.Add(this);
                T3.WinCons.Add(this);
            }
            public void PriorityPickCheck(TTTRegion T0) {
                TTTRegion t1p = null;
                TTTRegion t2p = null;
                GetOther2(T0, ref t1p, ref t2p);
                if (t1p.owner == t2p.owner && t1p.owner != eSymbol.None) {
                    TicTacToeAI.CompPicksPriority.Add(T0);
                }
            }

            public void WinningMoveCheck(TTTRegion T0, eSymbol _sym) {
                TTTRegion t1p = null;
                TTTRegion t2p = null;
                GetOther2(T0, ref t1p, ref t2p);

                if(t1p.owner == t2p.owner && t1p.owner == _sym && t1p.owner != eSymbol.None) {
                    TicTacToeAI.WinningMove = T0;
                }
            }

            public double CalcValue(TTTRegion T0, eSymbol _sym) {
                TTTRegion t1p = null;
                TTTRegion t2p = null;
                GetOther2(T0, ref t1p, ref t2p);
                if(T1.owner != T2.owner && T1.owner != eSymbol.None && T2.owner != eSymbol.None) { return 0; }
                return T0.Value += addingValue(t1p, _sym) + addingValue(t2p, _sym);
            }
            double addingValue(TTTRegion T0, eSymbol _sym) {
                if(T0.owner == eSymbol.None) {
                    return T0.IndependentValue;
                } else if (T0.owner == _sym) {
                    return T0.IndependentValue * 2;
                } else {
                    return T0.IndependentValue * -1;
                }
            }



            public bool WinChecker() {
                if(T1.owner == T2.owner && T2.owner == T3.owner && T1.owner != eSymbol.None) {

                    T1.button.BackColor = Color.Red;
                    T2.button.BackColor = Color.Red;
                    T3.button.BackColor = Color.Red;
                    return true;

                }
                return false;
            }
            void GetOther2(TTTRegion T0, ref TTTRegion t1p, ref TTTRegion t2p) {
                if(T0 == T1) {
                    t1p = T2;
                    t2p = T3;
                } else if(T0 == T2) {
                    t1p = T1;
                    t2p = T3;
                } else if(T0 == T3) {
                    t1p = T2;
                    t2p = T1;
                }
            }
        }
    }
}
