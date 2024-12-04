using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Utils;

namespace Server
{
    internal class Program
    {
        private static List<Customer> customers = new List<Customer>();
        
        static void Main(string[] args)
        {
            customers.Add(new Customer("10-Peters-Jeff"));
            customers.Add(new Customer("21-O'Neil-Mike"));
            customers.Add(new Customer("19-McSomething-Sara"));
            
            try
            {
                #region Connecting

                using Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPAddress address = IPAddress.Parse("127.0.0.1");
                int port = 9019;
                IPEndPoint endPoint = new IPEndPoint(address, port);
                serverSocket.Bind(endPoint);
                Console.WriteLine($"server running on {endPoint.Address}:{endPoint.Port}");

                serverSocket.Listen();
                Console.WriteLine("listening...");

                using Socket clientSocket = serverSocket.Accept();
                Console.WriteLine("client connected!");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

                #endregion

                #region Streams

                using NetworkStream stream = new NetworkStream(clientSocket);
                using StreamReader reader = new StreamReader(stream);
                using StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

                #endregion

                while (true)
                {
                    string message = reader.ReadLine();
                    Request r = JsonSerializer.Deserialize<Request>(message);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
}
