using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Fasetto.ValueConverters;

public class PopupOffsetConverter : MarkupExtension, IMultiValueConverter
{
    private static PopupOffsetConverter? _converter;

    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        double placementTargetWidth = (double)values[0];
        double popupWidth = (double)values[1];
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
