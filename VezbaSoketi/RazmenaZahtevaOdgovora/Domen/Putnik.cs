namespace Domen
{
    public class Putnik
    {
        public int Broj { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public override string ToString()
        {
            return $"{Broj}-{Ime}-{Prezime}";
        }
    }
}
