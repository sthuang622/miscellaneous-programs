using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_is_Hard {
    public partial class TicTacToe : Form {
        public static class TicTacToeAI {

            public static int WinRecord, LoseRecord, TieRecord;
            public static Label RecordLabel;
            public static eSymbol PlayerSymbol;
            public static eSymbol CompSymbol {
                get {
                    if(PlayerSymbol == eSymbol.X) {
                        return eSymbol.O;
                    } else {
                        return eSymbol.X;
                    }
                }
            }
            public static int CompDifficulity = 0;
            static bool PlayerPlayOrder; // set here to false to play 1st. true means it plays 1st, but it is changed at teh StartMatch()
            static bool PlayOrder;
            static Random rng;
            public static TTTRegion A1, A2, A3,
                                    B1, B2, B3,
                                    C1, C2, C3;
            public static List<TTTRegion> Regions;
            public static List<WinCon> WinCons;

            public static Label debugger;
            public static void StartScript(Button a1, Button a2, Button a3,
                                            Button b1, Button b2, Button b3,
                                            Button c1, Button c2, Button c3, Label deb, Label rec) {
                RecordLabel = rec;
                WinRecord = 0;
                LoseRecord = 0;
                TieRecord = 0;
                rng = new Random();
                WinCons = new List<WinCon>();
                WinningMove = null;
                CompPicksPriority = new List<TTTRegion>();
                CompPicks = new List<TTTRegion>();
                SetupRegions(a1, a2, a3, b1, b2, b3, c1, c2, c3);
                SetupWinCon();
                debugger = deb;
                UpdateRecord();
                StartMatch();
                SetupList();

            }
            static void SetupRegions(Button a1, Button a2, Button a3,
                                Button b1, Button b2, Button b3,
                                Button c1, Button c2, Button c3) {
                A1 = new TTTRegion(a1, 2, "A1");
                A2 = new TTTRegion(a2, 1, "A2");
                A3 = new TTTRegion(a3, 2, "A3");
                B1 = new TTTRegion(b1, 1, "B1");
                B2 = new TTTRegion(b2, 1.5, "B2");
                B3 = new TTTRegion(b3, 1, "B3");
                C1 = new TTTRegion(c1, 2, "C1");
                C2 = new TTTRegion(c2, 1, "C2");
                C3 = new TTTRegion(c3, 2, "C3");
            }
            static void SetupList() {
                Regions = new List<TTTRegion>() { A1, A2, A3,
                                                    B1, B2, B3,
                                                    C1, C2, C3 };
            }
            static void SetupWinCon() {
                WinCons.Add(new WinCon(A1, A2, A3));
                WinCons.Add(new WinCon(B1, B2, B3));
                WinCons.Add(new WinCon(C1, C2, C3));

                WinCons.Add(new WinCon(A1, B1, C1));
                WinCons.Add(new WinCon(A2, B2, C2));
                WinCons.Add(new WinCon(A3, B3, C3));

                WinCons.Add(new WinCon(A1, B2, C3));
                WinCons.Add(new WinCon(A3, B2, C1));
            }

            static void StartMatch() {
                PlayerPlayOrder = !PlayerPlayOrder;
                PlayOrder = false;
                Run();
            }

            static void Run() {
                PlayOrder = !PlayOrder;
                if(PlayerPlayOrder != PlayOrder) {
                    ComputerInput();
                }

            }



            public static void ChangeSetting() {
                foreach(TTTRegion child in Regions) {
                    if(child.owner != eSymbol.None) {
                        PlayerPlayOrder = false;
                        ResetBoard();
                    }
                }
            }

            public static TTTRegion WinningMove;
            public static List<TTTRegion> CompPicksPriority;
            public static List<TTTRegion> CompPicks;
            public static void ComputerInput() {
                WinningMove = null;
                CompPicks = new List<TTTRegion>();
                CompPicksPriority = new List<TTTRegion>();
                WinningMoveCheck();
                if(CompPicksPriority.Count == 0) {
                    switch(CompDifficulity) {
                        case 0:
                            ComputerInputRandom();
                            break;
                        case 1:
                            ComputerInputCalculated();
                            break;
                        default:
                            ComputerInputRandom();
                            break;
                    }
                }
                CompFinalPick();
            }
            static void CompFinalPick() {
                if(WinningMove != null) { Input(CompSymbol, WinningMove); }
                else if(CompPicksPriority.Count > 0) {
                    Input(CompSymbol, CompPicksPriority[rng.Next(CompPicksPriority.Count)]);
                } else if(CompPicks.Count > 0) {
                    Input(CompSymbol, CompPicks[rng.Next(CompPicks.Count)]);
                }
            }
            static void ComputerInputRandom() {

                foreach(TTTRegion child in Regions) {
                    if(child.owner == eSymbol.None) {
                        //child.CalcValue(CompSymbol);
                        CompPicks.Add(child);
                    }
                }

            }
            static void ComputerInputCalculated() {
                CompPicks = new List<TTTRegion>();

                
                if(TicTacToeAI.CompPicksPriority.Count == 0) {
                    bool firstmove = true;
                    foreach(TTTRegion child in Regions) {
                        if(child.owner != eSymbol.None) {
                            firstmove = false;
                            break;
                        }
                    }
                    if(!firstmove) {
                        foreach(TTTRegion child in Regions) {
                            if(child.owner == eSymbol.None) {
                                child.CalcValue(CompSymbol);

                            }
                        }
                    } else {
                        A1.CalcValue(CompSymbol);
                        A3.CalcValue(CompSymbol);
                        C1.CalcValue(CompSymbol);
                        C3.CalcValue(CompSymbol);

                    }
                }
            }
            static void WinningMoveCheck() {
                foreach(TTTRegion child in Regions) {
                    child.WinningMoveCheck(CompSymbol);

                }
            }

            public static void ResetBoard() {
                foreach(TTTRegion child in Regions) {
                    child.Reset();
                }
                debugger.Text = "debugger";
                StartMatch();
            }
            public static TTTRegion Get(eRegion _region) {

                switch(_region) {
                    case eRegion.A1: return A1;
                    case eRegion.A2: return A2;
                    case eRegion.A3: return A3;

                    case eRegion.B1: return B1;
                    case eRegion.B2: return B2;
                    case eRegion.B3: return B3;

                    case eRegion.C1: return C1;
                    case eRegion.C2: return C2;
                    case eRegion.C3: return C3;

                    default:
                        return A1;
                }
            }
            public static void Input(eSymbol _symbol, eRegion _region) {
                Input(_symbol, Get(_region));
            }
            public static void Input(eSymbol _symbol, TTTRegion _region) {
                _region.SetOwner(_symbol);

                if(_region.WinChecker()) {
                    EndScreen(_symbol);
                } else if(TieChecker()) {
                    EndScreen(eSymbol.None);
                } else {
                    Run();
                }
            }

            static void EndScreen(eSymbol _symbol) {
                foreach(TTTRegion child in Regions) {
                    child.button.Enabled = false;
                }

                if(_symbol == eSymbol.None) {
                    PlayerTie();
                } else if (_symbol == PlayerSymbol) {
                    PlayerWin();
                }   else if (_symbol == CompSymbol) {
                    PlayerLose();
                }
                UpdateRecord();
            }

            static void UpdateRecord() {
                RecordLabel.Text = "Record\n" +
                    "Win: "+WinRecord+"     Tie: "+TieRecord+"     Lost: "+LoseRecord;
            }
            /*
            static bool EndChecker() {
                if(WinChecker() != eSymbol.None) { return false; }

                if(TieChecker()) { return false; }
                return true;
            }*/
            static void PlayerWin() {
                debugger.Text = "You Win!";
                WinRecord++;
            }
            static void PlayerLose() {
                debugger.Text = "You Lose!";
                LoseRecord++;
            }
            static void PlayerTie() {
                debugger.Text = "TIE!!!";
                TieRecord++;
            }
            
            
            /*
            static eSymbol WinChecker() {
                foreach(WinCon child in WinCons) {
                    if(child.owner != eSymbol.None) {
                        if(child.owner == PlayerSymbol) { PlayerWin(); } else { PlayerLose(); }
                        return child.owner;
                    }
                }
                return eSymbol.None;
            }*/
            static bool TieChecker() {
                foreach(TTTRegion child in Regions) {
                    if(child.owner == eSymbol.None) {
                        return false;
                    }
                }
                    return true;
            }
        }
    }
}
