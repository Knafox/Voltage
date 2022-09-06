using InnkeepersJourney.Objects.Rooms;
using InnkeepersJourney.Objects.Customers;

namespace InnkeepersJourney.Objects.Inn
{
    public class Inn
    {
        List<IRoom> rooms;
        List<ICustomer> dailyCustomers;

        public Inn(Object GameSettings =null)
        {
            //Base Level settings
            rooms = new List<IRoom> {
                new Individual(),
                new Individual(),
                new Individual()
            };
            
            

        }
    }
}
