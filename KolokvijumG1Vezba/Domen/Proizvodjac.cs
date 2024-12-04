namespace Domen
{
    public class Proizvodjac
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Proizvodjac pr = (Proizvodjac)obj;
            return Sifra == pr.Sifra;
        }
    }
}