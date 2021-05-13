using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Game : Form
    {
        bool player1 = true;
        bool locked = false;
        int winner = 0;
        int owns11 = 0;
        int owns12 = 0;
        int owns13 = 0;
        int owns21 = 0;
        int owns22 = 0;
        int owns23 = 0;
        int owns31 = 0;
        int owns32 = 0;
        int owns33 = 0;

        public Game()
        {
            InitializeComponent();
        }

        private int winCondition() 
        {
            int winner = 0;
            
            if (
                ((owns11 == 1) & (owns12 == 1) & (owns13 == 1)) |
                ((owns21 == 1) & (owns22 == 1) & (owns23 == 1)) |
                ((owns31 == 1) & (owns32 == 1) & (owns33 == 1)) |
                ((owns11 == 1) & (owns21 == 1) & (owns31 == 1)) |
                ((owns12 == 1) & (owns22 == 1) & (owns32 == 1)) |
                ((owns13 == 1) & (owns23 == 1) & (owns33 == 1)) |
                ((owns11 == 1) & (owns22 == 1) & (owns33 == 1)) |
                ((owns31 == 1) & (owns22 == 1) & (owns13 == 1))                
               )
            {
                locked = true;
                winner = 1;
                lblwinner.Text = "The Winner is Player 1";
            }

            if (
                ((owns11 == 2) & (owns12 == 2) & (owns13 == 2)) |
                ((owns21 == 2) & (owns22 == 2) & (owns23 == 2)) |
                ((owns31 == 2) & (owns32 == 2) & (owns33 == 2)) |
                ((owns11 == 2) & (owns21 == 2) & (owns31 == 2)) |
                ((owns12 == 2) & (owns22 == 2) & (owns32 == 2)) |
                ((owns13 == 2) & (owns23 == 2) & (owns33 == 2)) |
                ((owns11 == 2) & (owns22 == 2) & (owns33 == 2)) |
                ((owns31 == 2) & (owns22 == 2) & (owns13 == 2))
               )
            {
                locked = true;
                winner = 2;
                lblwinner.Text = "The Winner is Player 2";
            }

            if (((!(owns11 == 0)) & (!(owns12 == 0)) & (!(owns13 == 0)) & (!(owns21 == 0)) & (!(owns22 == 0)) & (!(owns23 == 0)) & (!(owns31 == 0)) & (!(owns32 == 0)) & (!(owns33 == 0))) & (locked == false))
            {
                locked = true;
                winner = 3;
                lblwinner.Text = "No Winners";
            }
            return winner;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            winner = winCondition();

            if (winner == 1)
            {
                int winsp1 = Convert.ToInt32(lblwp1.Text);
                winsp1++;
                lblwp1.Text = Convert.ToString(winsp1);
            }

            if (winner == 2)
            {
                int winsp2 = Convert.ToInt32(lblwp2.Text);
                winsp2++;
                lblwp2.Text = Convert.ToString(winsp2);
            }

            owns11 = 0;
            owns12 = 0;
            owns13 = 0;
            owns21 = 0;
            owns22 = 0;
            owns23 = 0;
            owns31 = 0;
            owns32 = 0;
            owns33 = 0;

            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";

            player1 = true;
            locked = false;
            winner = 0;
            lblwinner.Text = "";
        }

        private void restartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            resetToolStripMenuItem_Click(sender, e);
            lblwp1.Text = Convert.ToString("0");
            lblwp2.Text = Convert.ToString("0");
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if ((owns11 == 0) & (locked == false))
            {
                if (player1 == true)
                {
                    btn11.Text = "x";
                    player1 = false;
                    owns11 = 1;
                }
                else
                {
                    btn11.Text = "o";
                    player1 = true;
                    owns11 = 2;
                }
            }
            winCondition();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if ((owns12 == 0) & (locked == false))
            {
                if (player1 == true)
                {
                    btn12.Text = "x";
                    player1 = false;
                    owns12 = 1;
                }
                else
                {
                    btn12.Text = "o";
                    player1 = true;
                    owns12 = 2;
                }
            }
            winCondition();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if ((owns13 == 0) & (locked == false))
            {
                if (player1 == true)
                {
                    btn13.Text = "x";
                    player1 = false;
                    owns13 = 1;
                }
                else
                {
                    btn13.Text = "o";
                    player1 = true;
                    owns13 = 2;
                }
            }
            winCondition();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if ((owns21 == 0) &(locked == false))
            {
                if (player1 == true)
                {
                    btn21.Text = "x";
                    player1 = false;
                    owns21 = 1;
                }
                else
                {
                    btn21.Text = "o";
                    player1 = true;
                    owns21 = 2;
                }
            }
            winCondition();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if ((owns22 == 0) & (locked == false))
            {
                if (player1 == true)
                {
                    btn22.Text = "x";
                    player1 = false;
                    owns22 = 1;
                }
                else
                {
                    btn22.Text = "o";
                    player1 = true;
                    owns22 = 2;
                }
            }
            winCondition();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if ((owns23 == 0) & (locked == false))
            {
                if (player1 == true)
                {
                    btn23.Text = "x";
                    player1 = false;
                    owns23 = 1;
                }
                else
                {
                    btn23.Text = "o";
                    player1 = true;
                    owns23 = 2;
                }
            }
            winCondition();
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if ((owns31 == 0) & (locked == false))
            {
                if (player1 == true)
                {
                    btn31.Text = "x";
                    player1 = false;
                    owns31 = 1;
                }
                else
                {
                    btn31.Text = "o";
                    player1 = true;
                    owns31 = 2;
                }
            }
            winCondition();
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if ((owns32 == 0) & (locked == false))
            {
                if (player1 == true)
                {
                    btn32.Text = "x";
                    player1 = false;
                    owns32 = 1;
                }
                else
                {
                    btn32.Text = "o";
                    player1 = true;
                    owns32 = 2;
                }
            }
            winCondition();
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if ((owns33 == 0) & (locked == false))
            {
                if (player1 == true)
                {
                    btn33.Text = "x";
                    player1 = false;
                    owns33 = 1;
                }
                else
                {
                    btn33.Text = "o";
                    player1 = true;
                    owns33 = 2;
                }
            }
            winCondition();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
