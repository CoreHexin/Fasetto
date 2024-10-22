using Fasetto.ViewModels;
using System.Windows.Controls;

namespace Fasetto.Controls
{
    /// <summary>
    /// SettingsControl.xaml 的交互逻辑
    /// </summary>
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            DataContext = new SettingsViewModel();
        }
    }
}
