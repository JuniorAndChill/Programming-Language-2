using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compatibility_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gbx_Age_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Age_Click(object sender, EventArgs e)
        {
            if (rdb_Child.Checked == true)
            {
                bar_Progress.Increment(5);
            }
            if (rdb_Adult.Checked == true)
            {
                bar_Progress.Increment(10);
            }
            if (rdb_Senior.Checked == true)
            {
                bar_Progress.Increment(15);
            }
            if (bar_Progress.Value >= 100)
            {
                MessageBox.Show("100% Compatible!");
            }
        }

        private void gbx_Aura_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            if (rdb_Red.Checked == true)
            {
                gbx_Aura.ForeColor = Color.Red;
                bar_Progress.Increment(5);
            }
            if (rdb_Green.Checked == true)
            {
                gbx_Aura.ForeColor = Color.Green;
                bar_Progress.Increment(5);
            }
            if (rdb_Blue.Checked == true)
            {
                gbx_Aura.ForeColor = Color.Blue;
                bar_Progress.Increment(5);
            }
            else
            {
                MessageBox.Show("Please select a color");
            }
            if (bar_Progress.Value >= 100)
            {
                MessageBox.Show("100% Compatible!");
            }
        }

        private void gbx_Traits_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Traits_Click(object sender, EventArgs e)
        {
            foreach (var t in clb_Traits.Items)
            {
                if (clb_Traits.CheckedItems.Contains(t))
                {
                    bar_Progress.Increment(1);
                }
            }
            if (bar_Progress.Value >= 100)
            {
                MessageBox.Show("100% Compatible!");
            }
        }

        private void nud_Pets_ValueChanged(object sender, EventArgs e)
        {
            bar_Progress.Increment(1);
            if (bar_Progress.Value >= 100)
            {
                MessageBox.Show("100% Compatible!");
            }

        }

        private void bar_Progress_Click(object sender, EventArgs e)
        {

        }
    }
}
