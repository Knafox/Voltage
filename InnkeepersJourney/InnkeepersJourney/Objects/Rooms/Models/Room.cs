using InnkeepersJourney.Objects.Customers;

namespace InnkeepersJourney.Objects.Rooms
{
    internal class Room: IRoom
    {
        public Room(int id)
        {
            Id = id;
            Status = "Empty";
        }

        public int Id { get; set; }

        public int Sleeps { get; set; }

        public string Status { get; set; }

        public Customer AssignedCustomer { get; set; }

        public override string ToString()
        {
            string status = IsOccupied() ? "Full" : "Empty";
            return "Room# " + Id + ": " + status;
        }

        public bool IsOccupied()
        {
            return AssignedCustomer != null;
        }

        public int resolveSleep()
        {
            if (AssignedCustomer == null)
                return 0;
            if (AssignedCustomer.Sleeps > Sleeps)
                return 0;
            return 50; //placeholderValue
        }
    }
}
