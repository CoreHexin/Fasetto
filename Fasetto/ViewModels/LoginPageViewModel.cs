using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.ViewModels;

public partial class LoginPageViewModel : ObservableObject
{
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

    [ObservableProperty]
    private bool _hasPassword = false;
}
