﻿using Fasetto.Models;
using Fasetto.Views;
using System.Globalization;

namespace Fasetto.ValueConverters;

public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
{
    public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        switch ((ApplicationPage)value)
        {
            case ApplicationPage.Login:
                return new LoginPage();

            default:
                return null;
        }
    }

    public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
