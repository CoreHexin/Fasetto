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
    private string _email = string.Empty;

    public string Email
    {
        get { return _email; }
        set
        {
            if (SetProperty(ref _email, value))
            {
                RegisterCommand.NotifyCanExecuteChanged();
            }
        }
    }

    private bool _hasPassword = false;

    public bool HasPassword
    {
        get { return _hasPassword; }
        set 
        { 
            if (SetProperty(ref _hasPassword, value))
            {
                RegisterCommand.NotifyCanExecuteChanged();
            }
        }
    }

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

    public IAsyncRelayCommand RegisterCommand { get; }

    public RegisterPageViewModel()
    {
        RegisterCommand = new AsyncRelayCommand(RegisterAsync, CanRegister);
    }

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
