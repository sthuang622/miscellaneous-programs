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
    public enum eTriangleForumla { AAS, ASA, SAS, SSA, SSS }

    public partial class Triangle : Form {
        public Triangle() {
            InitializeComponent();
        }

        //SIDES
        void AInput_ValueChanged(object sender, EventArgs e) {
            ErrorChecker();
        }
        void BInput_ValueChanged(object sender, EventArgs e) {
            ErrorChecker();
        }
        void CInput_ValueChanged(object sender, EventArgs e) {
            ErrorChecker();
        }


        //ANGLES
        void aAInput_ValueChanged(object sender, EventArgs e) {
            ErrorChecker();
        }
        void aBInput_ValueChanged(object sender, EventArgs e) {
            ErrorChecker();
        }
        void aCInput_ValueChanged(object sender, EventArgs e) {
            ErrorChecker();
        }



        void ErrorChecker() {

            int AngleTotal = (int)(aAInput.Value + aBInput.Value + aCInput.Value);

            //AngleChecker
            if(AngleTotal > 180) {
                if(!ErrorMessages.Contains(ErrorMessageOver180)) {
                    ErrorMessages.Add(ErrorMessageOver180);
                }
            } else {
                if(ErrorMessages.Contains(ErrorMessageOver180)) {
                    ErrorMessages.Remove(ErrorMessageOver180);
                }
            }
            if(aAInput.Value > 0 && aBInput.Value > 0 && aCInput.Value > 0) {
                if(!ErrorMessages.Contains(ErrorMessage3Angles)) {
                    ErrorMessages.Add(ErrorMessage3Angles);
                }
            } else {
                if(ErrorMessages.Contains(ErrorMessage3Angles)) {
                    ErrorMessages.Remove(ErrorMessage3Angles);
                }

            }

            //SideChecker
            if(AInput.Value == 0 && BInput.Value == 0 && CInput.Value == 0) {
                if(!ErrorMessages.Contains(ErrorMessageNeed1Side)) {
                    ErrorMessages.Add(ErrorMessageNeed1Side);
                }
            } else {
                if(ErrorMessages.Contains(ErrorMessageNeed1Side)) {
                    ErrorMessages.Remove(ErrorMessageNeed1Side);
                }
            }

            //AllChecker
            Has3Values();

            ErrorMessageOutput();

            //enable calculationbutton
            EnableCalButton();
        }

        void Has3Values() {
            int Count = 0;
            if(CInput.Value > 0) { Count++; }
            if(AInput.Value > 0) { Count++; }
            if(BInput.Value > 0) { Count++; }
            if(aAInput.Value > 0) { Count++; }
            if(aBInput.Value > 0) { Count++; }
            if(aCInput.Value > 0) { Count++; }

            if(Count == 3) {
                if(ErrorMessages.Contains(ErrorMessageNeed3Values)) {
                    ErrorMessages.Remove(ErrorMessageNeed3Values);
                }
            } else {
                if(!ErrorMessages.Contains(ErrorMessageNeed3Values)) {
                    ErrorMessages.Add(ErrorMessageNeed3Values);
                }
            }
        }
        void EnableCalButton() {
            if(ErrorMessages.Count > 0) {
                CalculateButton.Enabled = false;
            } else { CalculateButton.Enabled = true; }
        }


        //ERROR MESSAGES
        string ErrorMessageOver180 = "Angles Combined Cannot be over 180.";
        string ErrorMessage3Angles = "Cannot have 3 Angle. Please reset one to 0.";
        string ErrorMessageNeed1Side = "Must have 1 Side.";
        string ErrorMessageNeed3Values = "Need 3 Values.";
        List<string>ErrorMessages = new List<string>();

        void ErrorMessageOutput() {
            ErrorTextField.Text = "";
            if(ErrorMessages.Count > 0) {
                foreach(string child in ErrorMessages) {
                    ErrorTextField.Text += child + "\n\n";
                }
            } else {
                ErrorTextField.Text = "Nothing";
            }
        }


        //Calculation
        private void CalculateButton_Click(object sender, EventArgs e) {

            try {
                if(AValue > 0 && BValue > 0 && CValue > 0) {
                    AllSideInputCalc();
                } else if(AValue > 0) {
                    AInputCalc();
                } else if(BValue > 0) {
                    BInputCalc();
                } else if(CValue > 0) {
                    CInputCalc();
                }
                ErrorTextField.Text = "Calculated";
            } catch {
                ErrorTextField.Text = "Values cannot create a Triangle";
            }


        }

        decimal AValue { get { return AInput.Value; } set { AInput.Value = value; } }
        decimal BValue { get { return BInput.Value; } set { BInput.Value = value; } }
        decimal CValue { get { return CInput.Value; } set { CInput.Value = value; } }
        decimal aAValue { get { return aAInput.Value; } set { aAInput.Value = value; } }
        decimal aBValue { get { return aBInput.Value; } set { aBInput.Value = value; } }
        decimal aCValue { get { return aCInput.Value; } set { aCInput.Value = value; } }



        void AllSideInputCalc() {
            aCValue = LawOfCosAngle(AValue, BValue, CValue);
            aAValue = LawOfCosAngle(CValue, BValue, AValue);
            aBValue = LawOfCosAngle(AValue, CValue, BValue);
        }
        void AInputCalc() {
            if(BValue > 0) {
                if(aAValue > 0) {
                    //has av, bv, aav
                    //solve cv, abv, acv

                    aBValue = LawOfSinAngle(BValue, AValue, aAValue);
                    aCValue = AAACalc(aAValue,aBValue);
                    CValue = LawOfCosSide(AValue, BValue, aCValue);

                } else if(aBValue > 0) {
                    //has av, bv, abv
                    //solve cv, aav, acv

                    aAValue = LawOfSinAngle(AValue, BValue, aBValue);
                    aCValue = AAACalc(aAValue, aBValue);
                    CValue = LawOfCosSide(AValue, BValue, aCValue);


                } else if(aCValue > 0) {
                    //has av, bv, acv
                    //solve cv, aav, abv


                    CValue = LawOfCosSide(AValue, BValue, aCValue);
                    aAValue = LawOfCosAngle(CValue, BValue, AValue);
                    aBValue = AAACalc(aAValue, aCValue);
                }
            } else if(CValue > 0) {
                if(aAValue > 0) {
                    //has av, cv, aav
                    //solve bv, abv, acv

                    aCValue = LawOfSinAngle(CValue, AValue, aAValue);
                    aBValue = AAACalc(aAValue, aCValue);
                    BValue = LawOfSinSide(aBValue, AValue, aAValue);
                } else if(aBValue > 0) {
                    //has av, cv, abv
                    //solve bv, aav, acv

                    BValue = LawOfCosSide(AValue, CValue, aBValue);
                    aAValue = LawOfSinAngle(AValue, BValue, aBValue);
                    aCValue = AAACalc(aAValue, aBValue);


                } else if(aCValue > 0) {
                    //has av, cv, acv
                    //solve bv, aav, abv

                    aAValue = LawOfSinAngle(AValue, CValue, aCValue);
                    aBValue = AAACalc(aAValue, aCValue);
                    BValue = LawOfSinSide(aBValue, AValue, aAValue);
                }

            } else {//2 angles
                if(aAValue > 0) {
                    if(aBValue > 0) {
                        //has aav, abv, av
                        //solve bv, cv, acv


                        BValue = LawOfSinSide(aBValue, AValue, aAValue);
                        aCValue = AAACalc(aAValue, aBValue);
                        CValue = LawOfSinSide(aCValue, AValue, aAValue); ;
                    } else if(aCValue > 0) {
                        //has av, aav, acv
                        //solve bv, cv, abv

                        CValue = LawOfSinSide(aCValue, AValue, aAValue);
                        aBValue = AAACalc(aAValue, aCValue);
                        BValue = LawOfSinSide(aBValue, AValue, aAValue);
                    }
                } else if(aBValue > 0) {/*
                    if(aAValue > 0) {
                        //has av, aav, abv
                        //solve bv, cv, acv

                        aCValue = AAACalc(aAValue, aBValue);
                        BValue = LawOfSinSide(aBValue, AValue, aAValue);
                        CValue = LawOfSinSide(aCValue, AValue, aAValue);
                    } else */if(aCValue > 0) {
                        //has av, acv, abv
                        //solve bv, cv, aav

                        aAValue = AAACalc(aCValue, aBValue);
                        BValue = LawOfSinSide(aBValue, AValue, aAValue);
                        CValue = LawOfSinSide(aCValue, AValue, aAValue);

                    }
                } /*else if(aCValue > 0) {
                    if(aAValue > 0) {
                        //has av, aav, acv
                        //solve bv, cv, abv

                        aBValue = AAACalc(aAValue, aCValue);
                        BValue = LawOfSinSide(aBValue, AValue, aAValue);
                        CValue = LawOfSinSide(aCValue, AValue, aAValue);
                    } else if(aBValue > 0) {
                        //has av, abv, acv
                        //solve bv, cv, aav

                        aAValue = AAACalc(aBValue, aCValue);
                        BValue = LawOfSinSide(aBValue, AValue, aAValue);
                        CValue = LawOfSinSide(aCValue, AValue, aAValue);
                    }

                }*/
            }
        }
        void BInputCalc() {/*
            if (AValue > 0) {
                if(aAValue > 0) {
                    //has bv, av, aav
                    //solve cv, abv, acv

                    aBValue = LawOfSinAngle(BValue, AValue, aAValue);
                    aCValue = AAACalc(aAValue, aBValue);
                    CValue = LawOfSinSide(aCValue, AValue, aAValue);
                } else if(aBValue > 0) {
                    //has bv, av, abv
                    //solve cv, aav, acv

                    aAValue = LawOfSinAngle(AValue, BValue, aBValue);
                    aCValue = AAACalc(aAValue, aBValue);
                    CValue = LawOfSinSide(aCValue, AValue, aAValue);
                } else if(aCValue > 0) {
                    //has bv, av, acv
                    //solve cv, aav, abv

                    CValue = LawOfCosSide(AValue, BValue, aCValue);
                    aAValue = LawOfSinAngle(AValue, CValue, aCValue);
                    aBValue = AAACalc(aAValue, aCValue);
                }
            } else */ 
            if (CValue > 0) {
                if(aAValue > 0) {
                    //has bv, cv, aav
                    //solve av, abv, acv

                    AValue = LawOfCosSide(BValue, CValue, aAValue);
                    aBValue = LawOfSinAngle(BValue, AValue, aAValue);
                    aCValue = AAACalc(aAValue, aBValue);
                } else if(aBValue > 0) {
                    //has bv, cv, abv
                    //solve av, aav, acv

                    aCValue = LawOfSinAngle(CValue, BValue, aBValue);
                    aAValue = AAACalc(aBValue, aCValue);
                    AValue = LawOfSinSide(aAValue, CValue, aCValue);
                } else if(aCValue > 0) {
                    //has bv, cv, acv
                    //solve av, aav, abv

                    aBValue = LawOfSinAngle(BValue, CValue, aCValue);
                    aAValue = AAACalc(aBValue, aCValue);
                    AValue = LawOfSinSide(aAValue, BValue, aBValue);
                }
            } else { //2 angles
                if(aAValue > 0) {
                    if(aBValue > 0) {
                        //has bv, aav, abv
                        //solve av, cv, acv

                        aCValue = AAACalc(aAValue, aBValue);
                        AValue = LawOfSinSide(aAValue, BValue, aBValue);
                        CValue = LawOfSinSide(aCValue, AValue, aAValue);
                    } else if(aCValue > 0) {
                        //has bv, aav, acv
                        //solve av, cv, abv

                        aBValue = AAACalc(aAValue, aCValue);
                        AValue = LawOfSinSide(aAValue, BValue, aBValue);
                        CValue = LawOfSinSide(aCValue, AValue, aAValue);
                    }
                } else if(aBValue > 0) {/*
                    if(aAValue > 0) {
                        //has bv, aav, abv
                        //solve av, cv, acv

                        aCValue = AAACalc(aAValue, aBValue);
                        AValue = LawOfSinSide(aAValue, BValue, aBValue);
                        CValue = LawOfSinSide(aCValue, AValue, aAValue);

                    } else*/ if(aCValue > 0) {
                        ///has bv, abv, acv
                        //solve av, cv, aav

                        aAValue = AAACalc(aBValue, aCValue);
                        AValue = LawOfSinSide(aAValue, BValue, aBValue);
                        CValue = LawOfSinSide(aCValue, AValue, aAValue);
                    }
                }/* else if(aCValue > 0) {
                    if(aAValue > 0) {
                        //has bv, aav, acv
                        //solve av, cv, abv

                        aBValue = AAACalc(aAValue, aCValue);
                        AValue = LawOfSinSide(aAValue, BValue, aBValue);
                        CValue = LawOfSinSide(aCValue, AValue, aAValue);
                    } else if(aBValue > 0) {
                        //has bv, abv, acv
                        //solve av, cv, aav

                        aAValue = AAACalc(aBValue, aCValue);
                        AValue = LawOfSinSide(aAValue, BValue, aBValue);
                        CValue = LawOfSinSide(aCValue, AValue, aAValue);
                    }
                }*/
            }
        }
    
        void CInputCalc() {/*
            if(AValue > 0) {
                if(aAValue > 0) {
                    //has cv, av, aav
                    //solve bv, abv, acv

                    aCValue = LawOfSinAngle(CValue, AValue, aAValue);
                    aBValue = AAACalc(aAValue, aCValue);
                    BValue = LawOfSinSide(BValue, AValue, aAValue);

                } else if(aBValue > 0) {
                    //has cv, av, abv
                    //solve bv, aav, acv

                    BValue = LawOfCosSide(AValue, CValue, aBValue);
                    aCValue = LawOfSinSide(CValue, BValue, aBValue);
                    aAValue = AAACalc(aCValue, aBValue);
                } else if(aCValue > 0) {
                    //has cv, av, acv
                    //solve bv, aav, abv


                    aAValue = LawOfSinAngle(AValue, CValue, aCValue);
                    aBValue = AAACalc(aAValue, aCValue);
                    BValue = LawOfSinSide(aBValue, AValue, aAValue);
                }
            } else if(BValue > 0) {
                if(aAValue > 0) {
                    //has cv, bv, aav
                    //solve av, abv, acv

                    AValue = LawOfCosSide(CValue, BValue, aAValue);
                    aBValue = LawOfSinAngle(BValue, AValue, aAValue);
                    aCValue = AAACalc(aAValue, aBValue);
                } else if(aBValue > 0) {
                    //has cv, bv, abv
                    //solve av, aav, acv

                    aCValue = LawOfSinAngle(CValue, BValue, aBValue);
                    aAValue = AAACalc(aCValue, aBValue);
                    AValue = LawOfSinSide(aAValue, BValue, aBValue);
                } else if(aCValue > 0) {
                    //has cv, bv, acv
                    //solve av, aav, abv
                    aBValue = LawOfSinAngle(BValue, CValue, aCValue);
                    aAValue = AAACalc(aBValue, aCValue);
                    AValue = LawOfSinSide(aAValue, BValue, aBValue);
                }
            } else {*/ //angle
                if(aAValue > 0) {
                    if(aBValue > 0) {
                        //has cv, aav, abv
                        //solve av, bv, acv

                        aCValue = AAACalc(aAValue, aBValue);
                        AValue = LawOfSinSide(aAValue, CValue, aCValue);
                        BValue = LawOfSinSide(aBValue, CValue, aCValue);
                    } else if(aCValue > 0) {
                        //has cv,  aav, acv
                        //solve av, bv, abv

                        aBValue = AAACalc(aAValue, aCValue);
                        AValue = LawOfSinSide(aAValue, CValue, aCValue);
                        BValue = LawOfSinSide(aBValue, CValue, aCValue);
                    }
                } else if(aBValue > 0) {/*
                    if(aAValue > 0) {
                        //has cv, aav, abv
                        //solve av, bv, acv

                        aCValue = AAACalc(aAValue, aBValue);
                        AValue = LawOfSinSide(aAValue, CValue, aCValue);
                        BValue = LawOfSinSide(aBValue, CValue, aCValue);
                    } else */if(aCValue > 0) {
                        //has cv,  abv, acv
                        //solve av, bv, aav

                        aAValue = AAACalc(aBValue, aCValue);
                        AValue = LawOfSinSide(aAValue, CValue, aCValue);
                        BValue = LawOfSinSide(aBValue, CValue, aCValue);
                    }
                } /*else if(aCValue > 0) {
                    if(aAValue > 0) {
                        //has cv, aav, acv
                        //solve av, bv, abv

                        aBValue = AAACalc(aAValue, aCValue);
                        AValue = LawOfSinSide(aAValue, CValue, aCValue);
                        BValue = LawOfSinSide(aBValue, CValue, aCValue);
                    } else if(aBValue > 0) {
                        //has cv, abv, acv
                        //solve av, bv, aav

                        aAValue = AAACalc(aBValue, aCValue);
                        AValue = LawOfSinSide(aAValue, CValue, aCValue);
                        BValue = LawOfSinSide(aBValue, CValue, aCValue);
                    }
                }
            }*/
        }



        decimal LawOfSinSide(decimal angleA, decimal sideB, decimal angleB) {
            double aA = (double)angleA * Math.PI / 180;
            double sB = (double)sideB;
            double aB = (double)angleB * Math.PI / 180;

            return (decimal)(Math.Sin(aA)*(sB/Math.Sin(aB)));
        }
        decimal LawOfSinAngle(decimal sideA, decimal sideB, decimal angleB) {
            double sA = (double)sideA;
            double sB = (double)sideB;
            double aB = (double)angleB * Math.PI / 180;

            return (decimal)((Math.Asin ((Math.Sin(aB) / sB )* sA )) * 180 / Math.PI); 
        }
        decimal LawOfCosSide(decimal sideA, decimal sideB, decimal angleC) {
            double sA = (double)sideA;
            double sB = (double)sideB;
            double aC = (double)angleC  * Math.PI / 180;

            return (decimal)(Math.Sqrt(sA*sA + sB*sB - 2*sA*sB *Math.Cos(aC)));
        }
        decimal LawOfCosAngle(decimal sideA, decimal sideB, decimal sideC) {
            double sA = (double)sideA;
            double sB = (double)sideB;
            double sC = (double)sideC;

            return (decimal)((Math.Acos(((sA*sA) + (sB*sB) - (sC*sC)) / (2*sA*sB))) * 180 / Math.PI);
        }


        decimal AAACalc(decimal angle1, decimal angle2) {
            return (decimal)(180 - (float)angle1 - (float)angle2);
        }







        //Others
        private void BInput_Click(object sender, EventArgs e) {
            //BInput.ResetText();
        }

        private void aCInput_Click(object sender, EventArgs e) {
            //aCInput.ResetText();
        }

        private void aAInput_Click(object sender, EventArgs e) {
            //aAInput.ResetText();
        }

        private void CInput_Click(object sender, EventArgs e) {
            //CInput.ResetText();
        }

        private void AInput_Click(object sender, EventArgs e) {
            //AInput.ResetText();
        }

        private void aBInput_Click(object sender, EventArgs e) {
            //aBInput.ResetText();
        }

        

        

        

        private void aALeave(object sender, EventArgs e) {
        }
        private void aBLeave(object sender, EventArgs e) {
        }
        private void aCLeave(object sender, EventArgs e) {
        }
        private void CLeave(object sender, EventArgs e) {
        }

        private void Bleave(object sender, EventArgs e) {
        }

        private void ALeave(object sender, EventArgs e) {
        }

        private void Reset_Click(object sender, EventArgs e) {
            ResetField();
        }

        void ResetField() {
            AValue = 0;
            BValue = 0;
            CValue = 0;
            aAValue = 0;
            aBValue = 0;
            aCValue = 0;
        }
    }
}
