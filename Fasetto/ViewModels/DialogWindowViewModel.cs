using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Controls;

namespace Fasetto.ViewModels;

public partial class DialogWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string _title = string.Empty;

    [ObservableProperty]
    private int _windowCornerRadius = 10;

    [ObservableProperty]
    private string _message = string.Empty;

    [ObservableProperty]
    private Control? _content;

    public DialogWindowViewModel()
    {
    }

}
