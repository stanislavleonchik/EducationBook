using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Edbook.WinForms.Styles
{
    public class ColorSchemes
    {
        // Стандартный текст шрифта
        public static Color clrOfText = Color.Gainsboro;                // Основной цвет для текста

        // Стандартные цвета
        public static Color clrBlueLight = Color.FromArgb(37, 36, 81);    // Светлый основной цвет
        public static Color clrBlueDark = Color.FromArgb(31, 30, 68);     // Тёмный основной цвет
        public static Color clrBlueDarkest = Color.FromArgb(26, 24, 58);  // Темнейший основной цвет
        public static Color clrBlueDarkest2 = Color.FromArgb(20, 20, 50); // Ещё один тёмный цвет

        // Структура цветов для выделения вкладок
        public struct ColorSchemesOfTabs
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(24, 161, 251);
        }
    }
}
