using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yatzee.GameLogic
{
    class CalculateScore
    {
        public int Total { get; set; }
        public int UpperTotal { get; set; }
        public int LowerTotal { get; set; }
        public bool UpperBonus { get; set; }

        public void UpdateTotals(int Score, bool UpperScore)
        {
            if (UpperScore == true)
            {
                UpperTotal += Score;
                if (UpperTotal >= 63)
                    UpperBonus = true;
            }
            else
            {
                LowerTotal += Score;
            }

            Total = 0;
            Total += UpperTotal;
            if (UpperBonus == true)
                Total += 35;
            Total += LowerTotal;
        }

        public int AddUpDice(int DieNumber, List<DiceButton> myDice)
        {
            int Sum = 0;

            for (int i = 0; i < 5; i++)
            {
                if (myDice[i].Value == DieNumber)
                {
                    Sum += DieNumber;
                }
            }

            return Sum;
        }

        ///
        /// Routine to calculate Three of a Kind Score
        ///
        public int CalculateThreeOfAKind(List<DiceButton> myDice)
        {
            int Sum = 0;

            for (int i = 1; i < 7; i++)
            {
                if (myDice.Where(x => x.Value == i).Count() > 2)
                {
                    Sum = 3 * i;
                    break;
                }
            }

            return Sum;
        }

        ///
        /// Routine to calculate Four of a Kind Score
        ///
        public int CalculateFourOfAKind(List<DiceButton> myDice)
        {
            int Sum = 0;

            for (int i = 1; i < 7; i++)
            {
                if(myDice.Where(x => x.Value == i).Count() > 3)
                {
                    Sum = 4 * i;
                    break;
                }
            }

            return Sum;
        }

        ///
        /// Routine to calculate Full House Score - fixed score 25 
        ///
        public int CalculateFullHouse(List<DiceButton> myDice)
        {
            int Sum = 0;

            int[] i = new int[5];

            i[0] = myDice[0].Value;
            i[1] = myDice[1].Value;
            i[2] = myDice[2].Value;
            i[3] = myDice[3].Value;
            i[4] = myDice[4].Value;

            Array.Sort(i);

            if ((((i[0] == i[1]) && (i[1] == i[2])) && // Three of a Kind
                 (i[3] == i[4]) && // Two of a Kind
                 (i[2] != i[3])) ||
                ((i[0] == i[1]) && // Two of a Kind
                 ((i[2] == i[3]) && (i[3] == i[4])) && // Three of a Kind
                 (i[1] != i[2])))
            {
                Sum = 25;
            }

            return Sum;
        }

        ///
        /// Routine to calculate Small Straight Score
        ///
        public int CalculateSmallStraight(List<DiceButton> myDice)
        {
            int Sum = 0;

            int[] i = new int[5];

            i[0] = myDice[0].Value;
            i[1] = myDice[1].Value;
            i[2] = myDice[2].Value;
            i[3] = myDice[3].Value;
            i[4] = myDice[4].Value;

            Array.Sort(i);

            // Problem can arise hear, if there is more than one of the same number, so
            // we must move any doubles to the end
            for (int j = 0; j < 4; j++)
            {
                int temp = 0;
                if (i[j] == i[j + 1])
                {
                    temp = i[j];

                    for (int k = j; k < 4; k++)
                    {
                        i[k] = i[k + 1];
                    }

                    i[4] = temp;
                }
            }

            if (((i[0] == 1) && (i[1] == 2) && (i[2] == 3) && (i[3] == 4)) ||
                ((i[0] == 2) && (i[1] == 3) && (i[2] == 4) && (i[3] == 5)) ||
                ((i[0] == 3) && (i[1] == 4) && (i[2] == 5) && (i[3] == 6)) ||
                ((i[1] == 1) && (i[2] == 2) && (i[3] == 3) && (i[4] == 4)) ||
                ((i[1] == 2) && (i[2] == 3) && (i[3] == 4) && (i[4] == 5)) ||
                ((i[1] == 3) && (i[2] == 4) && (i[3] == 5) && (i[4] == 6)))
            {
                Sum = 15;
            }

            return Sum;
        }

        ///
        /// Routine to calculate Large Straight Score 
        ///
        public int CalculateLargeStraight(List<DiceButton> myDice)
        {
            int Sum = 0;

            int[] i = new int[5];

            i[0] = myDice[0].Value;
            i[1] = myDice[1].Value;
            i[2] = myDice[2].Value;
            i[3] = myDice[3].Value;
            i[4] = myDice[4].Value;

            Array.Sort(i);

            if (((i[0] == 1) && (i[1] == 2) && (i[2] == 3) && (i[3] == 4) && (i[4] == 5)) ||
                ((i[0] == 2) && (i[1] == 3) && (i[2] == 4) && (i[3] == 5) && (i[4] == 6)))
            {
                Sum = 25;
            }

            return Sum;
        }

        ///
        /// Routine to calculate Yahtzee Score
        ///
        public int CalculateYahtzee(List<DiceButton> myDice)
        {
            int Sum = 0;

            for (int i = 1; i <= 6; i++)
            {
                int Count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (myDice[j].Value == i)
                        Count++;

                    if (Count > 4)
                        Sum = 50;
                }
            }

            return Sum;
        }

        public int AddUpChance(List<DiceButton> myDice)
        {
            int Sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Sum += myDice[i].Value;
            }

            return Sum;
        }
    }

}

