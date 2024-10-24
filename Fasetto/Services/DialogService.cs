using Fasetto.ViewModels;
using Fasetto.Views;

namespace Fasetto.Services;

public class DialogService : IDialogService
{
    public void ShowMessageBox(DialogWindowViewModel viewModel)
    {
        var dialogWindow = new DialogWindow();
        dialogWindow.DataContext = viewModel;
        dialogWindow.ShowDialog();
    }
}
