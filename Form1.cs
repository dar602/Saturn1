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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide(); ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f7 = new Form4();
            f7.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form5 f1 = new Form5();
            f1.Show();
            this.Hide();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide(); ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide(); 
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide(); ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start = label4.ForeColor;
            end = Color.White;
            Timer timer = new Timer();
            timer.Interval = 70;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        Color start;
        Color end;

        void timer_Tick(object sender, EventArgs e)
        {
            if (label4.ForeColor == start) label4.ForeColor = end;
            else label4.ForeColor = start;
            if (label4.Left > -label4.Width) label4.Left -= 5;
            else label4.Left = this.Width;//this - относительно чего label будет двигаться влево
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide(); ;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide(); ;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide(); ;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
    }


