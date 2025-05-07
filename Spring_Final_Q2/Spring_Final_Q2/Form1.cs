using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spring_Final_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Shift_Click(object sender, EventArgs e)
        {
            char letter = char.Parse(tbx_Letter.Text);
            int shift = int.Parse(tbx_Number.Text);

            int charValue = (char)letter - 'a';
            int shiftedValue = (charValue + shift) % 26;

            lbl_Result.Text= ("Shifted letter: " + (char)(shiftedValue + 'a'));

        }
    }
}
