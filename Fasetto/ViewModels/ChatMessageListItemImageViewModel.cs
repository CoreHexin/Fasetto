using CommunityToolkit.Mvvm.ComponentModel;

namespace Fasetto.ViewModels;

public partial class ChatMessageListItemImageViewModel : ObservableObject
{
    public string FileName { get; set; } = string.Empty;

    // 附件大小, 单位Byte
    public long  FileSize { get; set; }

    public string? LocalFilePath { get; set; }

    public bool ImageLoaded => LocalFilePath != null;

    private string? _thumbnailUrl;

    public string? ThumbnailUrl
    {
        get { return _thumbnailUrl; }
        set 
        {
            if ( _thumbnailUrl == value)
                return;

            _thumbnailUrl = value;

            //Task.Delay(1000).Wait();
            LocalFilePath = "/Images/Sample/rusty.jpg";
        }
    }

}
