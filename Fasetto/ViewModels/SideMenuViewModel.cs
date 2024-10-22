using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging.Messages;
using CommunityToolkit.Mvvm.Messaging;
using Fasetto.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Fasetto.ViewModels;

public partial class SideMenuViewModel : ObservableObject
{
    [RelayCommand]
    private void ShowSettingsMenu()
    {
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<SettingsMessage>(new SettingsMessage(true)));
    }
}
