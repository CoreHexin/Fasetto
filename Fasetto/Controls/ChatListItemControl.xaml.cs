using Fasetto.ViewModels;
using System.Windows.Controls;

namespace Fasetto.Controls
{
    /// <summary>
    /// ChatListItemControl.xaml 的交互逻辑
    /// </summary>
    public partial class ChatListItemControl : UserControl
    {
        public ChatListItemControl()
        {
            InitializeComponent();
            //DataContext = new ChatListItemViewModel();
        }
    }
}
