using System.Drawing;

namespace TitlebarColorer.Utils
{
    public struct BGR
    {
        public byte Blue { get; internal set; }
        public byte Green { get; internal set; }
        public byte Red { get; internal set; }

        public BGR(byte blue, byte green, byte red)
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

        public static BGR FromColor(Color color) => new BGR(color.B, color.G, color.R);

        public Color ToColor() => Color.FromArgb(Red, Green, Blue);
    }
}