using Project_Yatzee.GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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
        TcpClient client;
        public int counter;
        public int counterClicked = 0;
        ScoreTable scoreTable = new ScoreTable();
       // public List<DiceButton> diceButtonMessage = new List<DiceButton>();
        CalculateScore score = new CalculateScore();
        public List<TextBox> textBoxList1 = new List<TextBox>();
        public List<TextBox> textBoxList2 = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();
        }

        public void CreateButtonList()
        {
            clientPlayer.diceButtonMessage.Add(buttonDice1);
            clientPlayer.diceButtonMessage.Add(buttonDice1);
            clientPlayer.diceButtonMessage.Add(buttonDice2);
            clientPlayer.diceButtonMessage.Add(buttonDice3);
            clientPlayer.diceButtonMessage.Add(buttonDice4);
            clientPlayer.diceButtonMessage.Add(buttonDice5);
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

            foreach (var button in clientPlayer.diceButtonMessage)
            {
                if (!button.HoldState)
                {
                    button.Value = rnd.Next(1, 7);
                    Dice dice = new Dice();
                    button.Text = button.Value.ToString();
                    clientPlayer.EnabledPanelContents(this, true);

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
                scoreTable.SingleScoreValue = score.AddUpDice(1, clientPlayer.diceButtonMessage);

                tableLayoutPanel1.Controls[0].Text = scoreTable.SingleScoreValue.ToString();
                CalculateTotal(scoreTable.SingleScoreValue);
                CalulateTotalUpper(scoreTable.SingleScoreValue);
                scoreTable.Row = 0;
                clientPlayer.Send(scoreTable);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            clientPlayer = new Client(this);
            CreateButtonList();

            //TextBox Text1 = new TextBox();
            //tableLayoutPanel1.Controls.Add(Text1, 0, 0);

            //TextBox TB = sender as TextBox;
            //int index = this.tableLayoutPanel1.Controls.GetChildIndex(TB);

            int rowIndex = 0;
            int columnIndex = 0;
            for (int i = 0; i < 18; i++)
            {
                TextBox Text = new TextBox();
                textBoxList1.Add(Text);
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
            int rowIndex2 = 0;
            int columnIndex2 = 0;
            for (int i = 0; i < 18; i++)
            {
                TextBox Text = new TextBox();
                textBoxList2.Add(Text);
                Text.Name = "text+" + i + 1;
                //Text.TextChanged += new System.EventHandler(this.TB_TextChanged);
                if (i % 2 == 0 && i > 0)
                    rowIndex2++;
                if (i % 2 != 0 && i > 0)
                    columnIndex2++;
                else
                    columnIndex2 = 0;
                this.tableLayoutPanel2.Controls.Add(Text, columnIndex2, rowIndex2);
            }
            clientPlayer.Start();
            //skriv ip address etc
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[1].Text == ""))
            {
                scoreTable.SingleScoreValue = score.AddUpDice(2, clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[1].Text = scoreTable.SingleScoreValue.ToString();
                CalculateTotal(scoreTable.SingleScoreValue);
                CalulateTotalUpper(scoreTable.SingleScoreValue);
                scoreTable.Row = 1;
                clientPlayer.Send(scoreTable);
                //foreach (var item in Controls)
                //{
                //    ((Control)item).Enabled = false;
                //}
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[2].Text == ""))
            {
                scoreTable.SingleScoreValue = score.AddUpDice(3, clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[2].Text = scoreTable.SingleScoreValue.ToString();
                CalculateTotal(scoreTable.SingleScoreValue);
                CalulateTotalUpper(scoreTable.SingleScoreValue);
                scoreTable.Row = 2;
                clientPlayer.Send(scoreTable);
            }
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[3].Text == ""))
            {
                scoreTable.SingleScoreValue = score.AddUpDice(4, clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[3].Text = scoreTable.SingleScoreValue.ToString();
                CalculateTotal(scoreTable.SingleScoreValue);
                CalulateTotalUpper(scoreTable.SingleScoreValue);
                scoreTable.Row = 3;
                clientPlayer.Send(scoreTable);
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
            foreach (var listButton in clientPlayer.diceButtonMessage)
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
                scoreTable.SingleScoreValue = score.AddUpDice(5, clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[4].Text = scoreTable.SingleScoreValue.ToString();
                CalculateTotal(scoreTable.SingleScoreValue);
                CalulateTotalUpper(scoreTable.SingleScoreValue);
                scoreTable.Row = 4;
                clientPlayer.Send(scoreTable);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[5].Text == ""))
            {
                scoreTable.SingleScoreValue = score.AddUpDice(6, clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[5].Text = scoreTable.SingleScoreValue.ToString();
                CalculateTotal(scoreTable.SingleScoreValue);
                CalulateTotalUpper(scoreTable.SingleScoreValue);
                scoreTable.Row = 5;
                clientPlayer.Send(scoreTable);
            }
        }

        private void button3Kind_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[10].Text == ""))
            {
                scoreTable.SingleScoreValue = score.CalculateThreeOfAKind(clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[10].Text = scoreTable.SingleScoreValue.ToString();
                CalculateTotal(scoreTable.SingleScoreValue);
                CalulateTotalLower(scoreTable.SingleScoreValue);
                scoreTable.Row = 10;
                clientPlayer.Send(scoreTable);
            }
        }

        private void button4Kind_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[11].Text == ""))
            {
                scoreTable.SingleScoreValue = score.CalculateFourOfAKind(clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[11].Text = scoreTable.SingleScoreValue.ToString();

                CalulateTotalLower(scoreTable.SingleScoreValue);
                CalculateTotal(scoreTable.SingleScoreValue);
                scoreTable.Row = 11;
                clientPlayer.Send(scoreTable);
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
                scoreTable.SingleScoreValue = score.CalculateFullHouse(clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[12].Text = scoreTable.SingleScoreValue.ToString();
                CalulateTotalLower(scoreTable.SingleScoreValue);
                CalculateTotal(scoreTable.SingleScoreValue);
                scoreTable.Row = 12;
                clientPlayer.Send(scoreTable);
            }
        }

        private void buttonSmallStraight_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[13].Text == ""))
            {
                scoreTable.SingleScoreValue = score.CalculateSmallStraight(clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[13].Text = scoreTable.SingleScoreValue.ToString();
                CalulateTotalLower(scoreTable.SingleScoreValue);
                CalculateTotal(scoreTable.SingleScoreValue);
                scoreTable.Row = 13;
                clientPlayer.Send(scoreTable);
            }
        }

        private void buttonLargeStraight_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[14].Text == ""))
            {
                scoreTable.SingleScoreValue = score.CalculateLargeStraight(clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[14].Text = scoreTable.SingleScoreValue.ToString();
                CalulateTotalLower(scoreTable.SingleScoreValue);
                CalculateTotal(scoreTable.SingleScoreValue);
                scoreTable.Row = 14;
                clientPlayer.Send(scoreTable);
            }
        }

        private void buttonYatzee_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[15].Text == ""))
            {
                scoreTable.SingleScoreValue = score.CalculateYahtzee(clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[15].Text = scoreTable.SingleScoreValue.ToString();
                CalulateTotalLower(scoreTable.SingleScoreValue);
                CalculateTotal(scoreTable.SingleScoreValue);
                scoreTable.Row = 15;
                clientPlayer.Send(scoreTable);
            }
        }

        private void buttonChance_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[9].Text == ""))
            {
                scoreTable.SingleScoreValue = score.AddUpChance(clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[9].Text = scoreTable.SingleScoreValue.ToString();

                CalulateTotalLower(scoreTable.SingleScoreValue);

                CalculateTotal(scoreTable.SingleScoreValue);
                scoreTable.Row = 9;
                clientPlayer.Send(scoreTable);
                //int temp = Convert.ToInt32(tableLayoutPanel1.Controls[16].Text) +displayScore;
                //tableLayoutPanel1.Controls[16].Text += temp.ToString();
            }
        }


        private void buttonBonus_Click(object sender, EventArgs e)
        {
            if (scoreTable.TotalUpperScore >= 63)
            {
                tableLayoutPanel1.Controls[7].Text = "50";
                CalculateTotal(50);
                scoreTable.Row = 7;
            }
            clientPlayer.Send(scoreTable);
        }
    }
}
