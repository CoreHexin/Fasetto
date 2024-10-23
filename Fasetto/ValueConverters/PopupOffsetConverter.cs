using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Fasetto.ValueConverters;

public class PopupOffsetConverter : MarkupExtension, IMultiValueConverter
{
    private static PopupOffsetConverter? _converter;

    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (!double.TryParse(values[0].ToString(), out double placementTargetWidth))
            return double.NaN;
        if (!double.TryParse(values[1].ToString(), out double popupWidth))
            return double.NaN;
        return (placementTargetWidth / 2.0) - (popupWidth / 2.0);
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return _converter ?? (_converter = new PopupOffsetConverter());
    }
}
