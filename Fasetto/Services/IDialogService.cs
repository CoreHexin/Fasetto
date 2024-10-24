using Fasetto.ViewModels;

namespace Fasetto.Services;

public interface IDialogService
{
    void ShowMessageBox(DialogWindowViewModel viewModel);
}
