using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Fasetto.ViewModels;

public partial class ChatListViewModel : ObservableObject
{
    [ObservableProperty]
    private List<ChatListItemViewModel> _items = new List<ChatListItemViewModel>();

    /// <summary>
    /// 默认打开第一个聊天对话框
    /// </summary>
    [RelayCommand]
    public void OpenDefaultMessage()
    {
        if (Items.Count == 0) 
            return;

        Items[0].OpenMessage();
    }
}
