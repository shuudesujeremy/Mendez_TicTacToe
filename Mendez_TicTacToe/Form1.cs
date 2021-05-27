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

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btnRes_Click(object sender, EventArgs e)
        {

        }

        private void btnExt_Click(object sender, EventArgs e)
        {

        }
    }
}
