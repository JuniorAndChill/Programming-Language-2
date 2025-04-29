using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roll
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Image[] diceImages = new Image[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image for Dice ";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Multiselect = false; // Only allow one file selection
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;   //saves the path into a string
                    textBox1.Text = selectedFilePath;   //displays the file path in the textbox
                    pbx_Dice1.Image = new Bitmap(selectedFilePath);   //displays the image in the imageBox
                    diceImages[0] = Image.FromFile(selectedFilePath);  //saves the image into the position zero of the array
                }
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;   //saves the path into a string
                    textBox1.Text = selectedFilePath;   //displays the file path in the textbox
                    pbx_Dice2.Image = new Bitmap(selectedFilePath);   //displays the image in the imageBox
                    diceImages[1] = Image.FromFile(selectedFilePath);  //saves the image into the position zero of the array
                }
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;   //saves the path into a string
                    textBox1.Text = selectedFilePath;   //displays the file path in the textbox
                    pbx_Dice3.Image = new Bitmap(selectedFilePath);   //displays the image in the imageBox
                    diceImages[2] = Image.FromFile(selectedFilePath);  //saves the image into the position zero of the array
                }
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;   //saves the path into a string
                    textBox1.Text = selectedFilePath;   //displays the file path in the textbox
                    pbx_Dice4.Image = new Bitmap(selectedFilePath);   //displays the image in the imageBox
                    diceImages[3] = Image.FromFile(selectedFilePath);  //saves the image into the position zero of the array
                }
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;   //saves the path into a string
                    textBox1.Text = selectedFilePath;   //displays the file path in the textbox
                    pbx_Dice5.Image = new Bitmap(selectedFilePath);   //displays the image in the imageBox
                    diceImages[4] = Image.FromFile(selectedFilePath);  //saves the image into the position zero of the array
                }
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;   //saves the path into a string
                    textBox1.Text = selectedFilePath;   //displays the file path in the textbox
                    pbx_Dice6.Image = new Bitmap(selectedFilePath);   //displays the image in the imageBox
                    diceImages[5] = Image.FromFile(selectedFilePath);  //saves the image into the position zero of the array
                }
            }

        }

        private void btn_Roll_Click(object sender, EventArgs e)
        {
            int roll = random.Next(0, 6); // Generates a number from 0 to 5
            pbx_Result.Image = diceImages[roll];
            pbx_Result.Visible = true;
        }
    }
}
