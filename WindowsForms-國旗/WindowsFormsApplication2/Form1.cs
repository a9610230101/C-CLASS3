using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "美國";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "台灣";
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            label1.Text = "英國";
        }
    }
}
