using Fasetto.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fasetto.Controls
{
    /// <summary>
    /// ChatMessageListControl.xaml 的交互逻辑
    /// </summary>
    public partial class ChatMessageListControl : UserControl
    {
        public ChatMessageListControl()
        {
            InitializeComponent();
            DataContext = new ChatMessageListViewModel();
        }

        // Shift/Ctrl + Enter 换行
        private void MessageInputTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Keyboard.Modifiers == ModifierKeys.Shift || Keyboard.Modifiers == ModifierKeys.Control)
                {
                    // 初始光标位置
                    var CaretStartIndex = MessageInputTextBox.CaretIndex;
                    // 在光标位置插入换行符
                    MessageInputTextBox.Text = MessageInputTextBox.Text.Insert(CaretStartIndex, Environment.NewLine);
                    // 光标位置后移
                    MessageInputTextBox.CaretIndex = CaretStartIndex + Environment.NewLine.Length;
                    e.Handled = true;
                }
                else
                {
                    ((ChatMessageListViewModel)DataContext).Send();
                    e.Handled = true;
                }
            }
        }
    }
}
