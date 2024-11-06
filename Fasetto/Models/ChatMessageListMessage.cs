using Fasetto.ViewModels;
using System.Collections.ObjectModel;

namespace Fasetto.Models;

public class ChatMessageListMessage
{
    public string Name { get; set; }

    public ObservableCollection<ChatMessageListItemViewModel> Items { get; set; }

    public ChatMessageListMessage(string name, ObservableCollection<ChatMessageListItemViewModel> items)
    {
        Items = items;
        Name = name;
    }
}
