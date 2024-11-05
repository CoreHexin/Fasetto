using CommunityToolkit.Mvvm.ComponentModel;

namespace Fasetto.ViewModels;

public partial class ChatMessageListItemImageViewModel : ObservableObject
{
    public string FileName { get; set; } = string.Empty;

    // 附件大小, 单位Byte
    public long FileSize { get; set; }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ImageLoaded))]
    private string? _localFilePath;

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

            Task.Delay(2000).ContinueWith(t => LocalFilePath = "/Images/Sample/rusty.jpg");
        }
    }

}
