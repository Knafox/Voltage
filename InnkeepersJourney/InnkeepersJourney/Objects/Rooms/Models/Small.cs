using InnkeepersJourney.Objects.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnkeepersJourney.Objects.Rooms
{
    internal class Small: Room
    {
        public Small(int id) : base(id)
        {
            Sleeps = 1;
        }
    }
}
