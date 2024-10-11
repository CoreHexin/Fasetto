namespace Fasetto.ViewModels;

public class ChatMessageListItemDesignViewModel : ChatMessageListItemViewModel
{
    public static ChatMessageListItemDesignViewModel Instance = new ChatMessageListItemDesignViewModel();

    public ChatMessageListItemDesignViewModel()
    {
        SenderName = "Parnell";
        Message = "这是一条消息内容1";
        ShortName = "PL";
        AvatarColor = "#3099c5";
        IsSentByMe = false;
        SentTime = DateTime.Now;
    }
}
