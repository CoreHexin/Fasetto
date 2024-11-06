using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Fasetto.Models;
using Fasetto.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;

namespace Fasetto.ViewModels;

public partial class ChatMessageListViewModel : ObservableRecipient, IRecipient<ValueChangedMessage<ChatMessageListMessage>>
{
    [ObservableProperty]
    private ObservableCollection<ChatMessageListItemViewModel> _items = new ObservableCollection<ChatMessageListItemViewModel>();

    [ObservableProperty]
    private string _name = string.Empty;

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

    /// <summary>
    /// 打开搜索窗口
    /// </summary>
    [RelayCommand]
    public void OpenSearchWindow()
    {
        IDialogService dialogService = App.Current.Services.GetService<IDialogService>()!;
        dialogService.ShowMessageSearchWindow(Name, Items.ToList());
    }

    public void Receive(ValueChangedMessage<ChatMessageListMessage> message)
    {
        Name = message.Value.Name;
        Items = message.Value.Items;
        RaiseScrollToBottom();
    }
}
