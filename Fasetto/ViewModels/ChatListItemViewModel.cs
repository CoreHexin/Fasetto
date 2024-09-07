using CommunityToolkit.Mvvm.ComponentModel;

namespace Fasetto.ViewModels;

public partial class ChatListItemViewModel : ObservableObject
{
    [ObservableProperty]
    private string _name = string.Empty;

    [ObservableProperty]
    private string _message = string.Empty;

    [ObservableProperty]
    private string _shortName = string.Empty;

    [ObservableProperty]
    private string _avatarColor = string.Empty;

    [ObservableProperty]
    private bool _hasNewMessage;

    [ObservableProperty]
    private bool _isSelected;
}
