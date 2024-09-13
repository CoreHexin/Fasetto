namespace Fasetto.ViewModels;

public partial class ChatListDesignViewModel : ChatListViewModel
{
    public static ChatListDesignViewModel Instance => new ChatListDesignViewModel();

    public ChatListDesignViewModel()
    {
        Items = new List<ChatListItemViewModel>
        {
            new ChatListItemViewModel
            {
                Name = "Luke",
                Message = "This chat app is awesome! I bet it will be fast too too toot too",
                ShortName = "LM",
                AvatarColor = "#3099c5",
                HasNewMessage = true,
            },
            new ChatListItemViewModel
            {
                Name = "Jesse",
                Message = "This chat app is awesome! I bet it will be fast too",
                ShortName = "JA",
                AvatarColor = "#fe4530",
            },
            new ChatListItemViewModel
            {
                Name = "Parnell",
                Message = "This chat app is awesome! I bet it will be fast too",
                ShortName = "PL",
                AvatarColor = "#00d405",
                IsSelected = true
            },
            new ChatListItemViewModel
            {
                Name = "Luke",
                Message = "This chat app is awesome! I bet it will be fast too",
                ShortName = "LM",
                AvatarColor = "#3099c5",
            },
            new ChatListItemViewModel
            {
                Name = "Jesse",
                Message = "This chat app is awesome! I bet it will be fast too",
                ShortName = "JA",
                AvatarColor = "#fe4530",
            },
            new ChatListItemViewModel
            {
                Name = "Parnell",
                Message = "This chat app is awesome! I bet it will be fast too",
                ShortName = "PL",
                AvatarColor = "#00d405",
            },
            new ChatListItemViewModel
            {
                Name = "Luke",
                Message = "This chat app is awesome! I bet it will be fast too",
                ShortName = "LM",
                AvatarColor = "#3099c5",
            },
            new ChatListItemViewModel
            {
                Name = "Jesse",
                Message = "This chat app is awesome! I bet it will be fast too",
                ShortName = "JA",
                AvatarColor = "#fe4530",
            },
            new ChatListItemViewModel
            {
                Name = "Parnell",
                Message = "This chat app is awesome! I bet it will be fast too",
                ShortName = "PL",
                AvatarColor = "#00d405",
            },

        };
    }
}
