using System.Globalization;
using System.Windows;

namespace Fasetto.ValueConverters;

public class TextToVisibilityConverter : BaseValueConverter<TextToVisibilityConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return string.IsNullOrEmpty((string)value) ? Visibility.Visible : Visibility.Hidden;
    }

    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
