using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace LarkatorGUI
{
    public class ArkColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int? color = (int?)value;

            if (!color.HasValue)
            {
                return Brushes.Transparent;
            }

            switch (color)
            {
                case 1:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ff0000"));
                case 2:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#0000ff"));
                case 3:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#00ff00"));
                case 4:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffff00"));
                case 5:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#00ffff"));
                case 6:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ff00ff"));
                case 7:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#c0ffba"));
                case 8:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#c8caca"));
                case 9:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#786759"));

                case 10:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffb46c"));
                case 11:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#fffa8a"));
                case 12:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ff756c"));
                case 13:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#7b7b7b"));
                case 14:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#3b3b3b"));
                case 15:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#593a2a"));
                case 16:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#224900"));
                case 17:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#812118"));
                case 18:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffffff"));
                case 19:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffa8a8"));

                case 20:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#592b2b"));
                case 21:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffb694"));
                case 22:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#88532f"));
                case 23:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#cacaa0"));
                case 24:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#94946c"));
                case 25:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#e0ffe0"));
                case 26:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#799479"));
                case 27:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#224122"));
                case 28:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#d9e0ff"));
                case 29:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#394263"));

                case 30:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#e4d9ff"));
                case 31:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#403459"));
                case 32:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffe0ba"));
                case 33:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#948575"));
                case 34:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#594e41"));
                case 35:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#595959"));
                case 36:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffffff"));
                case 37:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#b79683"));
                case 38:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#eadad5"));
                case 39:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#d0a794"));

                case 40:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#c3b39f"));
                case 41:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#887666"));
                case 42:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#a0664b"));
                case 43:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#cb7956"));
                case 44:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#bc4f00"));
                case 45:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#79846c"));
                case 46:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#909c79"));
                case 47:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#a5a48b"));
                case 48:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#74939c"));
                case 49:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#787496"));

                case 50:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#b0a2c0"));
                case 51:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#6281a7"));
                case 52:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#485c75"));
                case 53:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#5fa4ea"));
                case 54:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#4568d4"));
                case 55:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#ededed"));
                case 56:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#515151"));
            }

            return Brushes.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
