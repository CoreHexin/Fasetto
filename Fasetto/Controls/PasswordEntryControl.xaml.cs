using Fasetto.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Controls
{
    /// <summary>
    /// PasswordEntryControl.xaml 的交互逻辑
    /// </summary>
    public partial class PasswordEntryControl : UserControl
    {
        public PasswordEntryControl()
        {
            InitializeComponent();
        }

        private void OldPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!(DataContext is PasswordEntryViewModel vm))
                return;

            vm.OldSecurePassword = ((PasswordBox)sender).SecurePassword;
        }

        private void NewPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!(DataContext is PasswordEntryViewModel vm))
                return;

            vm.NewSecurePassword = ((PasswordBox)sender).SecurePassword;
        }

        private void ConfirmPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!(DataContext is PasswordEntryViewModel vm))
                return;

            vm.ConfirmSecurePassword = ((PasswordBox)sender).SecurePassword;
        }
    }
}
