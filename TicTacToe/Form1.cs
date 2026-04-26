using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int combination = 0; // Combinations for a win

        bool turn = true; // When true it's Xs turn when false it's Ys turn

        bool against_computer = false; // Is it in single player or double player
        
        int turnCount = 0; //  How many turns?

        static String player1, player2; // Names for players will be stored here
        static bool singlePlayerMode; // Will the opponent be the computer?

        public Form1()
        {
            InitializeComponent(); // Initializing the form
        }

        public static void setPlayerNames(String n1, String n2, bool isSinglePlayer)
        {
            player1 = n1;
            player2 = n2;
            singlePlayerMode = isSinglePlayer;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prompting a message box which indicates the name of the author of the program
            MessageBox.Show("By Zaid Alnemer", "About"); 
        }

        // A method which will restart the draw count in the scoreboard
        private void resetDrawCounter()
        {
            drawCount.Text = "0"; // Set the text of the label to 0
        }

        // A method which will restart the win count for O in the scoreboard
        private void resetOCounter()
        {
            oWinCount.Text = "0"; // Set the text of the label to 0
        }

        // A method which will restart the win count for X in the scoreboard
        private void resetXCounter()
        {
            xWinCount.Text = "0"; // Set the text of the label to 0
        }

        // Called when "Exit" in the menu tool strip is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the program
        }

        // Called when a button is clicked
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender; 

            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;

            b.Enabled = false;

            if (turn)
            {
                b.BackColor = Color.Blue;
            }
            else
                b.BackColor = Color.Red;

            // Incrementing to the turn count
            turnCount++;

            // cehcking if there is a win
            checkForWinner();

            // If single-player mode is active and it is O's turn, let the computer move.
            if ((!turn) && (against_computer))
            {
                moveAI();
            }
        }

        // This method will check for a winner in the game
        private async void checkForWinner()
        {
            // creating a boolean that says whether someone has won or not
            bool win = false;

            // Horizontal Win Check
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                win = true;
                combination = 1;
                timer1.Enabled = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B2.Enabled))
            {
                win = true;
                combination = 2;
                timer1.Enabled = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                win = true;
                combination = 3;
                timer1.Enabled = true;
            }

            // Vertical Check 
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                win = true;
                combination = 4;
                timer1.Enabled = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                win = true;
                combination = 5;
                timer1.Enabled = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                win = true;
                combination = 6;
                timer1.Enabled = true;
            }

            // Diagonal Check 
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                win = true;
                combination = 7;
                timer1.Enabled = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                win = true;
                combination = 8;
                timer1.Enabled = true;
            }

            if (win)
            {
                disableButtons(); // Disable all other buttons from being pressed

                String winner = "";

                if (turn)
                {
                    winner = P2.Text;
                    oWinCount.Text = (Int32.Parse(oWinCount.Text) + 1).ToString();
                }
                else
                {
                    winner = P1.Text;
                    xWinCount.Text = (Int32.Parse(xWinCount.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " Wins", "Yay!"); //  Output winner

                await Task.Delay(2500); // Delay program for 2 and a half seconds

                timer1.Enabled = false; // Disable timer

                clearBoard(); // Clear the tic tac toe board
            }
            else
            {
                // IF there is a draw
                if (turnCount == 9)
                {
                    drawCount.Text = (Int32.Parse(drawCount.Text) + 1).ToString(); // Increment to the draw counter on scoreboard
                    MessageBox.Show("It was a draw!", "Bummer!"); // Output it was a draw

                    await Task.Delay(2500); // 2 and a half second delay

                    timer1.Enabled = false; // Disable timere

                    clearBoard(); // Erase tic tac toe game board
                }  
            }
        }

        private void disableButtons()
        {
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;
        }

        // This function restarts all of the buttons on the tic tac toe board
        private void resetButtons()
        { 
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;

                    b.Enabled = true; // Enable buttons

                    b.Text = ""; // Clear the text inside them

                    b.BackColor = default(Color); // Reset their color
                }
                catch { }
            } 
        }

        // This method clears the game board
        private void clearBoard()
        {
            timer1.Enabled = false; // Disable the timer
            turn = true; // X's turn
            turnCount = 0; // Reset the turn count
            resetButtons(); // Restart the buttons
        }

        // Called when "New Game" in the menu tool strip is pressed
        private void newgameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        // Called when the mouse cursor enters a button
        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled)
            {
                if (turn)
                {
                    b.ForeColor = Color.Red;
                    b.Text = "X";
                }
                else
                {
                    b.ForeColor = Color.Blue;
                    b.Text = "O";
                }
            }
        }

        // Called when the mouse cursor leaves a button after previously entering it
        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        // This function resets the score board
        private void resetCounters()
        {
            oWinCount.Text = "0";

            xWinCount.Text = "0";

            drawCount.Text = "0";
        }

        // Called when "Reset ALL Counters" is clicked on in the menu tool strip
        private void resetAllCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetCounters();
        }

        // Called when "Clear Board" in the menu tool strip is pressed
        private void clearBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearBoard();
        }

        // Called when the form is first loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            P1.Text = player1;
            P2.Text = player2;
            against_computer = singlePlayerMode;

            timer1.Start();
            timer1.Enabled = false;
        }

        // Computer AI
        private void moveAI()
        {
            //priority 1:  get tick tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space

            Button move = null;

            //look for tic tac toe opportunities
            move = winOrBlock("O"); //look for win
            if (move == null)
            {
                move = winOrBlock("X"); //look for block
                if (move == null)
                {
                    move = corner_search();
                    if (move == null)
                    {
                        move = openSpace_search();
                    }
                }
            }

            if (move != null)
            {
                move.PerformClick();
            }
        }

        // This method creates the part of the AI that looks for an open space
        private Button openSpace_search()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }

            return null;
        }

        // This method is the part of the AI that looks for a open corner space
        private Button corner_search()
        {
            Console.WriteLine("Looking for corner");
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }

        // This is called when the text in the text box is changed
        
        /*private void P2_TextChanged(object sender, EventArgs e)
        {
            if (P2.Text.ToUpper() == "COMPUTER")
                against_computer = true;
            else
                against_computer = false;
        }*/

        // This is called when the "Reset Win Count For X" in the menu strip is pressed
        private void resetWinCountForXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetXCounter();
        }

        // This is called when the "Reset Win Count For O" in the menu strip is pressed
        private void resetWinCountForOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetOCounter();
        }

        // This is called when the "Reset Draw Count in the menu strip is pressed
        private void resetDrawCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetDrawCounter();
        }

        // THis is called when the timer is enabled
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            int A = rand.Next(0, 255);
            int r = turn ? rand.Next(0, 50) : 255;
            int g = rand.Next(0, 255);
            int b = turn ? 255 : rand.Next(0, 50);

            if (combination == 1)
            {
                A1.BackColor = Color.FromArgb(A, r, g, b);
                A2.BackColor = Color.FromArgb(A, r, g, b);
                A3.BackColor = Color.FromArgb(A, r, g, b);
            }
            else if (combination == 2)
            {
                B1.BackColor = Color.FromArgb(A, r, g, b);
                B2.BackColor = Color.FromArgb(A, r, g, b);
                B3.BackColor = Color.FromArgb(A, r, g, b);
            }
            else if (combination == 3)
            {
                C1.BackColor = Color.FromArgb(A, r, g, b);
                C2.BackColor = Color.FromArgb(A, r, g, b);
                C3.BackColor = Color.FromArgb(A, r, g, b);
            }
            else if (combination == 4)
            {
                A1.BackColor = Color.FromArgb(A, r, g, b);
                B1.BackColor = Color.FromArgb(A, r, g, b);
                C1.BackColor = Color.FromArgb(A, r, g, b);
            }
            else if (combination == 5)
            {
                A2.BackColor = Color.FromArgb(A, r, g, b);
                B2.BackColor = Color.FromArgb(A, r, g, b);
                C2.BackColor = Color.FromArgb(A, r, g, b);
            }
            else if (combination == 6)
            {
                A3.BackColor = Color.FromArgb(A, r, g, b);
                B3.BackColor = Color.FromArgb(A, r, g, b);
                C3.BackColor = Color.FromArgb(A, r, g, b);
            }
            else if (combination == 7)
            {
                A1.BackColor = Color.FromArgb(A, r, g, b);
                B2.BackColor = Color.FromArgb(A, r, g, b);
                C3.BackColor = Color.FromArgb(A, r, g, b);
            }
            else if (combination == 8)
            {
                A3.BackColor = Color.FromArgb(A, r, g, b);
                B2.BackColor = Color.FromArgb(A, r, g, b);
                C1.BackColor = Color.FromArgb(A, r, g, b);
            }
        }

        // Called when "Quit" is pressed in the menu tool strip
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exits program
        }

        // The part of the AI that is going to look for a win or block opportunity
        private Button winOrBlock(string mark)
        {
            Console.WriteLine("Looking for a tic tac toe:  " + mark);
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }
    }
}
