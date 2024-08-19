using Fasetto.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Views
{
    /// <summary>
    /// LoginPage.xaml 的交互逻辑
    /// </summary>
    public partial class LoginPage : BasePage
    {
        public LoginPage()
        {
            InitializeComponent();
            DataContext = new LoginPageViewModel();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ((LoginPageViewModel)DataContext).SecurePassword = ((PasswordBox)sender).SecurePassword;
        }
    }
}
