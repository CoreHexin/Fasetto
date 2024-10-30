namespace Fasetto.ViewModels;

public class ChatMessageListDesignViewModel : ChatMessageListViewModel
{
    public static ChatMessageListDesignViewModel Instance = new ChatMessageListDesignViewModel();

    public ChatMessageListDesignViewModel()
    {
        Items = new List<ChatMessageListItemViewModel>
        {
            new ChatMessageListItemViewModel()
            {
                SenderName = "Parnell",
                Message = "这是一条消息内容1",
                ShortName = "PL",
                AvatarColor = "#00d405",
                IsSentByMe = false,
                SentTime = DateTime.Parse("2024-10-10 09:12")
            },
            new ChatMessageListItemViewModel()
            {
                SenderName = "Luke",
                Message = "这是一条消息内容2",
                ShortName = "LM",
                AvatarColor = "#3066c5",
                IsSentByMe = true,
                SentTime = DateTime.Parse("2024-10-10 09:15")
            },
            new ChatMessageListItemViewModel()
            {
                SenderName = "Parnell",
                Message = "这是一条消息内容3\r\n换行消息",
                ShortName = "PL",
                AvatarColor = "#00d405",
                IsSentByMe = false,
                SentTime = DateTime.Parse("2024-10-10 09:19")
            },
            new ChatMessageListItemViewModel()
            {
                SenderName = "Luke",
                Message = "这是一条消息内容4",
                ShortName = "LM",
                AvatarColor = "#3066c5",
                IsSentByMe = true,
                SentTime = DateTime.Parse("2024-10-10 09:15")
            },
            new ChatMessageListItemViewModel()
            {
                SenderName = "Parnell",
                Message = "这是一条消息内容5\r\n换行消息",
                ShortName = "PL",
                AvatarColor = "#00d405",
                IsSentByMe = false,
                SentTime = DateTime.Parse("2024-10-10 09:19")
            },

        };
    }
}
