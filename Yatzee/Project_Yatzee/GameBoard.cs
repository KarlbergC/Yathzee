﻿using Project_Yatzee.GameLogic;
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
    public partial class GameBoard : Form
    {
        Client clientPlayer;
        public int counter;
        public int counterClicked = 0;
        ScoreTable scoreTable = new ScoreTable();
        CalculateScore score = new CalculateScore();
        public List<TextBox> playerScoreList = new List<TextBox>();
        public List<TextBox> opponentScoreList = new List<TextBox>();
        public Label opponentUserName = new Label();

        public GameBoard()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void GameBoard_Load(object sender, EventArgs e)
        {
            string ipAdress= "";
            using (GameLobby lobby = new GameLobby())
            {
                if (lobby.ShowDialog() == DialogResult.OK)
                {
                    labelPlayer.Text = lobby.UserName;
                    scoreTable.UserName = lobby.UserName;
                    ipAdress = lobby.IPAddress;
                }
            }
            clientPlayer = new Client(this);
            CreateButtonList();

            this.labelOpponent = opponentUserName;

            int rowIndex = 0;
            int columnIndex = 0;
            for (int i = 0; i < 18; i++)
            {
                TextBox Text = new TextBox();
                playerScoreList.Add(Text);
                Text.Name = "text+" + i + 1;
               
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
                opponentScoreList.Add(Text);
                Text.Name = "text+" + i + 1;
                
                if (i % 2 == 0 && i > 0)
                    rowIndex2++;
                if (i % 2 != 0 && i > 0)
                    columnIndex2++;
                else
                    columnIndex2 = 0;
                this.tableLayoutPanel2.Controls.Add(Text, columnIndex2, rowIndex2);
            }
            clientPlayer.Start(ipAdress);
        }
        public void CreateButtonList()
        {
            clientPlayer.diceButtonMessage.Add(buttonDice1);
            clientPlayer.diceButtonMessage.Add(buttonDice2);
            clientPlayer.diceButtonMessage.Add(buttonDice3);
            clientPlayer.diceButtonMessage.Add(buttonDice4);
            clientPlayer.diceButtonMessage.Add(buttonDice5);
        }
        private void buttonDice_Click(object sender, EventArgs e)
        {

            DiceButton diceButton = sender as DiceButton;
            diceButton.HoldState = !diceButton.HoldState;

            if (diceButton.HoldState)
            {
                diceButton.BackColor = Color.IndianRed;

            }
            else
                diceButton.BackColor = Color.LightGray;
        }
        private void ScoreHandler(int index, Func<List<DiceButton>, int> compute)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[index].Text == ""))
            {
                scoreTable.SingleScoreValue = compute(clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[index].Text = scoreTable.SingleScoreValue.ToString();
                CalulateTotalLower(scoreTable.SingleScoreValue);
                CalculateTotal(scoreTable.SingleScoreValue);
                scoreTable.Row = index;
                clientPlayer.Send(scoreTable);
            }
        }
        private void UpperScoreHandler(int index, int chosenDiceValue)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[index].Text == ""))
            {
                scoreTable.SingleScoreValue = score.AddUpDice(chosenDiceValue, clientPlayer.diceButtonMessage);
                tableLayoutPanel1.Controls[index].Text = scoreTable.SingleScoreValue.ToString();
                CalculateTotal(scoreTable.SingleScoreValue);
                CalulateTotalUpper(scoreTable.SingleScoreValue);
                scoreTable.Row = index;
                clientPlayer.Send(scoreTable);
            }
        }
        private void buttonDice1_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpperScoreHandler(0, 1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UpperScoreHandler(1, 2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UpperScoreHandler(2, 3);
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            UpperScoreHandler(3, 4);
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            UpperScoreHandler(4, 5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            UpperScoreHandler(5, 6);
        }
        private void button3Kind_Click(object sender, EventArgs e)
        {
            ScoreHandler(10, score.CalculateThreeOfAKind);

        }
        private void button4Kind_Click(object sender, EventArgs e)
        {
            ScoreHandler(11, score.CalculateFourOfAKind);
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

            if (scoreTable.TotalUpperScore >= 63)
            {
                tableLayoutPanel1.Controls[7].Text = "50";
                CalculateTotal(50);
                scoreTable.Row = 7;
            }
        }
        private void buttonSmallStraight_Click(object sender, EventArgs e)
        {
            ScoreHandler(13, score.CalculateSmallStraight);
        }
        private void buttonLargeStraight_Click(object sender, EventArgs e)
        {
            ScoreHandler(14, score.CalculateLargeStraight);
        }
        private void buttonFullHouse_Click(object sender, EventArgs e)
        {
            ScoreHandler(12, score.CalculateFullHouse);
        }
        private void buttonChance_Click(object sender, EventArgs e)
        {
            ScoreHandler(9, score.AddUpChance);
        }
        private void buttonYatzee_Click(object sender, EventArgs e)
        {
            ScoreHandler(15, score.CalculateYahtzee);
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

                    switch (button.Value)
                    {
                        case 1:
                            button.Image = Image.FromFile(@"C:\Users\Administrator\Source\Repos\Yathzee\Yatzee\Project_Yatzee\Images\die1.jpg");
                            break;
                        case 2:
                            button.Image = Image.FromFile(@"C:\Users\Administrator\Source\Repos\Yathzee\Yatzee\Project_Yatzee\Images\die2.jpg");
                            break;
                        case 3:
                            button.Image = Image.FromFile(@"C:\Users\Administrator\Source\Repos\Yathzee\Yatzee\Project_Yatzee\Images\die3.jpg");
                            break;
                        case 4:
                            button.Image = Image.FromFile(@"C:\Users\Administrator\Source\Repos\Yathzee\Yatzee\Project_Yatzee\Images\die4.jpg");
                            break;
                        case 5:
                            button.Image = Image.FromFile(@"C:\Users\Administrator\Source\Repos\Yathzee\Yatzee\Project_Yatzee\Images\die5.jpg");
                            break;
                        case 6:
                            button.Image = Image.FromFile(@"C:\Users\Administrator\Source\Repos\Yathzee\Yatzee\Project_Yatzee\Images\die6.jpg");
                            break;
                    }
                }
            }
        }


    }
}
