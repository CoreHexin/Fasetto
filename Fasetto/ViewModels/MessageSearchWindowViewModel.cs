using CommunityToolkit.Mvvm.ComponentModel;

namespace Fasetto.ViewModels;

public partial class MessageSearchWindowViewModel : ObservableObject
{
    private string _lastSearchText = string.Empty;

    public string Username { get; set; }

    public List<ChatMessageListItemViewModel> LastMessages { get; set; }

    [ObservableProperty]
    private string _searchText = string.Empty;

    [ObservableProperty]
    private List<ChatMessageListItemViewModel>? _filteredMessages;

    public MessageSearchWindowViewModel(string username, List<ChatMessageListItemViewModel> lastMessages)
    {
        Username = username;
        LastMessages = lastMessages;
        FilteredMessages = lastMessages;
    }

    /// <summary>
    /// SearchText发送变化时执行该方法
    /// 实现延迟搜索功能
    /// </summary>
    /// <param name="value"></param>
    partial void OnSearchTextChanged(string value)
    {
        Search();
    }

    public void Search()
    {
        if (_lastSearchText == SearchText)
            return;

        if (LastMessages.Count == 0)
            return;

        if (string.IsNullOrWhiteSpace(SearchText))
        {
            _lastSearchText = SearchText;
            FilteredMessages = LastMessages;
            return;
        }

        // todo: 后期使用更高效的搜索方法
        FilteredMessages = LastMessages.Where(m => m.Message.ToLower().Contains(SearchText.ToLower())).ToList();
        _lastSearchText = SearchText;
    }
}
