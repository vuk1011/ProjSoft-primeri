using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Klijent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                #region Povezivanje

                Socket soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soket.Connect("127.0.0.1", 10000);

                #endregion

                byte[] bafer = new byte[256];

                while (true)
                {
                    Console.Write("Serveru se salje: ");
                    string porukaZaServer = Console.ReadLine();
                    if (string.IsNullOrEmpty(porukaZaServer)) continue;
                    soket.Send(Encoding.UTF8.GetBytes(porukaZaServer));
                    if (porukaZaServer.Equals("kraj"))
                    {
                        soket.Close();
                        break;
                    }
                    int bajtovi = soket.Receive(bafer);
                    string porukaOdServera = Encoding.UTF8.GetString(bafer, 0, bajtovi);
                    Console.WriteLine($"Server je odgovorio: {porukaOdServera}");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("GRESKA");
            }
        }
    }
}
