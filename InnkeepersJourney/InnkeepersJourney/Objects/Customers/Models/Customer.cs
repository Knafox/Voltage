namespace InnkeepersJourney.Objects.Customers
{
    public class Customer : ICustomer
    {
        public Customer()
        {
            Name = "Test Name 987";
        }
        public int Sleeps { get; set; }

        public string Name { get; set; }


    }
}
