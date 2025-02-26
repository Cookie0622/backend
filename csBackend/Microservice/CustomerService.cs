namespace csbackend.Microservice
{
    public class CustomerService
    {
        public Customer[] getCustomers()
        {
            var Customers = new List<Customer>();
            return File.ReadAllLines("csv/customer.csv")
                .Select(x => x.Split(';'))
                .Select(x => new Customer
                {
                    CustomerId = int.Parse(x[0]),
                    Name = x[1],
                    Name2 = x[2],
                    Street = x[3],
                    ZIP = int.Parse(x[4]),
                    City = x[5],
                    Country = x[6],
                    Contact = x[7],
                    Phone = x[8],
                    Mobile = x[9],
                    Mail = x[10],
                    Discount = int.Parse(x[11]),
                    Payment_Terms = int.Parse(x[12]),
                })
                .ToArray();
        }

        public Customer addCustomer(Customer customer)
        {
            File.AppendAllText("csv/customer.csv", customer.ToString());
            return customer;
        }
    }
}
