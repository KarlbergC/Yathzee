using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yatzee.GameLogic
{
    class ScoreTable
    {
        public string UserName { get; set; }
        public int SingleScoreValue { get; set; }
        public int TotalScore { get; set; }
        public int TotalLowerScore { get; set; }
        public int TotalUpperScore { get; set; }
        public int Row { get; set; }
    }
}
