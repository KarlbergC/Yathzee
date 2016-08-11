using Project_Yatzee.GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Project_Yatzee
{
    public partial class Form1 : Form
    {
        Client clientPlayer;
        public int counter;
        public int counterClicked = 0;
        //public int TotalScore;
        //public int TotalLowerScore;
        //public int TotalUpperScore;
        ScoreTable scoreTable = new ScoreTable();
        public List<DiceButton> buttonList = new List<DiceButton>();
        CalculateScore score = new CalculateScore();

        public Form1()
        {
            InitializeComponent();
            CreateButtonList();
        }

        public void CreateButtonList()
        {
            buttonList.Add(buttonDice1);
            buttonList.Add(buttonDice2);
            buttonList.Add(buttonDice3);
            buttonList.Add(buttonDice4);
            buttonList.Add(buttonDice5);
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter < 4)
            {
                RollDice();
                counterClicked = 0;
            }
            else
                MessageBox.Show("No more throws");
        }

        private void RollDice()
        {
            Random rnd = new Random();

            foreach (var button in buttonList)
            {
                if (!button.HoldState)
                {
                    button.Value = rnd.Next(1, 7);
                    Dice dice = new Dice();
                    button.Text = button.Value.ToString();
                }
            }
        }

        private void buttonDice_Click(object sender, EventArgs e)
        {

            DiceButton diceButton = sender as DiceButton;
            diceButton.HoldState = !diceButton.HoldState;

            if (diceButton.HoldState)
            {
                diceButton.BackColor = Color.White;

            }
            else
                diceButton.BackColor = Color.LightGray;
        }


        private void buttonDice1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if(checkBox1.Checked)
            //{
            //    DiceButton dice = new DiceButton();
            //    dice.HoldState = true;
            //    //RollDice();
            //}

            //this.Controls
        }

        private void buttonDice2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[0].Text == ""))
            {
                int displayScore = score.AddUpDice(1, buttonList);
                tableLayoutPanel1.Controls[0].Text = displayScore.ToString();
                CalculateTotal(displayScore);
                CalulateTotalUpper(displayScore);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TextBox Text1 = new TextBox();
            //tableLayoutPanel1.Controls.Add(Text1, 0, 0);

            //TextBox TB = sender as TextBox;
            //int index = this.tableLayoutPanel1.Controls.GetChildIndex(TB);

            int rowIndex = 0;
            int columnIndex = 0;
            for (int i = 0; i < 18; i++)
            {
                TextBox Text = new TextBox();
                Text.Name = "text+" + i + 1;
                //Text.TextChanged += new System.EventHandler(this.TB_TextChanged);
                if (i % 2 == 0 && i > 0)
                    rowIndex++;
                if (i % 2 != 0 && i > 0)
                    columnIndex++;
                else
                    columnIndex = 0;
                this.tableLayoutPanel1.Controls.Add(Text, columnIndex, rowIndex);
            }

            //skriv ip address etc
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[1].Text == ""))
            {
                int displayScore = score.AddUpDice(2, buttonList);
                tableLayoutPanel1.Controls[1].Text = displayScore.ToString();
                CalculateTotal(displayScore);
                CalulateTotalUpper(displayScore);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[2].Text == ""))
            {
                int displayScore = score.AddUpDice(3, buttonList);
                tableLayoutPanel1.Controls[2].Text = displayScore.ToString();
                CalculateTotal(displayScore);
                CalulateTotalUpper(displayScore);
            }
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[3].Text == ""))
            {
                int displayScore = score.AddUpDice(4, buttonList);
                tableLayoutPanel1.Controls[3].Text = displayScore.ToString();
                CalculateTotal(displayScore);
                CalulateTotalUpper(displayScore);
            }
        }

        private void CalculateTotal(int displayScore)
        {
            if (counterClicked == 0)
            {
                scoreTable.TotalScore += displayScore;
                tableLayoutPanel1.Controls[17].Text = scoreTable.TotalScore.ToString();
                counter = 0;
                counterClicked = 1;
                ResetDice();
            } 
        }

        private void ResetDice()
        {
            foreach (var listButton in buttonList)
            {
                listButton.HoldState = false;
                listButton.BackColor = Color.LightGray;
                listButton.Value = 0;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[4].Text == ""))
            {
                int displayScore = score.AddUpDice(5, buttonList);
                tableLayoutPanel1.Controls[4].Text = displayScore.ToString();
                CalculateTotal(displayScore);
                CalulateTotalUpper(displayScore);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[5].Text == ""))
            {
                int displayScore = score.AddUpDice(6, buttonList);
                tableLayoutPanel1.Controls[5].Text = displayScore.ToString();
                CalculateTotal(displayScore);
                CalulateTotalUpper(displayScore);
            }
        }

        private void button3Kind_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[10].Text == ""))
            {
                int displayScore = score.CalculateThreeOfAKind(buttonList);
                tableLayoutPanel1.Controls[10].Text = displayScore.ToString();
                CalculateTotal(displayScore);
                CalulateTotalLower(displayScore);
            }
        }

        private void button4Kind_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[11].Text == ""))
            {
                int displayScore = score.CalculateFourOfAKind(buttonList);
                tableLayoutPanel1.Controls[11].Text = displayScore.ToString();

                CalulateTotalLower(displayScore);
                CalculateTotal(displayScore);
                clientPlayer.SendMessage();
            }
        }

        private void CalulateTotalLower(int displayScore)
        {
            scoreTable.TotalLowerScore += displayScore;
            tableLayoutPanel1.Controls[16].Text = scoreTable.TotalLowerScore.ToString();
        }

        private void CalulateTotalUpper(int displayScore)
        {
            scoreTable.TotalUpperScore += displayScore;
            tableLayoutPanel1.Controls[6].Text = scoreTable.TotalUpperScore.ToString();
        }

        private void buttonFullHouse_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[12].Text == ""))
            {
                int displayScore = score.CalculateFullHouse(buttonList);
                tableLayoutPanel1.Controls[12].Text = displayScore.ToString();
                CalulateTotalLower(displayScore);
                CalculateTotal(displayScore);
            }
        }

        private void buttonSmallStraight_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[13].Text == ""))
            {
                int displayScore = score.CalculateSmallStraight(buttonList);
                tableLayoutPanel1.Controls[13].Text = displayScore.ToString();
                CalulateTotalLower(displayScore);
                CalculateTotal(displayScore);
            }
        }

        private void buttonLargeStraight_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[14].Text == ""))
            {
                int displayScore = score.CalculateLargeStraight(buttonList);
                tableLayoutPanel1.Controls[14].Text = displayScore.ToString();
                CalulateTotalLower(displayScore);
                CalculateTotal(displayScore);
            }
        }

        private void buttonYatzee_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[15].Text == ""))
            {
                int displayScore = score.CalculateYahtzee(buttonList);
                tableLayoutPanel1.Controls[15].Text = displayScore.ToString();
                CalulateTotalLower(displayScore);
                CalculateTotal(displayScore);
            }
        }

        private void buttonChance_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[9].Text == ""))
            {
                int displayScore = score.AddUpChance(buttonList);
                tableLayoutPanel1.Controls[9].Text = displayScore.ToString();

                CalulateTotalLower(displayScore);

                CalculateTotal(displayScore);
                //int temp = Convert.ToInt32(tableLayoutPanel1.Controls[16].Text) +displayScore;
                //tableLayoutPanel1.Controls[16].Text += temp.ToString();
            }
        }
        private void AddToTotal(int position, int scoreToAdd, bool LowerScore)
        {

        }

        private void buttonBonus_Click(object sender, EventArgs e)
        {
            if (scoreTable.TotalUpperScore >= 63)
            {
                tableLayoutPanel1.Controls[7].Text = "50";
                CalculateTotal(50);
            }
        }
    }
}
