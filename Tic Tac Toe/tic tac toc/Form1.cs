using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tic_tac_toc
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = X turn; false = Y turn;
        int turn_count = 0;
        string winner = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed and Developed by Naila Tahir", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text != "X" && b.Text != "O")
            {
                if (turn)
                {
                    b.Text = "X";
                    b.ForeColor = Color.Red;
                }
                else
                {
                    b.Text = "O";
                    b.ForeColor = Color.Green;
                }
                turn = !turn;
                //b.Enabled = false;
                turn_count++;

                checkforwinner();
            }
        }
        private void checkforwinner()
        {
            bool there_is_a_winner = false;

            //horizantal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Text != "" || A2.Text != "" || A3.Text != ""))
            {
                there_is_a_winner = true;
                A1.BackColor = Color.Cyan;
                A2.BackColor = Color.Cyan;
                A3.BackColor = Color.Cyan;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Text != "" || B2.Text != "" || B3.Text != ""))
            {
                there_is_a_winner = true;
                B1.BackColor = Color.Cyan;
                B2.BackColor = Color.Cyan;
                B3.BackColor = Color.Cyan;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Text != "" || C2.Text != "" || C3.Text != ""))
            {
                there_is_a_winner = true;
                C1.BackColor = Color.Cyan;
                C2.BackColor = Color.Cyan;
                C3.BackColor = Color.Cyan;
            }

            //vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Text != "" || B1.Text != "" || C1.Text != ""))
            {
                there_is_a_winner = true;
                A1.BackColor = Color.Cyan;
                B1.BackColor = Color.Cyan;
                C1.BackColor = Color.Cyan;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Text != "" || B2.Text != "" || C2.Text != ""))
            {
                there_is_a_winner = true;
                A2.BackColor = Color.Cyan;
                B2.BackColor = Color.Cyan;
                C2.BackColor = Color.Cyan;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Text != "" || B3.Text != "" || C3.Text != ""))
            {
                there_is_a_winner = true;
                A3.BackColor = Color.Cyan;
                B3.BackColor = Color.Cyan;
                C3.BackColor = Color.Cyan;
            }

             //Diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Text != "" || B2.Text != "" || C3.Text != ""))
            {
                there_is_a_winner = true;
                A1.BackColor = Color.Cyan;
                B2.BackColor = Color.Cyan;
                C3.BackColor = Color.Cyan;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (A3.Text != "" || B2.Text != "" || C3.Text != ""))
            {
                there_is_a_winner = true;
                A3.BackColor = Color.Cyan;
                B2.BackColor = Color.Cyan;
                C1.BackColor = Color.Cyan;
            }
            
            if (there_is_a_winner)
            {
                disablebutton();
                
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show("Player "+winner + " wins!", "Yahooo!");
            }//end if
            else
            {
                if(turn_count==9)
                    MessageBox.Show("Match drawn!", "Oops!");

            }

        }//end checkforwinner
        private void disablebutton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//end foreach
            }//end try
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            winner = "";
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.BackColor = Color.FromArgb(255, 255, 192);
                    b.Text = "";
                }//end foreach
            }//end try
            catch { }
        }
    }
}
