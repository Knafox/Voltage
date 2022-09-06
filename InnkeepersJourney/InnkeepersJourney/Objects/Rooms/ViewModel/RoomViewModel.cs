using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace InnkeepersJourney.Objects.Rooms
{
    internal partial class RoomViewModel : ObservableObject
    {
        [ObservableProperty]
        IRoom room;

    }
}
