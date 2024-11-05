namespace Fasetto.ViewModels;

public class ChatMessageListItemImageDesignViewModel : ChatMessageListItemViewModel
{
    public static ChatMessageListItemImageDesignViewModel Instance = new ChatMessageListItemImageDesignViewModel();

    public ChatMessageListItemImageDesignViewModel()
    {
        SenderName = "Parnell";
        Message = "这是一条消息内容1";
        ShortName = "PL";
        AvatarColor = "#3099c5";
        IsSentByMe = false;
        SentTime = DateTime.Now;
        Image = new ChatMessageListItemImageViewModel()
        {
            ThumbnailUrl = "http://thumbnailUrl"
        };
    }
}
