using Fasetto.ViewModels;

namespace Fasetto.Services;

public interface IDialogService
{
    void ShowMessageBox(DialogWindowViewModel viewModel);

    void ShowMessageSearchWindow(string name, List<ChatMessageListItemViewModel> lastMessages);
}
