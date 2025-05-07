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
            string songPath = (Application.StartupPath + "\\Song" + "_" + txb_SongName.Text + ".txt");
            string songTitle = lbl_Title.Text + ": " + txb_SongName.Text;
            string songArtist = lbl_Artist.Text + ": " + txb_Artist.Text;
            string songLabel = lbl_Label.Text + ": " + txb_Label.Text;
            string songYear = lbl_Year.Text + ": " + txb_Year.Text;
            string songDuration = lbl_Duration.Text + ": " + txb_Duration.Text;
            try
            {
                StreamWriter sw = new StreamWriter(songPath);
                sw.WriteLine(songTitle);
                sw.WriteLine(songArtist);
                sw.WriteLine(songLabel);
                sw.WriteLine(songYear);
                sw.WriteLine(songDuration);
                sw.Close();
            }
            catch (System.IO.FileNotFoundException)
            {
                // Error message for error
                MessageBox.Show("Nope!");
            }
            StreamReader sr = new StreamReader(songPath);
            txb_Result.Text = sr.ReadToEnd();
            sr.Close();
      }
    }
}
