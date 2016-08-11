using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Networking_client
{
    class Client
    {
        private TcpClient client;

        public void Start()
        {
            #region Get local IP
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }

            Console.WriteLine($"IP: {localIP}");
            #endregion

            //client = new TcpClient("192.168.220.88", 8080);
            client = new TcpClient(localIP, 5000);

            Thread listenerThread = new Thread(Send);
            listenerThread.Start();

            Thread senderThread = new Thread(Listen);
            senderThread.Start();

            senderThread.Join();
            listenerThread.Join();
        }

        public void Send()
        {
            NetworkStream n = client.GetStream();
        }
        public void Listen()
        {
            NetworkStream n = client.GetStream();
        }

    }
}
