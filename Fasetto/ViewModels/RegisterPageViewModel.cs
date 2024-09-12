using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Fasetto.Helpers;
using Fasetto.Models;
using System.Security;

namespace Fasetto.ViewModels;

public partial class RegisterPageViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(RegisterCommand))]
    private string _email = string.Empty;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(RegisterCommand))]
    private bool _hasPassword = false;

    private SecureString? _securePassword;

    public SecureString? SecurePassword
    {
        private get { return _securePassword; }
        set
        {
            _securePassword = value;
            if (_securePassword != null && _securePassword.Length > 0)
            {
                HasPassword = true;
            }
            else
            {
                HasPassword = false;
            }
        }
    }

    [RelayCommand(CanExecute = nameof(CanRegister))]
    private async Task<bool> RegisterAsync()
    {
        string password = SecurePassword.GetPlainText();
        await Task.Delay(3000);
        return true;
    }

    private bool CanRegister()
    {
        if (string.IsNullOrEmpty(Email) || HasPassword == false)
            return false;
        return true;
    }

    // 切换至登录页面
    [RelayCommand]
    private void SwitchToLogin()
    {
        // 向 MainWindowViewModel 发送消息
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<ApplicationPage>(ApplicationPage.Login));
    }

}
