using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Fasetto.ValueConverters;

public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
    where T : class, new()
{
    /// <summary>
    /// 值转化器的静态单例
    /// </summary>
    private static T? _converter = null;

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return _converter ?? (_converter = new T());
    }

    public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

    public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
}
