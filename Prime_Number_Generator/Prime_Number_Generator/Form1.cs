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
            //Input validation. Also parsing input to output "limit" variable for all operations
            if (int.TryParse(txb_Limit.Text, out int limit))
            {
                //determine values less than 2 and returning an error
                if (limit < 2)
                {
                    lbl_Result.Text = "Limit must be 2 or greater.";
                    return;
                }
                //creating a list of prime numbers and updating the results on screen. Change visibility to display
                List<int> primeNumbers = GeneratePrimes(limit);

                lbl_Result.Text = string.Join(", ", primeNumbers);
                lbl_Result.Visible = true;
            }
            else
            {
                //other end of validation. Checks for a number input and guides user for error correction
                lbl_Result.Text = "Invalid input. Please enter a valid number.";
                lbl_Result.Visible = true;
            }
        }
        //using the limit value from above, index all prime numbers in list
        private List<int> GeneratePrimes(int limit)
        {
            //ends loop if value is too low
            if (limit < 2)
            {
                return new List<int>();
            }
            //creates temp list for functions
            List<int> primes = new List<int>();

            //comparison list of bools to check against other list 
            bool[] isPrime = new bool[limit + 1];

            //initializing array as all true "isPrime"
            for (int i = 2; i <= limit; i++)
            {
                isPrime[i] = true;
            }
            //counts while skipping known non-primes (also x 1/2)
            for (int p = 2; p * p <= limit; p++)
            {
                //loop to verify that value actually is bool
                if (isPrime[p])
                {
                    //loop to follow the target bools identified by "p"
                    for (int i = p * p; i <= limit; i += p)
                    {
                        //eliminates non-prime numbers
                        isPrime[i] = false;
                    }
                }
            }
            //loop to append primes list
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
