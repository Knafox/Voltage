﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InkeepersJourney.Objects.Customers;

namespace InkeepersJourney.Objects.Rooms
{
    internal interface IRoom
    {
        private int sleeps;

        int Sleeps { get; set; }

        public bool canCustomterSleep(ICustomer customer);
    }
}
