using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFReferOtherProperty
{
    class AspectRatioConverter : IValueConverter, IMarkupExtension
    {
        //バインドされた値に処理を加えて返す.
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //値を2倍にして返す
            return (double)value * 0.6043;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
