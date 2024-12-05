using System.Net.Sockets;
using System.Net;
using Domen;
using ZahteviOdgovori;
using System.Text.Json;

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

                #region Inicijalizovanje stream-a

                using NetworkStream stream = new NetworkStream(soket);
                using StreamReader reader = new StreamReader(stream);
                using StreamWriter writer = new StreamWriter(stream);

                #endregion

                Zahtev z1 = new Zahtev { Tip = TipZahteva.POSTOJI_LI, Podatak = 1 };
                Zahtev z2 = new Zahtev { Tip = TipZahteva.DODAJ, Podatak = new Putnik { Broj = 4, Ime = "Matija", Prezime = "Petrovic"} };
                Zahtev z3 = new Zahtev { Tip = TipZahteva.DODAJ, Podatak = new Putnik { Broj = 4, Ime = "Matija", Prezime = "Petrovic"} };
                Zahtev z4 = new Zahtev { Tip = TipZahteva.VRATI };
                Zahtev[] zahtevi = { z1, z2, z3, z4 };

                for (int i = 0; i < 4; i++)
                {
                    Zahtev zahtev = zahtevi[i];
                    string jsonZaServer = JsonSerializer.Serialize<Zahtev>(zahtev);

                    writer.WriteLine(jsonZaServer);
                    writer.Flush();

                    string? jsonOdServera = reader.ReadLine();
                    if (jsonOdServera is null) continue;

                    Odgovor? odgovor = JsonSerializer.Deserialize<Odgovor>(jsonOdServera);
                    if (odgovor is null) continue;

                    if (zahtev.Tip == TipZahteva.VRATI)
                    {
                        Console.WriteLine(odgovor.Status.ToString());
                        List<Putnik> putnici = JsonSerializer.Deserialize<List<Putnik>>((JsonElement)odgovor.Podatak);
                        foreach (var p in putnici)
                        {
                            Console.WriteLine(p.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine(odgovor.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GRESKA :");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
