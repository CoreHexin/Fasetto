namespace Fasetto.ViewModels;

public partial class ChatListItemDesignViewModel : ChatListItemViewModel
{
    public static ChatListItemDesignViewModel Instance => new ChatListItemDesignViewModel();

    public ChatListItemDesignViewModel()
    {
        Name = "Luke";
        Message = "This chat app is awesome! I bet it will be fast too";
        ShortName = "LM";
        AvatarColor = "#3066c5";
    }
}
