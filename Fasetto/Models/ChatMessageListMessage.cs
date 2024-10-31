using Fasetto.ViewModels;
using System.Collections.ObjectModel;

namespace Fasetto.Models;

public class ChatMessageListMessage
{
    public ObservableCollection<ChatMessageListItemViewModel> Items { get; set; }

    public ChatMessageListMessage(ObservableCollection<ChatMessageListItemViewModel> _items)
    {
        Items = _items;
    }
}
