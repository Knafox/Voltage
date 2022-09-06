using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;

namespace InnkeepersJourney.Objects.Customers
{
    public partial class CustomerViewModel: ObservableObject
    {
        [ObservableProperty]
        public int sleeps = 1;

        [ObservableProperty]
        public string name = "Test Name 567";

        public CustomerViewModel()
        {
            sleeps = 2;
            name = "Test Name 123";
            Debugger.Break();
        }
    }
}
