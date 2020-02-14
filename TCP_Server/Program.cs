using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace TCP_Server
{
    /*
        NetworkStream stream = client.GetStream();
        byte[] receivedData = new byte[1000];
        stream.Read(receivedData, 0, receivedData.Length);
        var rawData = Encoding.ASCII.GetString(receivedData);
        var t = JsonConvert.DeserializeObject<DLLData.Data>(rawData);
        Console.ReadKey();
    */
    class Program
    {
        static void Main(string[] args)
        {
            
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener server = new TcpListener(ip, 8080);
            List<TcpClient> clients = new List<TcpClient>();
            try
            {
                server.Start();
                Console.WriteLine("Server started!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Read();
                throw;
            }

            while (true)
            {
                TcpClient client = default(TcpClient);
                client = server.AcceptTcpClient();
                clients.Add(client);
            }
        }
    }
}
