using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsCalculator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DanielTitle_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Input1.Text != "" && txt_Input2.Text != "")
            {
                int first = int.Parse(txt_Input1.Text);
                int second = int.Parse(txt_Input2.Text);
                int result = first + second;
                lbl_Result.Text = "\t\t" + result.ToString() + "\nThis is the way!";
                lbl_Result.Visible = true;
            }
            else
            {
                lbl_Result.Text = "No numbers there...";
            }

        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (txt_Input1.Text != "" && txt_Input2.Text != "")
            {
                int first = int.Parse(txt_Input1.Text);
                int second = int.Parse(txt_Input2.Text);
                int result = first - second;
                lbl_Result.Text = "\t\t" + result.ToString() + "\nThis is the way!";
                lbl_Result.Visible = true;
            }
            else
            {
                lbl_Result.Text = "No numbers there...";
            }


        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            if (txt_Input1.Text != "" && txt_Input2.Text != "")
            {
                int first = int.Parse(txt_Input1.Text);
                int second = int.Parse(txt_Input2.Text);
                int result = first * second;
                lbl_Result.Text = "\t\t" + result.ToString() + "\nThis is the way!";
                lbl_Result.Visible = true;
            }
            else
            {
                lbl_Result.Text = "No numbers there...";
            }


        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            if (txt_Input1.Text != "" && txt_Input2.Text != "")
            {
                int first = int.Parse(txt_Input1.Text);
                int second = int.Parse(txt_Input2.Text);
                int result = first / second;
                lbl_Result.Text = "\t\t" + result.ToString() + "\nThis is the way!";
                lbl_Result.Visible = true;
            }
            else
            {
                lbl_Result.Text = "No numbers there...";
            }


        }

        private void btn_Remainder_Click(object sender, EventArgs e)
        {
            if (txt_Input1.Text != "" && txt_Input2.Text != "")
            {
                int first = int.Parse(txt_Input1.Text);
                int second = int.Parse(txt_Input2.Text);
                int result = first % second;
                lbl_Result.Text = "\t\t" + result.ToString() + "\nThis is the way!";
                lbl_Result.Visible = true;
            }
            else
            {
                lbl_Result.Text = "No numbers there...";
            }


        }

        private void txt_Input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Input2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
