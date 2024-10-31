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
        }

        // shift+enter换行
        private void MessageInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                // 初始光标位置
                var CaretStartIndex = MessageInputTextBox.CaretIndex;
                // 在光标位置插入换行符
                MessageInputTextBox.Text = MessageInputTextBox.Text.Insert(CaretStartIndex, "\n");
                // 光标位置后移
                MessageInputTextBox.CaretIndex = CaretStartIndex + 1;
                e.Handled = true;
            }
        }
    }
}
