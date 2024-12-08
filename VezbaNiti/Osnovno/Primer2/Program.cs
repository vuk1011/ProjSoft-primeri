using System.Security.Cryptography;

int resurs = 0;

{
    Console.WriteLine("Dat je zajednicki resurs jednak 0.");
    Console.WriteLine("Nad njim ce 2 niti po 10 puta izvrsiti inkrementaciju.\n");

    Thread nit1 = new Thread(OperacijaNadZajednickimResursom);
    Thread nit2 = new Thread(OperacijaNadZajednickimResursom);

    nit1.Name = "Nit 1";
    nit2.Name = "Nit 2";

    nit1.Start();
    nit2.Start();

    nit1.Join();
    nit2.Join();

    Console.WriteLine($"\nOcekivana vrednost na kraju: 20");
    Console.WriteLine($"                   Dobijeno: {resurs}");
}

void OperacijaNadZajednickimResursom()
{
    for (int i = 0; i < 10; i++)
    {
        Thread.Sleep(RandomNumberGenerator.GetInt32(100));
        Console.WriteLine(Thread.CurrentThread.Name + " izvrsava operaciju...");
        int trenutnaVrednost = resurs;
        Thread.Sleep(RandomNumberGenerator.GetInt32(100));
        int novaVrednost = trenutnaVrednost + 1;
        Thread.Sleep(RandomNumberGenerator.GetInt32(100));
        resurs = novaVrednost;
    }
}
