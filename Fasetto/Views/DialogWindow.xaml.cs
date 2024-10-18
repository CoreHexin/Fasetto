using Fasetto.ViewModels;
using System.Windows;

namespace Fasetto.Views
{
    /// <summary>
    /// DialogWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DialogWindow : Window
    {
        public DialogWindow()
        {
            InitializeComponent();
            DataContext = new DialogWindowViewModel();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
