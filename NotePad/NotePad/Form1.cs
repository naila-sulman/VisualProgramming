using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "NAILA TAHIR - Note Pad";
            this.ShowIcon = false;
            this.uToolStripMenuItem.Checked = true;
            this.textBox1.CharacterCasing = CharacterCasing.Upper;
            this.StartPosition = FormStartPosition.CenterParent;
            this.WindowState = FormWindowState.Normal;
            this.undoToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Enabled = false;
            this.deleteDelToolStripMenuItem.Enabled = false;
            this.pasteCtrlVToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            this.copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            this.pasteCtrlVToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            this.fileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            this.replaceCtrlToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            this.textBox1.Select();
            this.textBox1.Cut();
            this.timeDateToolStripMenuItem.ShortcutKeys = Keys.F5;
            this.deleteDelToolStripMenuItem.ShortcutKeys = Keys.Delete;
            this.saveCtrlToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.menuStrip1.BackColor = Color.Aqua;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.uToolStripMenuItem.Checked == true)
            {
                this.uToolStripMenuItem.Checked = false;
                this.lToolStripMenuItem.Checked = true;
                this.textBox1.CharacterCasing = CharacterCasing.Lower;
                this.toolStripMenuItem2.TextAlign = ContentAlignment.TopRight;
            }
            else
            {
                this.uToolStripMenuItem.Checked = true;
                this.lToolStripMenuItem.Checked = false;
                this.textBox1.CharacterCasing = CharacterCasing.Upper;
            }




        }

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.wordWrapToolStripMenuItem.Checked == false)
            {
                this.wordWrapToolStripMenuItem.Checked = true;
                this.textBox1.WordWrap = true;
            }
            else
            {
                this.wordWrapToolStripMenuItem.Checked = false;
                this.textBox1.WordWrap = false;

            }

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void pasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void findNextF3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.undoToolStripMenuItem.Enabled = true;
            this.cutToolStripMenuItem.Enabled = true;
            this.copyToolStripMenuItem.Enabled = true;
            this.deleteDelToolStripMenuItem.Enabled = true;
            this.pasteCtrlVToolStripMenuItem.Enabled = true;
        }

        private void replaceCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString();
        }

        private void fontWithColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.ForeColor = this.colorDialog1.Color;
            }
        }

        private void fontWithoutColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }
        }

        private void openCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt(*.txt|*.txt)";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fname = openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(fname);
            }
        }

        private void saveCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "txt(*.txt)|*.txt";
            DialogResult dr = this.saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                filename = filename + ".txt";
                File.WriteAllText(filename, this.textBox1.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }

}

