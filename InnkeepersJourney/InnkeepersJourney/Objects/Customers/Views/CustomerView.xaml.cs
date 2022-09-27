namespace InnkeepersJourney.Objects.Customers;

public partial class CustomerView : ContentView
{

    public CustomerView()
    {
        InitializeComponent();
        CustomerViewModel viewModel = new CustomerViewModel();
        this.BindingContext = viewModel;
    }

    public void UpdateCustomerViewModel(CustomerViewModel viewModel)
    {
        this.BindingContext = viewModel;
    }

}