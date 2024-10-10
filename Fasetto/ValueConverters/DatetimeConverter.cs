using System.Globalization;

namespace Fasetto.ValueConverters;

public class DatetimeConverter : BaseValueConverter<DatetimeConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return ((DateTime)value).ToString();
    }

    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
