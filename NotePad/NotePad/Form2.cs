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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Find";
            this.button1.Text = "Find Next";
            this.button2.Text = "Cancel";
            this.label1.Text = "Find What:";
            this.checkBox1.Text = "Match Case";
            this.groupBox1.Text = "Direction";
            this.radioButton1.Text = "Up";
            this.radioButton2.Text = "Down";
            this.button1.Enabled = false;
            this.CancelButton = this.button2;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.MistyRose;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            if (f1.textBox1.Text.Contains(this.textBox1.Text))
            {
                MessageBox.Show("String Found");
            }
            else
            {
                MessageBox.Show("String Not Found");
            }
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
        }
    }
}
