using Newtonsoft.Json;
using Project_Yatzee.GameLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Project_Yatzee
{
    class Client
    {
        ScoreTable scoreTableMessage;
        public List<DiceButton> diceButtonMessage = new List<DiceButton>();
        private TcpClient client;
        private string ipAddress;
        private GameBoard gameBoard;
        int port;

        public Client(GameBoard gameBoard)
        {
            this.gameBoard = gameBoard;
        }
        public Client(string ipAddress, GameBoard gameBoard, ScoreTable scoreTableMessage, List<DiceButton> diceButtonMessage, int port = 5000)
        {
            this.ipAddress = ipAddress;
            this.scoreTableMessage = scoreTableMessage;
            this.port = port;
            this.gameBoard = gameBoard;

            this.Start(this.ipAddress);
        }

        public void Start(string ipAdress)
        {
            client = new TcpClient(ipAdress, 5000);

            Thread senderThread = new Thread(Listen);
            senderThread.Start();
        }

        public void Send(ScoreTable scoreTableMessage)
        {
            try
            {
                NetworkStream n = client.GetStream();
                BinaryWriter w = new BinaryWriter(n);
            
                string jSonString = JsonConvert.SerializeObject(scoreTableMessage);
                w.Write(jSonString);
                w.Flush();
                DisablePanelContents(gameBoard);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void Listen()
        {
            string message = "";
            try
            {
                while (!message.ToLower().StartsWith("the"))
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();
                    if (!message.ToLower().StartsWith("the"))
                    {
                        try
                        {
                            object o = JsonConvert.DeserializeObject<ScoreTable>(message);
                            if (o is ScoreTable)
                            {
                                ScoreTable temp = o as ScoreTable;
                                UpdateList(temp);
                                EnablePanelContents(gameBoard);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show(message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
         
        private void UpdateList(ScoreTable temp)
        {
            TextBox tempBox = gameBoard.opponentScoreList.ElementAt(temp.Row);
            tempBox.Invoke(new Action(() => tempBox.Text = temp.SingleScoreValue.ToString()));
            TextBox tempBox2 = gameBoard.opponentScoreList.ElementAt(6);
            tempBox2.Invoke(new Action(() => tempBox2.Text = temp.TotalUpperScore.ToString()));
            TextBox tempBox3 = gameBoard.opponentScoreList.ElementAt(16);
            tempBox3.Invoke(new Action(() => tempBox3.Text = temp.TotalLowerScore.ToString()));
            TextBox tempBox4 = gameBoard.opponentScoreList.ElementAt(17);
            tempBox4.Invoke(new Action(() => tempBox4.Text = temp.TotalScore.ToString()));
        }

        internal void SendMessage()
        {
            NetworkStream n = client.GetStream();
            BinaryWriter w = new BinaryWriter(n);
            w.Flush();
        }

        public void DisablePanelContents(GameBoard form1)
        {
            foreach (var item in form1.Controls)
            {
                ((Control)item).Enabled = false;
            }
        }

        public void EnablePanelContents(GameBoard form1)
        {
            foreach (var item in form1.Controls)
            {
                ((Control)item).Enabled = true;
            }
        }
    }
}
