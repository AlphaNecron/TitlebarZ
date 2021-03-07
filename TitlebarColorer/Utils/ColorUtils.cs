using System.Drawing;
using System.Globalization;

namespace TitlebarColorer.Utils
{
    public static class ColorUtils
    {
        internal static Color HexToRGB(object hex)
        {
            var hexColor = hex.ToString();
            if (hexColor?.IndexOf('#') != -1)
                hexColor = hexColor?.Replace("#", "");

            var red = 0;
            var green = 0;
            var blue = 0;

            switch (hexColor?.Length)
            {
                case 6:
                    red = int.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                    green = int.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                    blue = int.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);
                    break;
                case 3:
                    //#RGB
                    red = int.Parse(hexColor[0] + hexColor[0].ToString(), NumberStyles.AllowHexSpecifier);
                    green = int.Parse(hexColor[1] + hexColor[1].ToString(), NumberStyles.AllowHexSpecifier);
                    blue = int.Parse(hexColor[2] + hexColor[2].ToString(), NumberStyles.AllowHexSpecifier);
                    break;
            }

            return Color.FromArgb((byte) red, (byte) green, (byte) blue);
        }

        // Credit to Plotron
        public static string HexPadding(byte value)
        {
            return (value < 16 ? "0" : "") + $"{value:x}";
        }

        internal static int RemoveAlpha(object hex)
        {
            var baseHex = hex.ToString().Contains("#") ? hex.ToString()?.Replace("#", "") : hex.ToString();
            return int.Parse(baseHex.Length >= 7 ? baseHex.Remove(0, baseHex.Length - 6) : baseHex);
        }
    }
}