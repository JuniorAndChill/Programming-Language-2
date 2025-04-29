using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomCountrySelector
{
    public partial class Random_Country_Gen : Form
    {
        Random randGen = new Random();
        public Random_Country_Gen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            var count = cbx_Country.Items.Count;
            int randomNum1 = randGen.Next(1, count);
            lbl_Result.Text = lbx_Country.Items[randomNum1].ToString();
            lbl_Result.Visible = true;
        }

        private void lbx_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Result.Text = lbx_Country.SelectedItem.ToString();
            lbl_Result.Visible = true;
        }

        private void lbl_Result_Click(object sender, EventArgs e)
        {

        }

        private void cbx_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Result.Text = cbx_Country.SelectedItem.ToString();
            lbl_Result.Visible = true;
        }

        private void tbx_Entry_TextChanged(object sender, EventArgs e)
        {
            lbl_Result.Text = tbx_Entry.Text;
            lbl_Result.Visible = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            cbx_Country.Items.Add(tbx_Entry.Text);
            lbx_Country.Items.Add(tbx_Entry.Text);

        }
    }
}
