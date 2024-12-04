namespace Domen
{
    public class Proizvod
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }
        public PoreskaStopa PoreskaStopa { get; set; }
        public Proizvodjac Proizvodjac { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Proizvod pr = (Proizvod)obj;
            return Sifra == pr.Sifra;
        }
    }
}
