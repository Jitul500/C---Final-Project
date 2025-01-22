using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiubLink
{
    public partial class TicTacToe : Form
    {
        private string currentPlayer = "X";
        private int moves = 0;
        private int player1Score = 0;
        private int player2Score = 0;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void resetgamebutton_Click(object sender, EventArgs e)
        {
            ResetEverything();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            UpdateTurnLabel();
            UpdatePlayerScores();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;


            if (btn.Text == "")
            {

                btn.Text = currentPlayer;
                moves++;


                if (CheckWinner())
                {
                    MessageBox.Show($"Player {(currentPlayer == "X" ? "1 [X]" : "2 [O]")} Wins!", "Winner");
                    UpdateScores();
                }

                else if (moves == 9)
                {
                    MessageBox.Show("It's a Draw!", "Draw");
                }
                else
                {

                    currentPlayer = (currentPlayer == "X") ? "O" : "X";
                    UpdateTurnLabel();
                }
            }
        }


        private bool CheckWinner()
        {

            if (button1.Text == currentPlayer && button2.Text == currentPlayer && button3.Text == currentPlayer)
            {
                HighlightWinningButtons(button1, button2, button3);
                return true;
            }
            if (button4.Text == currentPlayer && button5.Text == currentPlayer && button6.Text == currentPlayer)
            {
                HighlightWinningButtons(button4, button5, button6);
                return true;
            }
            if (button7.Text == currentPlayer && button8.Text == currentPlayer && button9.Text == currentPlayer)
            {
                HighlightWinningButtons(button7, button8, button9);
                return true;
            }


            if (button1.Text == currentPlayer && button4.Text == currentPlayer && button7.Text == currentPlayer)
            {
                HighlightWinningButtons(button1, button4, button7);
                return true;
            }
            if (button2.Text == currentPlayer && button5.Text == currentPlayer && button8.Text == currentPlayer)
            {
                HighlightWinningButtons(button2, button5, button8);
                return true;
            }
            if (button3.Text == currentPlayer && button6.Text == currentPlayer && button9.Text == currentPlayer)
            {
                HighlightWinningButtons(button3, button6, button9);
                return true;
            }


            if (button1.Text == currentPlayer && button5.Text == currentPlayer && button9.Text == currentPlayer)
            {
                HighlightWinningButtons(button1, button5, button9);
                return true;
            }
            if (button3.Text == currentPlayer && button5.Text == currentPlayer && button7.Text == currentPlayer)
            {
                HighlightWinningButtons(button3, button5, button7);
                return true;
            }

            return false;
        }


        private void HighlightWinningButtons(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Green;
            b2.BackColor = Color.Green;
            b3.BackColor = Color.Green;
        }

        private void UpdateScores()
        {
            if (currentPlayer == "X")
            {
                player1Score++;
            }
            else
            {
                player2Score++;
            }

            UpdatePlayerScores();
        }

        private void UpdateTurnLabel()
        {
            turnlabel.Text = currentPlayer == "X"
                ? "Player 1 [X]'s Turn"
                : "Player 2 [O]'s Turn";
        }


        private void UpdatePlayerScores()
        {
            player1label.Text = $"Player 1: {player1Score}";
            player2label.Text = $"Player 2: {player2Score}";
        }

        private void ResetGame()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Button btn)
                {
                    btn.Text = "";
                    btn.BackColor = SystemColors.ActiveBorder;
                }
            }

            currentPlayer = "X";
            moves = 0;
            UpdateTurnLabel();
        }


        private void ResetEverything()
        {
            ResetGame();
            player1Score = 0;
            player2Score = 0;
            UpdatePlayerScores();
        }

        private void playagainbutton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }
    }
}
