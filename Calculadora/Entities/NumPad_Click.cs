using System.Windows.Forms;

namespace Calculadora.Entities
{
    class NumPad_Click : Calculation
    {
        private static string ScreenNumber { get; set; } = "0";
        private static TextBox txbPrincipal { get; set; }
        private static TextBox txbResult { get; set; }
        protected static bool ResultInScreen { get; set; }
        protected static bool Calc { get; set; } = true;

        public NumPad_Click(TextBox txbOut, TextBox txbRes)
        {
            txbPrincipal = txbOut;
            txbResult = txbRes;
        }

        public static void Write(Button btn, string outp = "")
        {
            int ver = Verification(btn);
            FontLenght();
            if (ver == 1)
            {
                if (txbPrincipal.Text == ScreenNumber)
                {
                    txbPrincipal.Clear();
                    txbPrincipal.AppendText(btn.Text);
                }
                else
                {
                    txbPrincipal.AppendText(btn.Text);
                }
            }
            else if(ver == 2)
            {
                txbPrincipal.AppendText(btn.Text);
            }
            else if(ver == 3)
            {
                if (txbResult.TextLength == 0 && !Calc)
                {
                    txbResult.AppendText(outp + btn.Text);
                }
                else
                {
                    string text = txbPrincipal.Text;
                    txbPrincipal.Clear();
                    txbPrincipal.AppendText(outp);
                    txbResult.AppendText(text + btn.Text);
                    ScreenNumber = outp;
                    ResultInScreen = true;
                    Calc = true;
                }
            }
        }

        public static void Backspace()
        {
            FontLenght();
            if (!ResultInScreen)
            {
                if (txbPrincipal.TextLength == 1)
                {
                    txbPrincipal.Clear();
                    txbPrincipal.AppendText("0");
                    ScreenNumber = "0";
                }
                else
                {
                    int pos = txbPrincipal.TextLength;
                    string text = txbPrincipal.Text.Substring(0, pos - 1);
                    txbPrincipal.Clear();
                    txbPrincipal.Text = text;
                }
            }
            else
            {
                txbResult.Clear();
            }
        }

        public static void ClearAll()
        {
            txbPrincipal.Clear();
            txbResult.Clear();
            txbPrincipal.AppendText("0");
            ScreenNumber = "0";
        }

        public static void Calculate(Button btn)
        {
            string Output = txbPrincipal.Text;
            Calculation.Num1 = Output;
            ScreenNumber = Output;
            Calc = false;
            switch (btn.Text)
            {
                case "+":
                    Calculation.Operation = 1;
                    Write(btn, Output);
                    break;
                case "-":
                    Calculation.Operation = 2;
                    Write(btn, Output);
                    break;
                case "x":
                    Calculation.Operation = 3;
                    Write(btn, Output);
                    break;
                case "÷":
                    Calculation.Operation = 4;
                    Write(btn, Output);
                    break;
            }
        }

        public static void ChangeSignal()
        {
            int num = int.Parse(txbPrincipal.Text) * -1;
            txbPrincipal.Clear();
            txbPrincipal.AppendText(num.ToString());
        }

        private static int Verification(Button btn)
        {
            try
            {
                int a = int.Parse(btn.Text);
                return 1;
            }
            catch
            {
                if(btn.Text == ",")
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        public static void FontLenght(double len = 0)
        {
            if (txbPrincipal.TextLength < 13)
            {
                txbPrincipal.Font = new System.Drawing.Font("Segoe UI", 33, System.Drawing.FontStyle.Bold);
            }
            else
            {
                txbPrincipal.Font = new System.Drawing.Font("Segoe UI", 25, System.Drawing.FontStyle.Bold);
            }
        }
    }
}
