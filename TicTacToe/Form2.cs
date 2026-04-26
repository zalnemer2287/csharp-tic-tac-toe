using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        private bool singlePlayerMode = false;

        private void doublePlayer_Click(object sender, EventArgs e)
        {
            singlePlayerMode = false;
            if (P2.ReadOnly == true)
            {
                P2.ReadOnly = false;

                P2.Text = "Player 2";
            }
            else if (P1.ReadOnly == true)
            {
                P1.ReadOnly = false;

                P1.Text = "Player 1";
            }

            if ((P1.Text == "") || (P1.Text == "You"))
            {
                P1.Text = "Player 1";
            }
            else if (P2.Text == "")
            {
                P2.Text = "Player 2";
            }
        }

        private void ResetPlayerNameFields()
        {
            if (P2.ReadOnly == true)
            {
                P2.ReadOnly = false;

                P2.Text = "Player 2";
            }
            else if (P1.ReadOnly == true)
            {
                P1.ReadOnly = false;

                P1.Text = "Player 1";
            }

            if ((P1.Text == "") || (P1.Text == "You"))
            {
                P1.Text = "Player 1";
            }
        }

        public Form2()
        {
            InitializeComponent();

            ResetPlayerNameFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.setPlayerNames(P1.Text, P2.Text, singlePlayerMode);

            Form1 f1 = new TicTacToe.Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }



        private void play(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                button1.PerformClick();
        }

        private void singlePlayer_Click(object sender, EventArgs e)
        {
            singlePlayerMode = true;
            P2.Text = "Computer";
            P2.ReadOnly = true;
            if ((P1.Text == "") || (P1.Text == "Player 1"))
            {
                P1.Text = "You";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void P1_DoubleClick(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
    }
}
