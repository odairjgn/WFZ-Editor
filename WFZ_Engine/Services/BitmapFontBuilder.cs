using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFZ_Engine.Services
{
    public class BitmapFontBuilder : IDisposable
    {
        public Font Font { get; }
        public Color Forecolor { get; }
        public Color BackColor { get; }
        public float PaddingX { get; }
        public float PaddingY { get; }
        public bool Monospace { get; }

        public BitmapFontBuilder(Font font, Color forecolor, Color backColor, float paddingx, float paddingy, bool monospace)
        {
            Font = font;
            Forecolor = forecolor;
            BackColor = backColor;
            PaddingX = paddingx;
            PaddingY = paddingy;
            Monospace = monospace;
        }
        

        public Dictionary<char, Bitmap> BuildFont(char[] chars)
        {
            
                var dic = new Dictionary<char, Bitmap>();
                var sizes = chars.Where(char.IsLetterOrDigit).Select(c => TextRenderer.MeasureText($"{c}", Font));
                var maxH = sizes.Max(r => r.Height) + PaddingY;
                var maxW = sizes.Max(r => r.Width) + PaddingX;
                var textformat = new StringFormat()
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                };

                foreach (var c in chars)
                {
                    RectangleF drawArea;
                    if (char.IsLetterOrDigit(c) && Monospace)
                    {
                        drawArea = new RectangleF(0, 0, maxW, maxH);
                    }
                    else
                    {
                        var size = TextRenderer.MeasureText($"{c}", Font);
                        drawArea = new RectangleF(0, 0, size.Width + PaddingX, size.Height + PaddingY);
                    }

                    var img = new Bitmap((int)drawArea.Width, (int)drawArea.Height);
                    using (var g = Graphics.FromImage(img))
                    {
                        using (var bb = new SolidBrush(BackColor))
                        {
                            g.FillRectangle(bb, drawArea);

                            if (Forecolor != Color.Transparent)
                            {
                                using (var fb = new SolidBrush(Forecolor))
                                {
                                    g.DrawString($"{c}", Font, fb, drawArea, textformat);
                                }
                            }
                            else
                            {
                                var chromaKey = Color.FromArgb(byte.MaxValue - BackColor.R, byte.MaxValue - BackColor.G, byte.MaxValue - BackColor.B);
                                using (var fb = new SolidBrush(chromaKey))
                                {
                                    g.DrawString($"{c}", Font, fb, drawArea, textformat);
                                    g.Flush();
                                    img.MakeTransparent(chromaKey);
                                }
                            }
                        }
                    }

                    dic.Add(c, img);
                }

                return dic;
            
        }

        public void Dispose()
        {
            Font?.Dispose();
        }
    }
}
