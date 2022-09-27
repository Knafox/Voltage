
using CommunityToolkit.Mvvm.ComponentModel;

namespace InnkeepersJourney.Objects.Customers
{
    public class Customer :  ObservableObject, ICustomer
    {

        public Customer()
        {
            Name = GetRandomName();
        }
        public int Sleeps { get; set; }

        public string Name { get; set; }

        public static int Id { get; }

        public string GetRandomName()
        {
            return "Isabel Mackenzie";
        }
    }
}
