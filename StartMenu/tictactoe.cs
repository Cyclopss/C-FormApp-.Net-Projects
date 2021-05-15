using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartMenu
{
    public partial class tictactoe : Form
    {
        Boolean check;
        int entone;
        void EnableFalse()
        {
            tic1Btn.Enabled = false;
            tic2Btn.Enabled = false;
            tic3Btn.Enabled = false;
            tic4Btn.Enabled = false;
            tic5Btn.Enabled = false;
            tic6Btn.Enabled = false;
            tic7Btn.Enabled = false;
            tic8Btn.Enabled = false;
            tic9Btn.Enabled = false;

        }
        void Score()
        {
            // X winner side
            if(tic1Btn.Text == "X" && tic2Btn.Text == "X" && tic3Btn.Text == "X")
            {
                tic1Btn.BackColor = Color.PowderBlue;
                tic2Btn.BackColor = Color.PowderBlue;
                tic3Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player X win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(plxscLbl.Text);
                plxscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic1Btn.Text == "X" && tic4Btn.Text == "X" && tic7Btn.Text == "X")
            {
                tic1Btn.BackColor = Color.PowderBlue;
                tic4Btn.BackColor = Color.PowderBlue;
                tic7Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player X win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(plxscLbl.Text);
                plxscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic1Btn.Text == "X" && tic5Btn.Text == "X" && tic9Btn.Text == "X")
            {
                tic1Btn.BackColor = Color.PowderBlue;
                tic5Btn.BackColor = Color.PowderBlue;
                tic9Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player X win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(plxscLbl.Text);
                plxscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic2Btn.Text == "X" && tic5Btn.Text == "X" && tic8Btn.Text == "X")
            {
                tic2Btn.BackColor = Color.PowderBlue;
                tic5Btn.BackColor = Color.PowderBlue;
                tic8Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player X win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(plxscLbl.Text);
                plxscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic3Btn.Text == "X" && tic6Btn.Text == "X" && tic9Btn.Text == "X")
            {
                tic3Btn.BackColor = Color.PowderBlue;
                tic6Btn.BackColor = Color.PowderBlue;
                tic9Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player X win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(plxscLbl.Text);
                plxscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic4Btn.Text == "X" && tic5Btn.Text == "X" && tic6Btn.Text == "X")
            {
                tic4Btn.BackColor = Color.PowderBlue;
                tic5Btn.BackColor = Color.PowderBlue;
                tic6Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player X win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(plxscLbl.Text);
                plxscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic7Btn.Text == "X" && tic8Btn.Text == "X" && tic9Btn.Text == "X")
            {
                tic7Btn.BackColor = Color.PowderBlue;
                tic8Btn.BackColor = Color.PowderBlue;
                tic9Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player X win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(plxscLbl.Text);
                plxscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic3Btn.Text == "X" && tic5Btn.Text == "X" && tic7Btn.Text == "X")
            {
                tic3Btn.BackColor = Color.PowderBlue;
                tic5Btn.BackColor = Color.PowderBlue;
                tic9Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player X win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(plxscLbl.Text);
                plxscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            // O winner side

            if (tic1Btn.Text == "O" && tic2Btn.Text == "O" && tic3Btn.Text == "O")
            {
                tic1Btn.BackColor = Color.PowderBlue;
                tic2Btn.BackColor = Color.PowderBlue;
                tic3Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player O win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(ploscLbl.Text);
                ploscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic1Btn.Text == "O" && tic4Btn.Text == "O" && tic7Btn.Text == "O")
            {
                tic1Btn.BackColor = Color.PowderBlue;
                tic4Btn.BackColor = Color.PowderBlue;
                tic7Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player O win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(ploscLbl.Text);
                ploscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic1Btn.Text == "O" && tic5Btn.Text == "O" && tic9Btn.Text == "O")
            {
                tic1Btn.BackColor = Color.PowderBlue;
                tic5Btn.BackColor = Color.PowderBlue;
                tic9Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player O win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(ploscLbl.Text);
                ploscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic2Btn.Text == "O" && tic5Btn.Text == "O" && tic8Btn.Text == "O")
            {
                tic2Btn.BackColor = Color.PowderBlue;
                tic5Btn.BackColor = Color.PowderBlue;
                tic8Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player O win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(ploscLbl.Text);
                ploscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic3Btn.Text == "O" && tic6Btn.Text == "O" && tic9Btn.Text == "O")
            {
                tic3Btn.BackColor = Color.PowderBlue;
                tic6Btn.BackColor = Color.PowderBlue;
                tic9Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player O win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(ploscLbl.Text);
                ploscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic4Btn.Text == "O" && tic5Btn.Text == "O" && tic6Btn.Text == "O")
            {
                tic4Btn.BackColor = Color.PowderBlue;
                tic5Btn.BackColor = Color.PowderBlue;
                tic6Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player O win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(ploscLbl.Text);
                ploscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic7Btn.Text == "O" && tic8Btn.Text == "O" && tic9Btn.Text == "O")
            {
                tic7Btn.BackColor = Color.PowderBlue;
                tic8Btn.BackColor = Color.PowderBlue;
                tic9Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player O win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(ploscLbl.Text);
                ploscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
            if (tic3Btn.Text == "O" && tic5Btn.Text == "O" && tic7Btn.Text == "O")
            {
                tic3Btn.BackColor = Color.PowderBlue;
                tic5Btn.BackColor = Color.PowderBlue;
                tic9Btn.BackColor = Color.PowderBlue;

                MessageBox.Show("Player O win", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entone = int.Parse(ploscLbl.Text);
                ploscLbl.Text = Convert.ToString(entone + 1);
                EnableFalse();
            }
        }
        public tictactoe()
        {
            InitializeComponent();
        }

        private void tictactoe_Load(object sender, EventArgs e)
        {

        }

        //Buttons text and scoreboard
        private void tic1Btn_Click(object sender, EventArgs e)
        {
            if(check == false)
            {
                tic1Btn.Text = "X";
                check = true;
            }
            else
            {
                tic1Btn.Text = "O";
                check = false;
            }
            Score();
            tic1Btn.Enabled = false;
        }

        private void tic2Btn_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                tic2Btn.Text = "X";
                check = true;
            }
            else
            {
                tic2Btn.Text = "O";
                check = false;
            }
            Score();
            tic2Btn.Enabled = false;
        }

        private void tic3Btn_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                tic3Btn.Text = "X";
                check = true;
            }
            else
            {
                tic3Btn.Text = "O";
                check = false;
            }
            Score();
            tic3Btn.Enabled = false;
        }

        private void tic4Btn_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                tic4Btn.Text = "X";
                check = true;
            }
            else
            {
                tic4Btn.Text = "O";
                check = false;
            }
            Score();
            tic4Btn.Enabled = false;
        }

        private void tic5Btn_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                tic5Btn.Text = "X";
                check = true;
            }
            else
            {
                tic5Btn.Text = "O";
                check = false;
            }
            Score();
            tic5Btn.Enabled = false;
        }

        private void tic6Btn_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                tic6Btn.Text = "X";
                check = true;
            }
            else
            {
                tic6Btn.Text = "O";
                check = false;
            }
            Score();
            tic6Btn.Enabled = false;
        }

        private void tic7Btn_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                tic7Btn.Text = "X";
                check = true;
            }
            else
            {
                tic7Btn.Text = "O";
                check = false;
            }
            Score();
            tic7Btn.Enabled = false;
        }

        private void tic8Btn_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                tic8Btn.Text = "X";
                check = true;
            }
            else
            {
                tic8Btn.Text = "O";
                check = false;
            }
            Score();
            tic8Btn.Enabled = false;
        }

        private void tic9Btn_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                tic9Btn.Text = "X";
                check = true;
            }
            else
            {
                tic9Btn.Text = "O";
                check = false;
            }
            Score();
            tic9Btn.Enabled = false;
        }

        //Game options
        private void newgameBtn_Click(object sender, EventArgs e)
        {
            tic1Btn.Enabled = true;
            tic2Btn.Enabled = true;
            tic3Btn.Enabled = true;
            tic4Btn.Enabled = true;
            tic5Btn.Enabled = true;
            tic6Btn.Enabled = true;
            tic7Btn.Enabled = true;
            tic8Btn.Enabled = true;
            tic9Btn.Enabled = true;

            tic1Btn.Text = "";
            tic2Btn.Text = "";
            tic3Btn.Text = "";
            tic4Btn.Text = "";
            tic5Btn.Text = "";
            tic6Btn.Text = "";
            tic7Btn.Text = "";
            tic8Btn.Text = "";
            tic9Btn.Text = "";

            plxscLbl.Text = "0";
            ploscLbl.Text = "0";

            newgameBtn.Enabled = true;

            tic1Btn.BackColor = Color.WhiteSmoke;
            tic2Btn.BackColor = Color.WhiteSmoke;
            tic3Btn.BackColor = Color.WhiteSmoke;
            tic4Btn.BackColor = Color.WhiteSmoke;
            tic5Btn.BackColor = Color.WhiteSmoke;
            tic6Btn.BackColor = Color.WhiteSmoke;
            tic7Btn.BackColor = Color.WhiteSmoke;
            tic8Btn.BackColor = Color.WhiteSmoke;
            tic9Btn.BackColor = Color.WhiteSmoke;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Do you want exit?", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(exit == DialogResult.OK)
            {
                startMenu ff = new startMenu();
                this.Hide();
                ff.ShowDialog();
                this.Close();
            }
            
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            tic1Btn.Enabled = true;
            tic2Btn.Enabled = true;
            tic3Btn.Enabled = true;
            tic4Btn.Enabled = true;
            tic5Btn.Enabled = true;
            tic6Btn.Enabled = true;
            tic7Btn.Enabled = true;
            tic8Btn.Enabled = true;
            tic9Btn.Enabled = true;

            tic1Btn.Text = "";
            tic2Btn.Text = "";
            tic3Btn.Text = "";
            tic4Btn.Text = "";
            tic5Btn.Text = "";
            tic6Btn.Text = "";
            tic7Btn.Text = "";
            tic8Btn.Text = "";
            tic9Btn.Text = "";

            newgameBtn.Enabled = true;

            tic1Btn.BackColor = Color.WhiteSmoke;
            tic2Btn.BackColor = Color.WhiteSmoke;
            tic3Btn.BackColor = Color.WhiteSmoke;
            tic4Btn.BackColor = Color.WhiteSmoke;
            tic5Btn.BackColor = Color.WhiteSmoke;
            tic6Btn.BackColor = Color.WhiteSmoke;
            tic7Btn.BackColor = Color.WhiteSmoke;
            tic8Btn.BackColor = Color.WhiteSmoke;
            tic9Btn.BackColor = Color.WhiteSmoke;
        }
    }
       
}
