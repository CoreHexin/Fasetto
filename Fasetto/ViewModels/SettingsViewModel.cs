using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Fasetto.Models;

namespace Fasetto.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    [RelayCommand]
    private void GoBack()
    {
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<SettingsMessage>(new SettingsMessage(false)));
    }
}
