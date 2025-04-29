using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction_Decimal_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            if (nud_Denominator.Value > 0)
            {
                lbl_Result.Text = Convert.ToString(nud_Numerator.Value / nud_Denominator.Value);
                lbl_Result.Visible = true;
            }
            else
            {
                MessageBox.Show("Can't divide by 0!");
            }
        }

        private void nud_Numerator_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nud_Denominator_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
