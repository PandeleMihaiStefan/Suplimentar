using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace TIcTacToe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Yellow;
        }
        String[] gameBoard = new string[9];
        int currentTurn = 0;
        public String ReturnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "0";
            }
            else
            {
                return "X";
            }
        }
        public void CheckWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                string combination = "";

                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        break;
                    case 1:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        break;
                    case 2:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        break;
                    case 3:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        break;
                    case 4:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        break;
                    case 5:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        break;
                    case 6:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        break;
                    case 7:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        break;
                }
                
                if (combination == "000")
                {
                    MessageBox.Show("0 a castigat!", "Castigator!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Reset();
                    break;
                }
                else if (combination == "XXX")
                {
                    MessageBox.Show("X a castigat!", "Castigator!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Reset();
                    break;
                }
                
            }
            checkDraw();
        }
        public void checkDraw()
        {
            int counter = 0;
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] != null)
                {
                    counter++;
                }
            }
            if (counter == gameBoard.Length)
            {
                MessageBox.Show("Nimeni nu a castigat.", "Egalitate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
            }
        }

        /// <summary>
        /// Reseteza jocul
        /// </summary>
        public void Reset()
        {
            button1.Text = ""; button1.Enabled = true;
            button2.Text = ""; button2.Enabled = true;
            button3.Text = ""; button3.Enabled = true;
            button4.Text = ""; button4.Enabled = true;
            button5.Text = ""; button5.Enabled = true;
            button6.Text = ""; button6.Enabled = true;
            button7.Text = ""; button7.Enabled = true;
            button8.Text = ""; button8.Enabled = true;
            button9.Text = ""; button9.Enabled = true;
            gameBoard = new string[9];
            currentTurn = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[0] = ReturnSymbol(currentTurn);
            button1.Text = gameBoard[0];
            button1.Enabled = false;
            CheckWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[1] = ReturnSymbol(currentTurn);
            button2.Text = gameBoard[1];
            button2.Enabled = false;
            CheckWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[2] = ReturnSymbol(currentTurn);
            button3.Text = gameBoard[2];
            button3.Enabled = false;
            CheckWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[3] = ReturnSymbol(currentTurn);
            button4.Text = gameBoard[3];
            button4.Enabled = false;
            CheckWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[4] = ReturnSymbol(currentTurn);
            button5.Text = gameBoard[4];
            button5.Enabled = false;
            CheckWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[5] = ReturnSymbol(currentTurn);
            button6.Text = gameBoard[5];
            button6.Enabled = false;
            CheckWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[6] = ReturnSymbol(currentTurn);
            button7.Text = gameBoard[6];
            button7.Enabled = false;
            CheckWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[7] = ReturnSymbol(currentTurn);
            button8.Text = gameBoard[7];
            button8.Enabled = false;
            CheckWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameBoard[8] = ReturnSymbol(currentTurn);
            button9.Text = gameBoard[8];
            button9.Enabled = false;
            CheckWinner();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
