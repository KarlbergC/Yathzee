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
        private Form1 _form1;
        int port;

        public Client(Form1 form1)
        {
            _form1 = form1;

        }
        public Client(string ipAddress, Form1 form1, ScoreTable scoreTableMessage, List<DiceButton> diceButtonMessage, int port = 5000)
        {
            this.ipAddress = ipAddress;
            this.scoreTableMessage = scoreTableMessage;
            this.port = port;
            _form1 = form1;
            //Instansiera listan här?
            this.Start();
        }

        public void Start()
        {
            client = new TcpClient("192.168.220.107", 5000);

            //Thread listenerThread = new Thread(SendMessage);
            //listenerThread.Start();

            Thread senderThread = new Thread(Listen);
            senderThread.Start();

            //senderThread.Join();
            //listenerThread.Join();
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

                //if (message.Equals("quit"))
                //    client.Close();
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
                while (message != "quit")
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();
                    MessageBox.Show(message);
                    try
                    {
                        object o = JsonConvert.DeserializeObject<ScoreTable>(message);
                        if (o is ScoreTable)
                        {
                            ScoreTable temp = o as ScoreTable;
                            UpdateList(temp);
                            //uppdatera listan
                        }

                    }
                    catch (Exception)
                    {
                       
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
            TextBox tempBox = _form1.textBoxList2.ElementAt(temp.Row);
            tempBox.Invoke(new Action(() => tempBox.Text = temp.SingleScoreValue.ToString()));
            TextBox tempBox2 = _form1.textBoxList2.ElementAt(6);
            tempBox2.Invoke(new Action(() => tempBox2.Text = temp.TotalUpperScore.ToString()));
            TextBox tempBox3 = _form1.textBoxList2.ElementAt(17);
            tempBox3.Invoke(new Action(() => tempBox3.Text = temp.TotalLowerScore.ToString()));
            TextBox tempBox4 = _form1.textBoxList2.ElementAt(18);
            tempBox4.Invoke(new Action(() => tempBox4.Text = temp.TotalScore.ToString()));
        }

        internal void SendMessage()
        {
            NetworkStream n = client.GetStream();
            BinaryWriter w = new BinaryWriter(n);
            w.Write("Hejsan");
            w.Flush();
        }
    }
}
