using System;
using System.Net;
using System.Net.Sockets;

namespace AdapterExample
{
    /// <summary>
    /// Tcp Adapter
    /// </summary>
    internal class TcpCommunication : ICommunication, IDisposable
    {
        private Socket client;
        public TcpCommunication()
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //...設定 client 所需的資訊
        }

        public bool Connect(string target)
        {
            string[] data = target.Split(':');
            IPAddress ip;
            int port;
            if (IPAddress.TryParse(data[0], out ip) && int.TryParse(data[1], out port))
            {
                client.Connect(ip, port);
            }

            return client.Connected;
        }

        public void Disconnect()
        {
            if (client.Connected)
            {
                client.Disconnect(true);
            }
        }

        public void Dispose()
        {
            if (client != null)
            {
                client.Dispose();
            }
        }

        public byte[] Receive()
        {
            if (client.Connected)
            {
                byte[] buffer = new byte[1024];
                int receiveSize = client.Receive(buffer);
                Array.Resize(ref buffer, receiveSize);
                return buffer;
            }
            else
            {
                return null;
            }
        }

        public void Send(byte[] buffer)
        {
            if (client.Connected)
            {
                client.Send(buffer);
            }
        }
    }
}