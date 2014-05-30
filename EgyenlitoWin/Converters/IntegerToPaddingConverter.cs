using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace EgyenlitoWin.Converters
{
    public class IntegerToPaddingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            int margin = int.Parse(value.ToString());

            return margin + ",0," + margin + ",0";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
