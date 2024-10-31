using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Fasetto.Models;
using System.Collections.ObjectModel;

namespace Fasetto.ViewModels;

public partial class ChatMessageListViewModel : ObservableRecipient, IRecipient<ValueChangedMessage<ChatMessageListMessage>>
{
    [ObservableProperty]
    private ObservableCollection<ChatMessageListItemViewModel> _items = new ObservableCollection<ChatMessageListItemViewModel>();

    /// <summary>
    /// 是否显示附件菜单
    /// </summary>
    [ObservableProperty]
    private bool _isShowAttachmentMenu;

    /// <summary>
    /// 是否显示表情菜单
    /// </summary>
    [ObservableProperty]
    private bool _isShowEmojiMenu;

    [ObservableProperty]
    private string _message = string.Empty;

    [ObservableProperty]
    private bool _needScrollToBottom = false;

    public ChatMessageListViewModel()
    {
        IsActive = true;
    }

    [RelayCommand]
    private void ToggleAttachmentMenu()
    {
        IsShowAttachmentMenu = !IsShowAttachmentMenu;
    }

    [RelayCommand]
    private void ToggleEmojiMenu()
    {
        IsShowEmojiMenu = !IsShowEmojiMenu;
    }

    private void RaiseScrollToBottom()
    {
        NeedScrollToBottom = true;
        NeedScrollToBottom = false;
    }

    [RelayCommand]
    public void Send()
    {
        if (string.IsNullOrWhiteSpace(Message))
            return;

        var newMessage = new ChatMessageListItemViewModel()
        {
            SenderName = "Luke",
            Message = Message,
            ShortName = "LM",
            AvatarColor = "#3066c5",
            IsSentByMe = true,
            SentTime = DateTime.Now,
        };
        Items.Add(newMessage);
        RaiseScrollToBottom();
        Message = string.Empty;
    }

    public void Receive(ValueChangedMessage<ChatMessageListMessage> message)
    {
        Items = message.Value.Items;
        RaiseScrollToBottom();
    }
}
