using SQLHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Yatzee
{
    public partial class GameLobby : Form
    {
        public string UserName { get; set; }
        public string IPAddress { get; set; }
        public GameLobby()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            UserName = textBoxUsernameInput.Text;
            IPAddress = textBoxIPAddress.Text;
        }
        private void GameLobby_Load(object sender, EventArgs e)
        {
            var tmpList = SQLUtils.LoadHighscores()
                .OrderByDescending(o => o.HighScore);
            
            foreach (var highscore in tmpList)
            {
                listBoxHighscores.Items.Add(highscore.HighScore + ", " + highscore.UserName);
            }
        }


    }
}
