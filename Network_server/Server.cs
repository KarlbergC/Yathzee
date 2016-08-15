using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_server
{
    class Server
    {
        List<ClientHandler> clients = new List<ClientHandler>();

        public void Run()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5000);
            Console.WriteLine("Server up and running, waiting for messages...");

            try
            {
                listener.Start();

                while (clients.Count < 2)
                {
                    TcpClient c = listener.AcceptTcpClient();

                    ClientHandler newClient = new ClientHandler(c, this);
                    clients.Add(newClient);
                    Thread clientThread = new Thread(newClient.Run);
                    clientThread.Start();
                    Console.WriteLine("Client connected " + clients.Count());
                }

                //MessageBox.Show("Sorry the game is full, try again later!");

                listener.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
            }
        }

        internal void DisconnectClient(ClientHandler clientHandler)
        {
            throw new NotImplementedException();
        }


        static int GiveMeTheTotalScore(string json)
        {
            JObject o = JObject.Parse(json);
            string totalScore = (string)o.SelectToken("TotalScore");
            return Convert.ToInt32(totalScore);
        }

        static string GiveMeUserName(string json)
        {
            JObject o = JObject.Parse(json);
            string userName = (string)o.SelectToken("UserName");
            return userName;
        }

        internal void Broadcast(ClientHandler fromClient, string message)
        {
            if (fromClient.userName == null)
            {
                fromClient.userName = GiveMeUserName(message);

            }

            Console.WriteLine(fromClient._remainingMoveCounter);
            fromClient.TotalScore = GiveMeTheTotalScore(message);
            Console.WriteLine(fromClient.TotalScore);

            if (clients.Any<ClientHandler>(x => x._remainingMoveCounter != 0))
            {
                foreach (ClientHandler toClient in clients)
                {
                    if (toClient != fromClient)
                    {
                        NetworkStream n = toClient.tcpClient.GetStream();
                        BinaryWriter w = new BinaryWriter(n);
                        w.Write(message);
                        w.Flush();
                        fromClient._remainingMoveCounter--;
                        if (clients.All<ClientHandler>(x => x._remainingMoveCounter == 0))
                        {
                            ClientHandler winner = GetWinner(clients);

                            foreach (ClientHandler client in clients)
                            {
                                n = client.tcpClient.GetStream();
                                w = new BinaryWriter(n);

                                if (client == winner)
                                {
                                    SaveHighscore(client.userName,client.TotalScore);
                                    w.Write($"The winner is {client.userName}!");
                                    w.Flush();
                                }
                                else
                                {
                                    w.Write($"The winner is {client.userName}! Better luck next time.");
                                    w.Flush();
                                }
                            }

                            Console.WriteLine("Slut på spelet");
                        }
                    }

                    else if (clients.Count() == 1)
                    {
                        NetworkStream n = toClient.tcpClient.GetStream();
                        BinaryWriter w = new BinaryWriter(n);
                        w.Write("Sorry, you are alone...");
                        w.Flush();
                    }
                }
            }
            //else
            //{
            //    foreach (ClientHandler client in clients)
            //    {
            //        NetworkStream n = client.tcpClient.GetStream();
            //        BinaryWriter w = new BinaryWriter(n);
            //        w.Write("Spelet är slut x vann");
            //        w.Flush();
            //    }
            //}
        }

        private void SaveHighscore(string userName, int highScore)
        {
            SQL.AddNewHighscore(userName, highScore);
        }

        private ClientHandler GetWinner(List<ClientHandler> clients)
        {
            ClientHandler tmpClient = clients
                  .OrderByDescending(o => o.TotalScore)
                  .First();

            return tmpClient;
        }

    }
}
