namespace csbackend
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Name2 { get; set; }
        public string? Street { get; set; }
        public int ZIP { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Contact { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Mail { get; set; }
        public int Discount { get; set; }
        public int Payment_Terms { get; set; }

        public override string ToString()
        {
            return $"{CustomerId};{Name};{Name2};{Street};{ZIP};{City};{Country};{Contact};{Phone};{Mobile};{Mail};{Discount};{Payment_Terms}\n";
        }
    }
}
