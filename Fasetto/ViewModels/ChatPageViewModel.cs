using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Fasetto.Models;

namespace Fasetto.ViewModels;

public partial class ChatPageViewModel : ObservableRecipient, IRecipient<ValueChangedMessage<SettingsMessage>>
{
    /// <summary>
    /// 是否展开侧边栏
    /// </summary>
    [ObservableProperty]
    private bool _isShowSideMenu;

    [ObservableProperty]
    private bool _isShowSettingsMenu;

    public ChatPageViewModel()
    {
        IsShowSideMenu = true;
        IsShowSettingsMenu = false;
        IsActive = true;
    }

    [RelayCommand]
    private void ToggleSideMenu()
    {
        IsShowSideMenu = !IsShowSideMenu;
    }

    [RelayCommand]
    private void ToggleSettingsMenu()
    {
        IsShowSettingsMenu = !IsShowSettingsMenu;
    }

    public void Receive(ValueChangedMessage<SettingsMessage> message)
    {
        IsShowSettingsMenu = message.Value.IsShowSettingsMenu;
    }
}
