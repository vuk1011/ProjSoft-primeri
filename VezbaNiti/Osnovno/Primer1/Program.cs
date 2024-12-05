using System.Security.Cryptography;

{
    Thread nit1 = new Thread(Operacija1);
    Thread nit2 = new Thread(Operacija1);
    Thread nit3 = new Thread(Operacija2);
    Thread.CurrentThread.Name = "Glavna nit";

    nit1.Name = "Nit 1";
    nit2.Name = "Nit 2";
    nit3.Name = "Nit 3";

    nit1.Start();
    nit2.Start();
    nit3.Start();

    Operacija2();

    nit1.Join();
    nit2.Join();
    nit3.Join();
}

void Operacija1()
{
    for (int i = 1; i < 6; i++)
    {
        Thread.Sleep(RandomNumberGenerator.GetInt32(500));
        Console.WriteLine(Thread.CurrentThread.Name + ": " + i);
    }
}

void Operacija2()
{
    for (int i = 1; i < 6; i++)
    {
        Thread.Sleep(RandomNumberGenerator.GetInt32(500));
        Console.WriteLine(Thread.CurrentThread.Name + ": " + i * i);
    }
}
