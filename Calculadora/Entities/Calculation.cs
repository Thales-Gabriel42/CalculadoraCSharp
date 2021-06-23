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

        public static void Calculate(TextBox txbResult, TextBox txbOut, Button btn)
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
            WriteResult(btn, Result);
        }

        protected static void WriteResult(Button btn, double result)
        {

            if (result.ToString().Length > 16)
            {
                NumPad_Click.Write(btn, result.ToString("F16"));
                NumPad_Click.ScreenNumber = result.ToString("F16");
            }
            else
            {
                NumPad_Click.Write(btn, result.ToString());
                NumPad_Click.ScreenNumber = result.ToString();
            }
            NumPad_Click.FontSizeVerification();
        }

    }
}
