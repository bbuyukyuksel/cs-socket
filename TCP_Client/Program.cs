using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;


namespace TCP_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            DLLData.Data data = new DLLData.Data();
            data.type = DLLData.Data.DataType.Text;
            data.content = "Hello World!";

            var jsonData = JsonConvert.SerializeObject(data);

            TcpClient client = new TcpClient("localhost", 8080);
            int byteCount = Encoding.ASCII.GetByteCount(jsonData);
            byte[] sendData = new byte[byteCount];
            sendData = Encoding.ASCII.GetBytes(jsonData);

            NetworkStream stream = client.GetStream();
            stream.Write(sendData, 0, sendData.Length);
            stream.Close();
            client.Close();
        }
    }
}
