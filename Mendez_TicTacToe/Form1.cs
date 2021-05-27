using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(numPlayers % 2 == 0)
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

        private void btn2_Click(object sender, EventArgs e)
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

        private void btn3_Click(object sender, EventArgs e)
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

        private void btn4_Click(object sender, EventArgs e)
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

        private void btn5_Click(object sender, EventArgs e)
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

        private void btn6_Click(object sender, EventArgs e)
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

        private void btn7_Click(object sender, EventArgs e)
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

        private void btn8_Click(object sender, EventArgs e)
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

        private void btn9_Click(object sender, EventArgs e)
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

        private void btnExt_Click(object sender, EventArgs e)
        {

        }
    }
}
