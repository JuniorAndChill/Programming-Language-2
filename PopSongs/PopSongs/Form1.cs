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

namespace PopSongs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddSong_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Song" + "_" + txb_SongName.Text + ".txt");
                sw.WriteLine(lbl_Title.Text + ": " + txb_SongName.Text);
                sw.WriteLine(lbl_Artist.Text + ": " + txb_Artist.Text);
                sw.WriteLine(lbl_Label.Text + ": " + txb_Label.Text);
                sw.WriteLine(lbl_Year.Text + ": " + txb_Year.Text);
                sw.WriteLine(lbl_Duration.Text + ": " + txb_Duration.Text);
                sw.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                // Error message for error
                MessageBox.Show("Nope!");
            }
            StreamReader sr = new StreamReader(Application.StartupPath + "\\Song" + "_" + txb_SongName.Text + ".txt");
            txb_Result.Text = sr.ReadToEnd();
            sr.Close();
      }
    }
}
