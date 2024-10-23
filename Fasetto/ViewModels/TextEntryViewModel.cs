using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Fasetto.ViewModels;

public partial class TextEntryViewModel : ObservableObject
{
    [ObservableProperty]
    private string _label = string.Empty;

    [ObservableProperty]
    private string _originalText = string.Empty;

    [ObservableProperty]
    private string _EditedText = string.Empty;

    [ObservableProperty]
    private bool _isEditing;

    public TextEntryViewModel(string label, string originalText)
    {
        IsEditing = false;
        Label = label;
        OriginalText = originalText;
        EditedText = originalText;
    }

    [RelayCommand]
    private void Edit()
    {
        EditedText = OriginalText;
        IsEditing = true;
    }

    [RelayCommand]
    private void Cancel()
    {
        IsEditing = false;
    }

    [RelayCommand]
    private void Save()
    {
        // todo
        OriginalText = EditedText;
        IsEditing = false;
    }
}
