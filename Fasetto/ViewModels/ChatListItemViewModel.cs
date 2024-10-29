using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Fasetto.Models;

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

    private List<ChatMessageListItemViewModel> GetChatMessageList()
    {
        var items = new List<ChatMessageListItemViewModel>
        {
            new ChatMessageListItemViewModel()
            {
                SenderName = "Parnell",
                Message = "这是一条消息内容1" + DateTime.Now,
                ShortName = "PL",
                AvatarColor = "#00d405",
                IsSentByMe = false,
                SentTime = DateTime.Parse("2024-10-10 09:12")
            },
            new ChatMessageListItemViewModel()
            {
                SenderName = "Luke",
                Message = "这是一条消息内容2" + DateTime.Now,
                ShortName = "LM",
                AvatarColor = "#3066c5",
                IsSentByMe = true,
                SentTime = DateTime.Parse("2024-10-10 09:15")
            },
            new ChatMessageListItemViewModel()
            {
                SenderName = "Parnell",
                Message = "这是一条消息内容3\r\n换行消息" + DateTime.Now,
                ShortName = "PL",
                AvatarColor = "#00d405",
                IsSentByMe = false,
                SentTime = DateTime.Parse("2024-10-10 09:19")
            },
        };
        return items;
    }

    [RelayCommand]
    public void OpenMessage()
    {
        IsSelected = true;
        var items = GetChatMessageList();
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<ChatMessageListMessage>(new ChatMessageListMessage(items)));
    }
}
