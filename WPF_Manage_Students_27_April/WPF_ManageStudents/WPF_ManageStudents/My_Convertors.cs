using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace WPF_ManageStudents
{
    public class ConvertBoolToText : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var picked = (bool)value;

            if (picked)
            {
                return "finished";
            }
            else
            {
                return "still not asked";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().Contains("finish"))
            {
                return true;
            }
            else
                return false;
        }
    }
}
