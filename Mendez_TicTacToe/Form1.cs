using System;
using System.Windows.Forms;

namespace Mendez_TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int playerTurns = 0;
        int numPlayers = 2;

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                if (numPlayers % 2 == 0)
                {
                    btn1.Text = "X";
                    playerTurns++;
                    numPlayers++;
                }
                else
                {
                    btn1.Text = "O";
                    playerTurns++;
                    numPlayers++;
                }
            }
            WinCondition();
            DrawCondition();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {

                if (numPlayers % 2 == 0)
                {
                    btn2.Text = "X";
                    playerTurns++;
                    numPlayers++;
                }
                else
                {
                    btn2.Text = "O";
                    playerTurns++;
                    numPlayers++;
                }
            }
            WinCondition();
            DrawCondition();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                if (numPlayers % 2 == 0)
                {
                    btn3.Text = "X";
                    playerTurns++;
                    numPlayers++;
                }
                else
                {
                    btn3.Text = "O";
                    playerTurns++;
                    numPlayers++;
                }
            }
            WinCondition();
            DrawCondition();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                if (numPlayers % 2 == 0)
                {
                    btn4.Text = "X";
                    playerTurns++;
                    numPlayers++;
                }
                else
                {
                    btn4.Text = "O";
                    playerTurns++;
                    numPlayers++;
                }
            }
            WinCondition();
            DrawCondition();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                if (numPlayers % 2 == 0)
                {
                    btn5.Text = "X";
                    playerTurns++;
                    numPlayers++;
                }
                else
                {
                    btn5.Text = "O";
                    playerTurns++;
                    numPlayers++;
                }
            }
            WinCondition();
            DrawCondition();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                if (numPlayers % 2 == 0)
                {
                    btn6.Text = "X";
                    playerTurns++;
                    numPlayers++;
                }
                else
                {
                    btn6.Text = "O";
                    playerTurns++;
                    numPlayers++;
                }
            }
            WinCondition();
            DrawCondition();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                if (numPlayers % 2 == 0)
                {
                    btn7.Text = "X";
                    playerTurns++;
                    numPlayers++;
                }
                else
                {
                    btn7.Text = "O";
                    playerTurns++;
                    numPlayers++;
                }
            }
            WinCondition();
            DrawCondition();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                if (numPlayers % 2 == 0)
                {
                    btn8.Text = "X";
                    playerTurns++;
                    numPlayers++;
                }
                else
                {
                    btn8.Text = "O";
                    playerTurns++;
                    numPlayers++;
                }
            }
            WinCondition();
            DrawCondition();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {

                if (numPlayers % 2 == 0)
                {
                    btn9.Text = "X";
                    playerTurns++;
                    numPlayers++;
                }
                else
                {
                    btn9.Text = "O";
                    playerTurns++;
                    numPlayers++;
                }
            }
            WinCondition();
            DrawCondition();
        }


        void ResetGame()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            numPlayers = 2;
            playerTurns = 0;
        }
        private void btnRes_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        public void WinCondition()
        {
            for (int x = 1; x < 9; x++)
            {
                string winningCombi = "";

                switch (x) //9 cases in total
                {
                    //horizontal winning combinations
                    case 1:
                        winningCombi = btn1.Text + btn2.Text + btn3.Text;
                        break;
                    case 2:
                        winningCombi = btn4.Text + btn5.Text + btn6.Text;
                        break;
                    case 3:
                        winningCombi = btn7.Text + btn8.Text + btn9.Text;
                        break;
                    //vertical winning combinations
                    case 4:
                        winningCombi = btn1.Text + btn4.Text + btn7.Text;
                        break;
                    case 5:
                        winningCombi = btn2.Text + btn5.Text + btn8.Text;
                        break;
                    case 6:
                        winningCombi = btn3.Text + btn6.Text + btn9.Text;
                        break;
                    //diagonal winning combinations
                    case 7:
                        winningCombi = btn1.Text + btn5.Text + btn9.Text;
                        break;
                    case 8:
                        winningCombi = btn3.Text + btn5.Text + btn7.Text;
                        break;


                }
                if (winningCombi.Equals("XXX"))
                {
                    MessageBox.Show("X won the game!");
                }
                else if (winningCombi.Equals("OOO"))
                {
                    MessageBox.Show("O won the game!");
                }
            }
        }

        bool DrawCondition()
        {
            if(playerTurns == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
