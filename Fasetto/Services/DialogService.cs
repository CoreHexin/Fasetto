using Fasetto.ViewModels;
using Fasetto.Views;
using System.Windows;

namespace Fasetto.Services;

public class DialogService : IDialogService
{
    public void ShowMessageBox(DialogWindowViewModel viewModel)
    {
        var dialogWindow = new DialogWindow();
        dialogWindow.DataContext = viewModel;
        dialogWindow.Owner = Application.Current.MainWindow;
        dialogWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        dialogWindow.ShowDialog();
    }
}
