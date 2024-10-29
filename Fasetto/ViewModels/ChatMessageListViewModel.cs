using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Fasetto.Models;

namespace Fasetto.ViewModels;

public partial class ChatMessageListViewModel : ObservableRecipient, IRecipient<ValueChangedMessage<ChatMessageListMessage>>
{
    [ObservableProperty]
    private List<ChatMessageListItemViewModel> _items = new List<ChatMessageListItemViewModel>();

    public ChatMessageListViewModel()
    {
        IsActive = true;
    }

    public void Receive(ValueChangedMessage<ChatMessageListMessage> message)
    {
        Items = message.Value.Items;
    }
}
