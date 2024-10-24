using CommunityToolkit.Mvvm.ComponentModel;

namespace Fasetto.ViewModels;

public partial class DialogWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string _title = string.Empty;

    [ObservableProperty]
    private int _windowCornerRadius = 10;

    [ObservableProperty]
    private string _message = string.Empty;

    public DialogWindowViewModel(string message, string title = "")
    {
        Message = message;
        Title = title;
    }
}
