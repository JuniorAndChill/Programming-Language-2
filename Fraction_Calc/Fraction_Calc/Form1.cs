using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Fraction frac1 = new Fraction(int.Parse(txt_Num1.Text), int.Parse(txt_Den1.Text));
                Fraction frac2 = new Fraction(int.Parse(txt_Num2.Text), int.Parse(txt_Den2.Text));
                Fraction result = frac1 + frac2;

                lbl_ResultN.Text = $"{result.Numerator}";
                lbl_ResultD.Text = $"{result.Denominator}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btn_Sub_Click(object sender, EventArgs e)
        {
            try
            {
                Fraction frac1 = new Fraction(int.Parse(txt_Num1.Text), int.Parse(txt_Den1.Text));
                Fraction frac2 = new Fraction(int.Parse(txt_Num2.Text), int.Parse(txt_Den2.Text));
                Fraction result = frac1 - frac2;

                lbl_ResultN.Text = $"{result.Numerator}";
                lbl_ResultD.Text = $"{result.Denominator}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btn_Mult_Click(object sender, EventArgs e)
        {
            try
            {
                Fraction frac1 = new Fraction(int.Parse(txt_Num1.Text), int.Parse(txt_Den1.Text));
                Fraction frac2 = new Fraction(int.Parse(txt_Num2.Text), int.Parse(txt_Den2.Text));
                Fraction result = frac1 * frac2;

                lbl_ResultN.Text = $"{result.Numerator}";
                lbl_ResultD.Text = $"{result.Denominator}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btn_Div_Click(object sender, EventArgs e)
        {
            try
            {
                Fraction frac1 = new Fraction(int.Parse(txt_Num1.Text), int.Parse(txt_Den1.Text));
                Fraction frac2 = new Fraction(int.Parse(txt_Num2.Text), int.Parse(txt_Den2.Text));
                Fraction result = frac1 / frac2;

                lbl_ResultN.Text = $"{result.Numerator}";
                lbl_ResultD.Text = $"{result.Denominator}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Numerator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator;
            int newDenominator = a.Denominator * b.Numerator;
            if(newDenominator == 0)
            {
                return new Fraction(0, 0);
            }
            else 
                return new Fraction(newNumerator, newDenominator);
        }
        private void Simplify()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}