namespace InkeepersJourney.Objects.Customers;

public partial class CustomerView : ContentView
{

    public CustomerView()
    {
        InitializeComponent();
        CustomerViewModel customerViewModel = new();
        BindingContext = customerViewModel;
    }

    public CustomerView(CustomerViewModel customerViewModel)
	{
		InitializeComponent();
        BindingContext = customerViewModel;
    }

}