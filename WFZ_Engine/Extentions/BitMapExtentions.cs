using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace WFZ_Engine.Extentions
{
    public static class BitMapExtentions
    {
        public static Bitmap To8CPallet(this Bitmap original)
        {
            if (!(original.Clone() is Bitmap clone)) return null;

            for (var x = 0;x  < clone.Width; x++)
            {
                for (var y = 0; y < clone.Height; y++)
                {
                    clone.SetPixel(x, y, clone.GetPixel(x, y).Get8CColor());
                }
            }

            return clone;
        }

        public static Color GetBlackOrWhite(this Color color)
        {
            var sum = color.R + color.G + color.B;
            return sum > 128 * 3 ? Color.Black : Color.White;
        }

        public static Color Get8CColor(this Color color)
        {
            var r = color.R < 128 ? 0 : 255;
            var g = color.G < 128 ? 0 : 255;
            var b = color.B < 128 ? 0 : 255;
            return Color.FromArgb(r, g, b);
        }

        public static ReadOnlyCollection<Color> Palette8C => new ReadOnlyCollection<Color>(new []
        {
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(0, 0, 255),
            Color.FromArgb(0, 255, 0),
            Color.FromArgb(0, 255, 255),
            Color.FromArgb(255, 0, 0),
            Color.FromArgb(255, 0, 255),
            Color.FromArgb(255, 255, 0),
            Color.FromArgb(255, 255, 255),
            Color.Transparent
        });

        public static bool AreAllPixels8CColor(this Bitmap bmp)
        {
            return bmp.Palette.Entries.All(p => Palette8C.Contains(p));
        }
    }
}
