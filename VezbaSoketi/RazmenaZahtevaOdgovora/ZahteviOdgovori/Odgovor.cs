namespace ZahteviOdgovori
{
    public class Odgovor
    {
        public StatusOdgovora? Status { get; set; }
        public object? Podatak { get; set; }

        public override string ToString()
        {
            return $"({Status.ToString()}) {Podatak?.ToString()}";
        }
    }
    
    public enum StatusOdgovora
    {
        OKEJ,
        NIJE_OKEJ
    }
}
