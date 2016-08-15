using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHandler
{
    public class Highscore
    {
        public string UserName { get; set; }
        public int HighScore { get; set; }

        public Highscore(string username, int highscore)
        {
            UserName = username;
            HighScore = highscore;
        }
    }
}
