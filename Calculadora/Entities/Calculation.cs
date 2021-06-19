using System;
using System.Windows.Forms;

namespace Calculadora.Entities
{
    class Calculation
    {
        protected static string Num1 { get; set; }
        protected static string Num2 { get; set; }
        protected static string Output { get; set; }
        protected static int Operation { get; set; }

        public static void EqualBt(TextBox txbResult, TextBox txbOut, Button btn)
        {
            var Result = 0.0;
            Num2 = txbOut.Text;
            switch (Operation)
            {
                case 1:
                    Result = double.Parse(Num1) + double.Parse(Num2);
                    break;
                case 2:
                    Result = double.Parse(Num1) - double.Parse(Num2);
                    break;
                case 3:
                    Result = double.Parse(Num1) * double.Parse(Num2);
                    break;
                case 4:
                    Result = double.Parse(Num1) / double.Parse(Num2);
                    break;
            }
            var res = Math.Abs(Result) - Result;
            if (res == 0)
            {
                NumPad_Click.Write(btn, Result.ToString());
            }
            else if (res.ToString().Length > 14)
            {
                NumPad_Click.Write(btn, Result.ToString("F14"));
            }
            else
            {
                string len = res.ToString().Length.ToString();
                string fLength = "F" + len;
                NumPad_Click.Write(btn, Result.ToString(fLength));
            }
            NumPad_Click.FontLenght();
        }

    }
}
