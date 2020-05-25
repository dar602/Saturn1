using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saturn
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("тел. (381-2 )31-15-73");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("тел. (381-2 )39-77-48");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("тел. (381-2 )31-15-73");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("тел. (381-2 )31-06-09");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("тел. (381-2 )31-98-55");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide(); ;
        }
    }
}
