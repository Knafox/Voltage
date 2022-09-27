
namespace InnkeepersJourney.Objects.Customers
{
    public class Customer : ICustomer
    {
        int _count = 0;
        public Customer()
        {
            Name = GetRandomName();
        }
        public int Sleeps { get; set; }

        public string Name { get; set; }

        public static int Id { get; }

        public string GetRandomName()
        {
            string[] names = new string[]
            {
                "Isabel Mackenzie",
                "Adrian Feldman",
                "Kade Bruce",
                "Darrin Hostetler",
                "Cyrus Glick",
                "Baylor Marcus",
                "Donnell Ridgeway",
                "Demond Muller",
                "Nayeli Roman",
                "Shea Davey"
            };
            _count++;
            return names[_count-1];
        }
    }
}
