using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yatzee.GameLogic
{
    public class Dice : System.Windows.Forms.UserControl
    {
        private bool m_bHoldState = false;

        public bool HoldState
        {
            get { return m_bHoldState; }
            set { m_bHoldState = value; }
        }

        public int DiceRoll()
        {
            int result;
            Random rnd = new Random();
            result = rnd.Next(1, 7);
            return result;
        }


    }
}
