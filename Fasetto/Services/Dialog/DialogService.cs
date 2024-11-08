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

    public void ShowMessageSearchWindow(string name, List<ChatMessageListItemViewModel> lastMessages)
    {
        var messageSearchWindow = new MessageSearchWindow();
        messageSearchWindow.DataContext = new MessageSearchWindowViewModel(name, lastMessages);
        messageSearchWindow.Owner = Application.Current.MainWindow;
        messageSearchWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        messageSearchWindow.ShowDialog();
    }
}
