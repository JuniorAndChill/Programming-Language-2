using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Number_Generator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_generate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txb_Limit.Text, out int limit))
            {
                if (limit < 2)
                {
                    lbl_Result.Text = "Limit must be 2 or greater.";
                    return;
                }
                List<int> primeNumbers = GeneratePrimes(limit);

                lbl_Result.Text = string.Join(", ", primeNumbers);
                lbl_Result.Visible = true;
            }
            else
            {
                lbl_Result.Text = "Invalid input. Please enter a valid number.";
                lbl_Result.Visible = true;
            }
        }
        private List<int> GeneratePrimes(int limit)
        {
            if (limit < 2)
            {
                return new List<int>();
            }
            List<int> primes = new List<int>();
            bool[] isPrime = new bool[limit + 1];
            for (int i = 2; i <= limit; i++)
            {
                isPrime[i] = true;
            }
            for (int p = 2; p * p <= limit; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= limit; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }
            for (int p = 2; p <= limit; p++)
            {
                if (isPrime[p])
                {
                    primes.Add(p);
                }
            }
            return primes;
        }
        private void txb_Limit_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbl_Result_Click(object sender, EventArgs e)
        {

        }
    }
}
