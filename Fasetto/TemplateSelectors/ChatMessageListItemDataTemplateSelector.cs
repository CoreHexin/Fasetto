using Fasetto.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.TemplateSelectors;

/// <summary>
/// 数据模板选择器
/// </summary>
public class ChatMessageListItemDataTemplateSelector : DataTemplateSelector
{
    public DataTemplate ChatMessageListItemDataTemplate { get; set; }
    public DataTemplate ChatMessageListItemSentByMeDataTemplate { get; set; }

    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        if (item is ChatMessageListItemViewModel vm && vm.IsSentByMe == true)
            return ChatMessageListItemSentByMeDataTemplate;

        return ChatMessageListItemDataTemplate;
    }
}
