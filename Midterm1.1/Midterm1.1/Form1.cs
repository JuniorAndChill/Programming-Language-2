using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm1._1
{
    public partial class form1: Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btn_James_Click(object sender, EventArgs e)
        {
            img_James.Visible = true;
            img_Michael.Visible = false;
            img_Rock.Visible = false;
            img_Ryan.Visible = false;
        }

        private void btn_Michael_Click(object sender, EventArgs e)
        {
            img_James.Visible = false;
            img_Michael.Visible = true;
            img_Rock.Visible = false;
            img_Ryan.Visible = false;
        }

        private void btn_Rock_Click(object sender, EventArgs e)
        {
            img_James.Visible = false;
            img_Michael.Visible = false;
            img_Rock.Visible = true;
            img_Ryan.Visible = false;
        }

        private void btn_Ryan_Click(object sender, EventArgs e)
        {
            img_James.Visible = false;
            img_Michael.Visible = false;
            img_Rock.Visible = false;
            img_Ryan.Visible = true;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            img_James.Visible = false;
            img_Michael.Visible = false;
            img_Rock.Visible = false;
            img_Ryan.Visible = false;
        }
    }
}
