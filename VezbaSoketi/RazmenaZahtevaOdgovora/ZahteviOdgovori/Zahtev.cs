namespace ZahteviOdgovori
{
    public class Zahtev
    {
        public TipZahteva Tip { get; set; }
        public object? Podatak { get; set; }

        public override string ToString()
        {
            return $"({Tip.ToString()}) {Podatak?.ToString()}";
        }
    }

    public enum TipZahteva
    {
        DODAJ,
        VRATI,
        POSTOJI_LI
    }
}
