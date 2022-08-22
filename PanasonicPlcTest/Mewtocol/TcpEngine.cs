using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PanasonicPlcTest.Mewtocol
{
    public class TcpEngine : EngineBase
    {
        string ipAddress;
        int port;
        TcpClient client;

        public TcpEngine(string ipAddress, int port)
        {
            this.ipAddress = ipAddress;
            this.port = port;
            client = new TcpClient();
        }

        public override bool IsConnected => client.Connected;

        public override void Connect()
        {
            client.Connect(ipAddress, port);
        }

        public override void Disconnect()
        {
            client.Close();
        }

        protected internal override Task<string> OnCommandSending(byte[] request)
        {
            //send request
            NetworkStream stream = client.GetStream();
            //send request
            stream.Write(request, 0, request.Length);

            //await result
            var data = new Byte[256];
            Int32 bytes = stream.Read(data, 0, data.Length);
            string response = Encoding.ASCII.GetString(data, 0, bytes);

            if (!string.IsNullOrEmpty(response))
                return Task.FromResult(response);
            else
                return null;
        }

        protected internal override void OnDisposing()
        {
            Disconnect();
            client = null;
        }
    }
}
