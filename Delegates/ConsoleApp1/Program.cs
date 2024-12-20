namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We'll initialize a few humans, of different nationalities.");
            Console.WriteLine("Using delegates, they will each greet us depending where they're from.\n");
            
            Human h1 = new("John", Nationality.AMERICAN);
            Human h2 = new("Anna", Nationality.FRENCH);
            Human h3 = new("Marina", Nationality.SERBIAN);

            h1.Greet();
            h2.Greet();
            h3.Greet();
        }

        class Human
        {
            private string name;
            private Nationality nationality;
            private Greet greet;

            public Human(string name, Nationality nationality)
            {
                this.name = name;
                this.nationality = nationality;

                switch (nationality)
                {
                    case Nationality.AMERICAN:
                        greet = GreetInEnglish;
                        break;
                    case Nationality.FRENCH:
                        greet = GreetInFrench;
                        break;
                    case Nationality.SERBIAN:
                        greet = GreetInSerbian;
                        break;
                }
            }

            public void Greet()
            {
                greet(name);
            }
        }

        enum Nationality
        {
            AMERICAN,
            SERBIAN,
            FRENCH,
        }

        delegate void Greet(string name);

        static void GreetInEnglish(string name)
        {
            Console.WriteLine($"Hi, I'm {name}!");
        }

        static void GreetInFrench(string name)
        {
            Console.WriteLine($"Bonjour, je suis {name}!");
        }

        static void GreetInSerbian(string name)
        {
            Console.WriteLine($"Ćao, ja sam {name}!");
        }

    }

}
