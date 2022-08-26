﻿using InkeepersJourney.Objects.Customers;
using InkeepersJourney.Objects.Rooms;
using System.Runtime.InteropServices;

namespace InkeepersJourney;

public partial class MainPage : ContentPage
{
    List<Room> rooms = new List<Room>();
    List<Customer> customers = new List<Customer>();

    public MainPage()
	{
        InitializeComponent();
        rooms.Add(new Small(1));
        rooms.Add(new Small(2));
        rooms.Add(new Small(3));
		RoomsList.ItemsSource = rooms;
        customers.Add(new Individual());
        customers.Add(new Individual());
        customers.Add(new Individual());
        CustomerViewModel test = new();
        CustomerView CustomerView = new(test);
        customerView = CustomerView;
    }

}

