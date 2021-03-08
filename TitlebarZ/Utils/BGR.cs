using System;
using System.Drawing;

namespace TitlebarZ.Utils
{
    public readonly struct BGR
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

        public static int StripAlpha(int hex)
        {
            var hexStr = hex.ToString("X");
            return Convert.ToInt32(hexStr.Length == 8 ? hexStr.Remove(0, 2) :
                hexStr.Length == 7 ? hexStr.Remove(0, 1) : hexStr, 16);
        }

        public override string ToString()
        {
            return $"{Blue}, {Green}, {Red}";
        }

        public static BGR FromColor(Color color)
        {
            return new(color.B, color.G, color.R);
        }

        public int ToRGBHex()
        {
            return Convert.ToInt32($"{Red:X2}{Green:X2}{Blue:X2}", 16);
        }
    }
}