using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Fasetto.Helpers;
using System.Security;

namespace Fasetto.ViewModels;

public partial class LoginPageViewModel : ObservableObject
{
    private string _email = string.Empty;

    public string Email
    {
        get { return _email; }
        set
        {
            if (SetProperty(ref _email, value))
            {
                LoginCommand.NotifyCanExecuteChanged();
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
                LoginCommand.NotifyCanExecuteChanged();
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

    public IAsyncRelayCommand LoginCommand { get; }

    public LoginPageViewModel()
    {
        LoginCommand = new AsyncRelayCommand(LoginAsync, CanLogin);
    }

    private async Task<bool> LoginAsync()
    {
        string password = SecurePassword.GetPlainText();
        await Task.Delay(3000);
        return true;
    }

    private bool CanLogin()
    {
        if (string.IsNullOrEmpty(Email) || HasPassword == false)
            return false;
        return true;
    }
}
