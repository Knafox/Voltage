using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InnkeepersJourney.Objects.Customers;

namespace InnkeepersJourney.Objects.Rooms
{
    internal interface IRoom
    {
        public int Id { get; set; }

        public int Sleeps { get; set; }

        public string Status { get; set; }

        Customer AssignedCustomer { get; set; }

        public string ToString();

        public bool IsOccupied();

        public int resolveSleep();
    }
}
