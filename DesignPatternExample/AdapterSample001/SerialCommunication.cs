using System;
using System.IO.Ports;

namespace AdapterSample001
{
    /// <summary>
    ///  Serialport Adapter (這個 Sample 沒有測過，僅為示意)
    /// </summary>
    internal class SerialCommunication : ICommunication, IDisposable
    {
        /// <summary>
        /// 既有的類別 (假設為無法更改)
        /// </summary>
        private SerialPort client;

        public SerialCommunication()
        {
            client = new SerialPort();
            // ... 其他...
        }

        public bool Connect(string target)
        {
            client.PortName = target;
            client.DataBits = 8;
            // ....
            client.Open();
            return client.IsOpen;
        }

        public void Disconnect()
        {
            if (client.IsOpen)
            {
                client.Close();
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
            if (client.IsOpen)
            {
                byte[] buffer = new byte[1024];
                int receiveSize = client.Read(buffer, 0, buffer.Length);
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
            if (client.IsOpen)
            {
                // SerialPort 的送出是 Write, 在上層加 Inerface, 統一送出為 Send
                client.Write(buffer, 0, buffer.Length);
            }
        }
    }
}