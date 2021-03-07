using System.Drawing;

namespace TitlebarZ.Utils
{
    public struct BGR
    {
        private byte Blue { get; }
        private byte Green { get; }
        private byte Red { get; }

        private BGR(byte blue, byte green, byte red)
        {
            (Blue, Green, Red) = (blue, green, red);
        }

        public string ToHex()
        {
            return $"FF{Blue:X2}{Green:X2}{Red:X2}";
        }

        public override string ToString()
        {
            return $"{Blue}, {Green}, {Red}";
        }

        public static BGR FromColor(Color color)
        {
            return new(color.B, color.G, color.R);
        }

        public Color ToColor()
        {
            return Color.FromArgb(Red, Green, Blue);
        }
    }
}