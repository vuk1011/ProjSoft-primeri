namespace Domen
{
    public class PoreskaStopa
    {
        public int Sifra { get; set; }
        public string SkraceniNaziv { get; set; }
        public double Iznos { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            PoreskaStopa ps = (PoreskaStopa)obj;
            return Sifra == ps.Sifra;
        }
    }
}