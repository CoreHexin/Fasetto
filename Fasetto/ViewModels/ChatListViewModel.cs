using CommunityToolkit.Mvvm.ComponentModel;

namespace Fasetto.ViewModels;

public partial class ChatListViewModel : ObservableObject
{
    [ObservableProperty]
    private List<ChatListItemViewModel> _items = new List<ChatListItemViewModel>();
}
