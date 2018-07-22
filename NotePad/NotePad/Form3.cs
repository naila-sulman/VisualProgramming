using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Replace";
            this.label1.Text = "Find What";
            this.label2.Text = "Replace With";
            this.button1.Text = "Find Next"; 
            this.button2.Text = "Replace";
            this.button3.Text = "Replace All";
            this.button4.Text = "Cancel";
            this.checkBox1.Text = "Match Case";
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.CancelButton = this.button4;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.PaleVioletRed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            textBox3.Text = this.textBox3.Text.Replace(this.textBox1.Text, this.textBox2.Text);
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
