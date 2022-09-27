using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;

namespace InnkeepersJourney.Objects.Customers
{
    public partial class CustomerViewModel: ObservableObject
    {
        ICustomer _customer;

        [ObservableProperty]
        string name;

        [ObservableProperty]
        int sleeps;

        public CustomerViewModel()
        {

        }


        public void UpdateCustomer(ICustomer customer)
        {
            ICustomer _customer = customer;
            name = _customer.Name;
            sleeps = _customer.Sleeps;
        }

    }
}
