using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                #region Povezivanje

                Socket serverSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress adresa = IPAddress.Parse("127.0.0.1");
                int port = 10000;
                IPEndPoint endPoint = new IPEndPoint(adresa, port);
                serverSoket.Bind(endPoint);
                serverSoket.Listen();
                Socket klijentSoket = serverSoket.Accept();

                #endregion

                byte[] bafer = new byte[256];

                while (true)
                {
                    int bajtovi = klijentSoket.Receive(bafer);
                    string porukaOdKlijenta = Encoding.UTF8.GetString(bafer, 0, bajtovi);
                    if (porukaOdKlijenta.Equals("kraj"))
                    {
                        klijentSoket.Close();
                        break;
                    }
                    Console.WriteLine($"Klijent: {porukaOdKlijenta}");
                    string porukaZaKlijenta = porukaOdKlijenta.ToUpper();
                    Console.WriteLine($"Klijentu se salje: {porukaZaKlijenta}");
                    klijentSoket.Send(Encoding.UTF8.GetBytes(porukaZaKlijenta));
                }

            }
            catch (Exception)
            {
                Console.WriteLine("GRESKA");
            }
        }
    }
}
