﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Fasetto.Helpers;
using Fasetto.Models;
using System.Security;

namespace Fasetto.ViewModels;

public partial class LoginPageViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
    private string _email = string.Empty;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(LoginCommand))]
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

    [RelayCommand(CanExecute = nameof(CanLogin))]
    private async Task LoginAsync()
    {   
        // todo
        string password = SecurePassword.GetPlainText();
        await Task.Delay(500);
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<ApplicationPage>(ApplicationPage.Chat));
    }

    private bool CanLogin()
    {
        if (string.IsNullOrEmpty(Email) || HasPassword == false)
            return false;
        return true;
    }

    // 切换至注册页面
    [RelayCommand]
    private void SwitchToRegister()
    {
        // 向 MainWindowViewModel 发送消息
        WeakReferenceMessenger.Default.Send(new ValueChangedMessage<ApplicationPage>(ApplicationPage.Register));
    }
}
