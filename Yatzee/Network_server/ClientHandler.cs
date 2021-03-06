﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Network_server
{
    class ClientHandler
    {
        public TcpClient tcpClient;
        private Server myServer;
        public string userName;
        public int _remainingMoveCounter;
        public int TotalScore { get; set; }

        public ClientHandler(TcpClient c, Server server, int remainingMoveCounter = 12)
        {
            tcpClient = c;
            myServer = server;
            _remainingMoveCounter = remainingMoveCounter;
        }

        public void Run()
        {
            try
            {
                string message = "";

                while (!message.Equals("quit"))
                {
                    NetworkStream n = tcpClient.GetStream();
                    message = new BinaryReader(n).ReadString();
                    myServer.Broadcast(this, message);
                    Console.WriteLine(message);
                }

                myServer.DisconnectClient(this);
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
