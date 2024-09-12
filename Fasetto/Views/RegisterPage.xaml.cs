using Fasetto.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Views
{
    /// <summary>
    /// RegisterPage.xaml 的交互逻辑
    /// </summary>
    public partial class RegisterPage : BasePage
    {
        public RegisterPage()
        {
            InitializeComponent();
            DataContext = new RegisterPageViewModel();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ((RegisterPageViewModel)DataContext).SecurePassword = ((PasswordBox)sender).SecurePassword;
        }
    }
}
