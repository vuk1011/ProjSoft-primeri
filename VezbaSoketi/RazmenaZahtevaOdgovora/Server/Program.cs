using Domen;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using ZahteviOdgovori;

namespace Server
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            #region Inicijalizovanje podataka

            List<Putnik> putnici = new List<Putnik>();
            putnici.Add(new Putnik
            {
                Broj = 1,
                Ime = "Ana",
                Prezime = "Nekic"
            });
            putnici.Add(new Putnik
            {
                Broj = 2,
                Ime = "Vuk",
                Prezime = "Bojic"
            });
            putnici.Add(new Putnik
            {
                Broj = 3,
                Ime = "Lana",
                Prezime = "Rajic"
            });

            #endregion

            try
            {
                #region Povezivanje

                using Socket serverSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10000);
                serverSoket.Bind(endPoint);

                serverSoket.Listen();

                using Socket klijentSoket = serverSoket.Accept();

                #endregion

                #region Inicijalizovanje stream-a

                using NetworkStream stream = new NetworkStream(klijentSoket);
                using StreamReader reader = new StreamReader(stream);
                using StreamWriter writer = new StreamWriter(stream);

                #endregion

                for (int i = 0; i < 4; i++)
                {
                    string? jsonOdKlijenta = reader.ReadLine();
                    if (jsonOdKlijenta is null) continue;

                    Zahtev? zahtev = JsonSerializer.Deserialize<Zahtev>(jsonOdKlijenta);
                    if (zahtev is null) continue;

                    Console.WriteLine(zahtev.ToString());

                    Odgovor odgovor = new Odgovor { Status = StatusOdgovora.OKEJ };

                    switch (zahtev.Tip)
                    {
                        case TipZahteva.DODAJ:
                            Putnik putnik = JsonSerializer.Deserialize<Putnik>((JsonElement)zahtev.Podatak);
                            if (PostojiPutnik(putnik.Broj, putnici))
                            {
                                odgovor.Status = StatusOdgovora.NIJE_OKEJ;
                            }
                            else
                            {
                                putnici.Add(putnik);
                            }
                            break;

                        case TipZahteva.VRATI:
                            odgovor.Podatak = putnici;
                            break;

                        case TipZahteva.POSTOJI_LI:
                            int brojPutnika = JsonSerializer.Deserialize<int>((JsonElement)zahtev.Podatak);
                            odgovor.Podatak = PostojiPutnik(brojPutnika, putnici);
                            break;
                    }

                    string jsonZaKlijenta = JsonSerializer.Serialize<Odgovor>(odgovor);
                    writer.WriteLine(jsonZaKlijenta);
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GRESKA :");
                Console.WriteLine(ex.Message);
            }
        }

        private static bool PostojiPutnik(int brojPutnika, List<Putnik> putnici)
        {
            return putnici.Find(p => p.Broj == brojPutnika) is not null;
        }
    }
}
