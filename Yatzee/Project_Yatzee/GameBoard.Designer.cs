namespace Project_Yatzee
{
    partial class GameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.buttonRoll = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonUpperTotal = new System.Windows.Forms.Button();
            this.buttonBonus = new System.Windows.Forms.Button();
            this.buttonempty = new System.Windows.Forms.Button();
            this.buttonChance = new System.Windows.Forms.Button();
            this.button3Kind = new System.Windows.Forms.Button();
            this.button4Kind = new System.Windows.Forms.Button();
            this.buttonFullHouse = new System.Windows.Forms.Button();
            this.buttonSmallStraight = new System.Windows.Forms.Button();
            this.buttonLargeStraight = new System.Windows.Forms.Button();
            this.buttonYatzee = new System.Windows.Forms.Button();
            this.buttonLowerTotal = new System.Windows.Forms.Button();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelOpponent = new System.Windows.Forms.Label();
            this.buttonDice5 = new Project_Yatzee.DiceButton();
            this.buttonDice4 = new Project_Yatzee.DiceButton();
            this.buttonDice3 = new Project_Yatzee.DiceButton();
            this.buttonDice2 = new Project_Yatzee.DiceButton();
            this.buttonDice1 = new Project_Yatzee.DiceButton();
            this.SuspendLayout();
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(518, 120);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(75, 63);
            this.buttonRoll.TabIndex = 0;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Twos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Threes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Fours";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(44, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Fives";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(44, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Sixes";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonUpperTotal
            // 
            this.buttonUpperTotal.Location = new System.Drawing.Point(44, 168);
            this.buttonUpperTotal.Name = "buttonUpperTotal";
            this.buttonUpperTotal.Size = new System.Drawing.Size(75, 23);
            this.buttonUpperTotal.TabIndex = 3;
            this.buttonUpperTotal.Text = "Total Score";
            this.buttonUpperTotal.UseVisualStyleBackColor = true;
            // 
            // buttonBonus
            // 
            this.buttonBonus.Location = new System.Drawing.Point(44, 189);
            this.buttonBonus.Name = "buttonBonus";
            this.buttonBonus.Size = new System.Drawing.Size(75, 23);
            this.buttonBonus.TabIndex = 3;
            this.buttonBonus.Text = "Bonus";
            this.buttonBonus.UseVisualStyleBackColor = true;
            // 
            // buttonempty
            // 
            this.buttonempty.Location = new System.Drawing.Point(44, 208);
            this.buttonempty.Name = "buttonempty";
            this.buttonempty.Size = new System.Drawing.Size(75, 23);
            this.buttonempty.TabIndex = 3;
            this.buttonempty.Text = " ";
            this.buttonempty.UseVisualStyleBackColor = true;
            // 
            // buttonChance
            // 
            this.buttonChance.Location = new System.Drawing.Point(44, 229);
            this.buttonChance.Name = "buttonChance";
            this.buttonChance.Size = new System.Drawing.Size(75, 23);
            this.buttonChance.TabIndex = 3;
            this.buttonChance.Text = "Chance";
            this.buttonChance.UseVisualStyleBackColor = true;
            this.buttonChance.Click += new System.EventHandler(this.buttonChance_Click);
            // 
            // button3Kind
            // 
            this.button3Kind.Location = new System.Drawing.Point(44, 250);
            this.button3Kind.Name = "button3Kind";
            this.button3Kind.Size = new System.Drawing.Size(75, 23);
            this.button3Kind.TabIndex = 3;
            this.button3Kind.Text = "3 of a kind";
            this.button3Kind.UseVisualStyleBackColor = true;
            this.button3Kind.Click += new System.EventHandler(this.button3Kind_Click);
            // 
            // button4Kind
            // 
            this.button4Kind.Location = new System.Drawing.Point(44, 271);
            this.button4Kind.Name = "button4Kind";
            this.button4Kind.Size = new System.Drawing.Size(75, 23);
            this.button4Kind.TabIndex = 3;
            this.button4Kind.Text = "4 of a kind";
            this.button4Kind.UseVisualStyleBackColor = true;
            this.button4Kind.Click += new System.EventHandler(this.button4Kind_Click);
            // 
            // buttonFullHouse
            // 
            this.buttonFullHouse.Location = new System.Drawing.Point(44, 292);
            this.buttonFullHouse.Name = "buttonFullHouse";
            this.buttonFullHouse.Size = new System.Drawing.Size(75, 23);
            this.buttonFullHouse.TabIndex = 3;
            this.buttonFullHouse.Text = "Full House";
            this.buttonFullHouse.UseVisualStyleBackColor = true;
            this.buttonFullHouse.Click += new System.EventHandler(this.buttonFullHouse_Click);
            // 
            // buttonSmallStraight
            // 
            this.buttonSmallStraight.Location = new System.Drawing.Point(44, 313);
            this.buttonSmallStraight.Name = "buttonSmallStraight";
            this.buttonSmallStraight.Size = new System.Drawing.Size(75, 23);
            this.buttonSmallStraight.TabIndex = 3;
            this.buttonSmallStraight.Text = "Small Straight";
            this.buttonSmallStraight.UseVisualStyleBackColor = true;
            this.buttonSmallStraight.Click += new System.EventHandler(this.buttonSmallStraight_Click);
            // 
            // buttonLargeStraight
            // 
            this.buttonLargeStraight.Location = new System.Drawing.Point(44, 333);
            this.buttonLargeStraight.Name = "buttonLargeStraight";
            this.buttonLargeStraight.Size = new System.Drawing.Size(75, 23);
            this.buttonLargeStraight.TabIndex = 3;
            this.buttonLargeStraight.Text = "Large Straight";
            this.buttonLargeStraight.UseVisualStyleBackColor = true;
            this.buttonLargeStraight.Click += new System.EventHandler(this.buttonLargeStraight_Click);
            // 
            // buttonYatzee
            // 
            this.buttonYatzee.Location = new System.Drawing.Point(44, 352);
            this.buttonYatzee.Name = "buttonYatzee";
            this.buttonYatzee.Size = new System.Drawing.Size(75, 23);
            this.buttonYatzee.TabIndex = 3;
            this.buttonYatzee.Text = "Yatzee!";
            this.buttonYatzee.UseVisualStyleBackColor = true;
            this.buttonYatzee.Click += new System.EventHandler(this.buttonYatzee_Click);
            // 
            // buttonLowerTotal
            // 
            this.buttonLowerTotal.Location = new System.Drawing.Point(44, 374);
            this.buttonLowerTotal.Name = "buttonLowerTotal";
            this.buttonLowerTotal.Size = new System.Drawing.Size(75, 23);
            this.buttonLowerTotal.TabIndex = 3;
            this.buttonLowerTotal.Text = "Total Score Lower";
            this.buttonLowerTotal.UseVisualStyleBackColor = true;
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(44, 394);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(75, 23);
            this.buttonTotal.TabIndex = 3;
            this.buttonTotal.Text = "Grand Total";
            this.buttonTotal.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(118, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 18;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(50, 379);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(239, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 18;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(61, 379);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(122, 26);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(36, 13);
            this.labelPlayer.TabIndex = 4;
            this.labelPlayer.Text = "Player";
            // 
            // labelOpponent
            // 
            this.labelOpponent.AutoSize = true;
            this.labelOpponent.Location = new System.Drawing.Point(241, 25);
            this.labelOpponent.Name = "labelOpponent";
            this.labelOpponent.Size = new System.Drawing.Size(54, 13);
            this.labelOpponent.TabIndex = 4;
            this.labelOpponent.Text = "Opponent";
            // 
            // buttonDice5
            // 
            this.buttonDice5.HoldState = false;
            this.buttonDice5.Location = new System.Drawing.Point(352, 374);
            this.buttonDice5.Name = "buttonDice5";
            this.buttonDice5.Size = new System.Drawing.Size(75, 71);
            this.buttonDice5.TabIndex = 1;
            this.buttonDice5.UseVisualStyleBackColor = true;
            this.buttonDice5.Value = 0;
            this.buttonDice5.Click += new System.EventHandler(this.buttonDice_Click);
            // 
            // buttonDice4
            // 
            this.buttonDice4.HoldState = false;
            this.buttonDice4.Location = new System.Drawing.Point(352, 283);
            this.buttonDice4.Name = "buttonDice4";
            this.buttonDice4.Size = new System.Drawing.Size(75, 69);
            this.buttonDice4.TabIndex = 1;
            this.buttonDice4.UseVisualStyleBackColor = true;
            this.buttonDice4.Value = 0;
            this.buttonDice4.Click += new System.EventHandler(this.buttonDice_Click);
            // 
            // buttonDice3
            // 
            this.buttonDice3.HoldState = false;
            this.buttonDice3.Location = new System.Drawing.Point(352, 199);
            this.buttonDice3.Name = "buttonDice3";
            this.buttonDice3.Size = new System.Drawing.Size(75, 65);
            this.buttonDice3.TabIndex = 1;
            this.buttonDice3.UseVisualStyleBackColor = true;
            this.buttonDice3.Value = 0;
            this.buttonDice3.Click += new System.EventHandler(this.buttonDice_Click);
            // 
            // buttonDice2
            // 
            this.buttonDice2.HoldState = false;
            this.buttonDice2.Location = new System.Drawing.Point(352, 108);
            this.buttonDice2.Name = "buttonDice2";
            this.buttonDice2.Size = new System.Drawing.Size(75, 65);
            this.buttonDice2.TabIndex = 1;
            this.buttonDice2.UseVisualStyleBackColor = true;
            this.buttonDice2.Value = 0;
            this.buttonDice2.Click += new System.EventHandler(this.buttonDice_Click);
            // 
            // buttonDice1
            // 
            this.buttonDice1.HoldState = false;
            this.buttonDice1.Location = new System.Drawing.Point(354, 25);
            this.buttonDice1.Name = "buttonDice1";
            this.buttonDice1.Size = new System.Drawing.Size(75, 61);
            this.buttonDice1.TabIndex = 1;
            this.buttonDice1.UseVisualStyleBackColor = true;
            this.buttonDice1.Value = 0;
            this.buttonDice1.Click += new System.EventHandler(this.buttonDice_Click);
            this.buttonDice1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDice1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(673, 477);
            this.Controls.Add(this.labelOpponent);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.buttonTotal);
            this.Controls.Add(this.buttonLowerTotal);
            this.Controls.Add(this.buttonYatzee);
            this.Controls.Add(this.buttonLargeStraight);
            this.Controls.Add(this.buttonSmallStraight);
            this.Controls.Add(this.buttonFullHouse);
            this.Controls.Add(this.button4Kind);
            this.Controls.Add(this.button3Kind);
            this.Controls.Add(this.buttonChance);
            this.Controls.Add(this.buttonempty);
            this.Controls.Add(this.buttonBonus);
            this.Controls.Add(this.buttonUpperTotal);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonDice5);
            this.Controls.Add(this.buttonDice4);
            this.Controls.Add(this.buttonDice3);
            this.Controls.Add(this.buttonDice2);
            this.Controls.Add(this.buttonDice1);
            this.Controls.Add(this.buttonRoll);
            this.Name = "Form1";
            this.Text = "Yahtzee!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRoll;
        private DiceButton buttonDice1;
        private DiceButton buttonDice2;
        private DiceButton buttonDice3;
        private DiceButton buttonDice4;
        private DiceButton buttonDice5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonUpperTotal;
        private System.Windows.Forms.Button buttonBonus;
        private System.Windows.Forms.Button buttonempty;
        private System.Windows.Forms.Button buttonChance;
        private System.Windows.Forms.Button button3Kind;
        private System.Windows.Forms.Button button4Kind;
        private System.Windows.Forms.Button buttonFullHouse;
        private System.Windows.Forms.Button buttonSmallStraight;
        private System.Windows.Forms.Button buttonLargeStraight;
        private System.Windows.Forms.Button buttonYatzee;
        private System.Windows.Forms.Button buttonLowerTotal;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelOpponent;
    }
}

