using Fasetto.ViewModels;
using System.Windows.Controls;

namespace Fasetto.Views
{
    /// <summary>
    /// ChatPage.xaml 的交互逻辑
    /// </summary>
    public partial class ChatPage : Page
    {
        public ChatPage()
        {
            InitializeComponent();
            DataContext = new ChatPageViewModel();
        }
    }
}
