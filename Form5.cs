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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SendMail sendMail = new SendMail(textBoxBody.Text, textBoxName.Text, textBoxSubject.Text);
            sendMail.MySendMail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendMail sendMail = new SendMail(textBoxBody.Text, textBoxName.Text, textBoxSubject.Text);
            sendMail.MySendMail();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
