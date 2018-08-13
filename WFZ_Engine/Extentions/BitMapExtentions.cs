using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace WFZ_Engine.Extentions
{
    public static class BitMapExtentions
    {
        public static Bitmap To8CPallet(this Bitmap original)
        {
            if (!(original.Clone() is Bitmap clone)) return null;

            for (var i = 0; i < clone.Palette.Entries.Length; i++)
            {
                clone.Palette.Entries[i] = clone.Palette.Entries[i].Get8CColor();
            }
            
            return clone;
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
