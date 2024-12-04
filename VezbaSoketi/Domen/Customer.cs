namespace Utils
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{Id}-{LastName}-{FirstName}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (obj is not Customer) return false;
            Customer c = (Customer)obj;
            return c.Id == Id;
        }

        public Customer(string s)
        {
            string[] tokens = s.Split('-');
            Id = int.Parse(tokens[0]);
            LastName = tokens[1];
            FirstName = tokens[2];
        }
    }
}
