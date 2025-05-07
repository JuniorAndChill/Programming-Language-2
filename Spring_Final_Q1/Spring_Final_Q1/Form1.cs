using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spring_Final_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_result_Click(object sender, EventArgs e)
        {

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            int limit = 1000;
            List<int> matches = new List<int>();
            int n1 = Convert.ToInt32(txb_n1.Text);
            int n2 = Convert.ToInt32(txb_n2.Text);
            //int total = 0;
            for (int i = 0; i < limit; i++)
            {
                if ((i % 10) == n1 || (i/10 %10) == n1 || (i/100 % 10) == n1 ||(i % 10) == n2 || (i / 10 % 10) == n2 || (i / 100 % 10) == n2)
                {
                    matches.Add(i);
                }

            }
            lbl_result.Text = string.Join(", ", matches);
            lbl_result.Visible = true;
            string fileName = "results.txt";
            string filePath = Path.Combine(Application.StartupPath, fileName);
            try
            {
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write($"Results: {lbl_result}");
                sw.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                // Error message for error
                MessageBox.Show("Nope!");
            }
            StreamReader sr = new StreamReader(filePath);
            sr.Close();
        }
    }
}

// n1 % 10
// n1 /100%10