using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Utils;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Connecting

                using Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Console.WriteLine("client running");

                IPAddress address = IPAddress.Parse("127.0.0.1");
                int port = 9019;
                IPEndPoint endPoint = new IPEndPoint(address, port);
                Console.WriteLine($"connecting to endpoint {endPoint.Address}:{endPoint.Port}");
                socket.Connect(endPoint);
                Console.WriteLine("connected successfully!");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

                #endregion

                #region Streams

                using NetworkStream stream = new NetworkStream(socket);
                using StreamReader reader = new StreamReader(stream);
                using StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

                #endregion

                while (true)
                {
                    string input = Console.ReadLine();
                    Request request = new Request(input);
                    string json = JsonSerializer.Serialize(request);
                    writer.WriteLine(json);
                    Console.WriteLine(request);
                    Console.WriteLine(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
}
