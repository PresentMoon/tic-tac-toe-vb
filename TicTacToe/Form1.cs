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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public int players = 2; //even = O move; odd = X 
        public int moves = 0; //counting moves;

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (players % 2 != 0)
            {
                button.Text = "O";
                players++;
                moves++;
            }
            else
            {
                button.Text = "X";
                players++;
                moves++;
            }

            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X Wins!");
                    NewGame();
                }
                else
                {
                    MessageBox.Show("O Wins!");
                    NewGame();
                }
            }

            if (CheckDraw() == true)
            {
                MessageBox.Show("It's a Draw!");
                NewGame();
            }
        }
        void NewGame()
        {
            players = 2;
            moves = 0;
            A1.Text = A2.Text = A3.Text = B1.Text = B2.Text = B3.Text = C1.Text = C2.Text = C3.Text = "";
        }
        private void NGbuttonClick(object sender, EventArgs e)
        {
            NewGame();
        }
        private void EButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
        bool CheckWinner()
        {
            //horizontal checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && A1.Text != "")
                return true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && A2.Text != "")
                return true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && A3.Text != "")
                return true;

            //vertical checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && A1.Text != "")
                return true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && B1.Text != "")
                return true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && C1.Text != "")
                return true;

            //diagonal checks
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && A1.Text != "")
                return true;
            else if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && C1.Text != "")
                return true;
            else
                return false;
        }
        bool CheckDraw()
        {
            if (moves == 9)
                return true;
            else
                return false;
        }
    }
}