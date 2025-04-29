using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Age_Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime birth = dtp_DOB.Value.Date;
                DateTime death = dtp_DOD.Value.Date;

                if (birth > death)
                {
                    MessageBox.Show("Birth date cannot be after death date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int age = death.Year - birth.Year;

                // Adjust if birthday hasn't occurred in the death year
                if (birth.Month > death.Month || (birth.Month == death.Month && birth.Day > death.Day))
                {
                    age--;
                }

                lbl_Result.Text = age.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid date format. Please enter valid dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
