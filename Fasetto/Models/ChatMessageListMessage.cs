using Fasetto.ViewModels;

namespace Fasetto.Models;

public class ChatMessageListMessage
{
    public List<ChatMessageListItemViewModel> Items { get; set; }

    public ChatMessageListMessage(List<ChatMessageListItemViewModel> _items)
    {
        Items = _items;
    }
}
