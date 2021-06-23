using System;
using Calculadora.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmPrincipal : Form
    {
        private NumPad_Click np;
        public frmPrincipal()
        {
            InitializeComponent();
             np = new NumPad_Click(txbOutput, txbResult);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            NumPad_Click.Write(btnZero);
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            NumPad_Click.Write(btnOne);
            
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            NumPad_Click.Write(btnTwo);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            NumPad_Click.Write(btnThree);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            NumPad_Click.Write(btnFour);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            NumPad_Click.Write(btnFive);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            NumPad_Click.Write(btnSix);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            NumPad_Click.Write(btnSeven);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            NumPad_Click.Write(btnEight);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            NumPad_Click.Write(btnNine);
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            NumPad_Click.Backspace();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calculation.Calculate(txbResult, txbOutput, btnEqual);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            NumPad_Click.Calculate(btnPlus);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            NumPad_Click.Calculate(btnMinus);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            NumPad_Click.Calculate(btnMultiply);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            NumPad_Click.Calculate(btnDivide);
        }

        private void btnChangeSignal_Click(object sender, EventArgs e)
        {
            NumPad_Click.ChangeSignal();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            NumPad_Click.ClearAll();
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            NumPad_Click.Write(btnComma);
        }
    }
}
