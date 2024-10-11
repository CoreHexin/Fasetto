using CommunityToolkit.Mvvm.ComponentModel;

namespace Fasetto.ViewModels;

public partial class ChatMessageListViewModel : ObservableObject
{
    [ObservableProperty]
    private List<ChatMessageListItemViewModel> _items = new List<ChatMessageListItemViewModel>();
}
