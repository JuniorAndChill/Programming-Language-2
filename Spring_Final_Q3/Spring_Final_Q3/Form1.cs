using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Spring_Final_Q3
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int racoons = 0; 
        int rhinos =0;
        int starfish = 0;
        int weasels = 0; 
        int jaguar = 0;

        public Form1()
        {
            InitializeComponent();
            LogImageDisplay(racoons,rhinos,starfish,weasels,jaguar);
        }

        private void btn_Rand_Click(object sender, EventArgs e)
        {
            int roll = random.Next(0, 5) + 1;
            lbl_Result.Visible = true;
            //int racoons, rhinos, starfish, weasels, jaguar = 0;
            if (roll == 1)
            {
                pbx_Animal.Image = Properties.Resources._1_Racoon;
                racoons++;

            }
            if (roll == 2)
            {
                pbx_Animal.Image = Properties.Resources._2_Rhino;
                rhinos++;

            }
            if (roll == 3)
            {
                pbx_Animal.Image = Properties.Resources._3_Starfish;
                starfish++;

            }
            if (roll == 4)
            {
                pbx_Animal.Image = Properties.Resources._4_Weasel;
                weasels++;

            }
            if (roll == 5)
            {
                pbx_Animal.Image = Properties.Resources._5_Jaguar;
                jaguar++;

            }
            LogImageDisplay(racoons, rhinos, starfish, weasels, jaguar);

        }

        private void LogImageDisplay(int racoons, int rhinos, int starfish, int weasels, int jaguar)
        {
            //string result = Console.WriteLine(racoons + rhinos + starfish + weasels + jaguar);
            string fileName = "results.txt";
            string filePath = Path.Combine(Application.StartupPath, fileName);
            try
            {
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write($"Racoons: {racoons}");
                sw.Write($"\nRhinos: {rhinos}");
                sw.Write($"\nStarfish: {starfish}");
                sw.Write($"\nWeasels: {weasels}");
                sw.Write($"\nJaguars: {jaguar}");
                sw.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                // Error message for error
                MessageBox.Show("Nope!");
            }
            StreamReader sr = new StreamReader(filePath);
            lbl_Result.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
