using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Fasetto.Helpers;
using Fasetto.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Security;

namespace Fasetto.ViewModels;

public partial class PasswordEntryViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _isEditing;

    [ObservableProperty]
    private bool _hasOldPassword;

    [ObservableProperty]
    private bool _hasNewPassword;

    [ObservableProperty]
    private bool _hasConfirmPassword;

    private SecureString? _oldSecurePassword;
    public SecureString? OldSecurePassword
    {
        get { return _oldSecurePassword; }
        set
        {
            _oldSecurePassword = value;
            if (_oldSecurePassword != null && _oldSecurePassword.Length > 0)
                HasOldPassword = true;
            else
                HasOldPassword = false;
        }
    }

    private SecureString? _newSecurePassword;
    public SecureString? NewSecurePassword
    {
        get { return _newSecurePassword; }
        set
        {
            _newSecurePassword = value;
            if (_newSecurePassword != null && _newSecurePassword.Length > 0)
                HasNewPassword = true;
            else
                HasNewPassword = false;
        }
    }

    private SecureString? _confirmSecurePassword;
    public SecureString? ConfirmSecurePassword
    {
        get { return _confirmSecurePassword; }
        set
        {
            _confirmSecurePassword = value;
            if (_confirmSecurePassword != null && _confirmSecurePassword.Length > 0)
                HasConfirmPassword = true;
            else
                HasConfirmPassword = false;
        }
    }


    [RelayCommand]
    private void Edit()
    {
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
        IDialogService dialogService = App.Current.Services.GetService<IDialogService>()!;

        if (OldSecurePassword == null || NewSecurePassword == null || ConfirmSecurePassword == null)
        {
            dialogService.ShowMessageBox(new DialogWindowViewModel("密码不能为空, 请确认"));
            return;
        }

        if (NewSecurePassword.GetPlainText() != ConfirmSecurePassword.GetPlainText())
        {
            dialogService.ShowMessageBox(new DialogWindowViewModel("密码不正确, 请确认"));
        }
        else
        {
            dialogService.ShowMessageBox(new DialogWindowViewModel("密码修改成功"));
            IsEditing = false;
        }
    }

}
