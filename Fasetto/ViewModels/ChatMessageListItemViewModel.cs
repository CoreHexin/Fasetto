using CommunityToolkit.Mvvm.ComponentModel;

namespace Fasetto.ViewModels;

public partial class ChatMessageListItemViewModel : ObservableObject
{
    [ObservableProperty]
    private string _senderName = string.Empty;

    [ObservableProperty]
    private string _message = string.Empty;

    [ObservableProperty]
    private string _shortName = string.Empty;

    [ObservableProperty]
    private string _avatarColor = string.Empty;

    [ObservableProperty]
    private bool _isSelected;

    [ObservableProperty]
    private bool _isSentByMe;

    [ObservableProperty]
    private DateTime _sentTime;
}
