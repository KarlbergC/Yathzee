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

namespace Project_Yatzee
{
    class Client
    {
        ScoreTable scoreTableMessage;
        List <DiceButton> diceButtonMessage;
        private TcpClient client;
        private string ipAddress;
        int port;

        public Client(string ipAddress, ScoreTable scoreTableMessage, List<DiceButton> diceButtonMessage, int port = 5000)
        {
            this.ipAddress = ipAddress;
            this.scoreTableMessage = scoreTableMessage;
            this.port = port;
            //Instansiera listan här?
            this.Start();
        }

        public void Start()
        {
            client = new TcpClient("192.168.220.107", 5000);
            Thread listenerThread = new Thread(SendMessage);
            listenerThread.Start();

            Thread senderThread = new Thread(Listen);
            senderThread.Start();

            senderThread.Join();
            listenerThread.Join();
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
                while (true)
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();
                    MessageBox.Show(message);
                    object o = JsonConvert.DeserializeObject(message);
                    if (o is ScoreTable)
                    {
                        ScoreTable temp = o as ScoreTable;
                        //uppdatera listan
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
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
