using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WFZ_Editor.UC
{
    public partial class CustomFontDialog : Form
    {
        public CustomFontDialog()
        {
            InitializeComponent();
        }

        private void CustomFontDialog_Load(object sender, EventArgs e)
        {
            var th = new Thread(LoadFonts);
            th.Start();
        }

        public FontFamily FontFamily { get; set; }

        private void LoadFonts()
        {
            Invoke(new Action(() => btSelect.Enabled = false));

            var sysFon = new InstalledFontCollection();

            Invoke(new Action(() =>
            {
                lbFonts.DataSource = sysFon.Families.Select(f => new Tuple<string, FontFamily>(f.Name, f)).ToList();
                lbFonts.DisplayMember = nameof(Tuple<string, FontFamily>.Item1);
                lbFonts.ValueMember = nameof(Tuple<string, FontFamily>.Item2);
            }));

            object s = null;

            Invoke(new Action(() => s = lbFonts.SelectedItem = (lbFonts.DataSource as List<Tuple<string, FontFamily>>).FirstOrDefault(f => f.Item2.Name == FontFamily.Name)));

            Invoke(new Action(() => btSelect.Enabled = true));
            Invoke(new Action(() => lbFonts.SelectedItem = s));
            Invoke(new Action(() => lbFonts_SelectedIndexChanged(null, null)));
        }

        private void lbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!btSelect.Enabled) return;

            FontFamily = (lbFonts.SelectedItem as Tuple<string, FontFamily>).Item2;

            Image img = new Bitmap(600, 400);
            using (var g = Graphics.FromImage(img))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                var fonr = new Font(FontFamily, 60, FontStyle.Regular, GraphicsUnit.Pixel);
                var fonb = new Font(FontFamily, 60, FontStyle.Bold, GraphicsUnit.Pixel);
                var foni = new Font(FontFamily, 60, FontStyle.Italic, GraphicsUnit.Pixel);
                var fonu = new Font(FontFamily, 60, FontStyle.Underline, GraphicsUnit.Pixel);
                var fons = new Font(FontFamily, 60, FontStyle.Strikeout, GraphicsUnit.Pixel);
                var strFormat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString("Abc123:?-", fonr, Brushes.Black, new RectangleF(0, 0, img.Width, 70), strFormat);
                g.DrawString("Def456#$%", fonb, Brushes.Red, new RectangleF(0, 80, img.Width, 70), strFormat);
                g.DrawString("Ghi789@!*", foni, Brushes.Blue, new RectangleF(0, 160, img.Width, 70), strFormat);
                g.DrawString("Jkl012;,.", fonu, Brushes.Green, new RectangleF(0, 240, img.Width, 70), strFormat);
                g.DrawString("Mno345/=+", fons, Brushes.Purple, new RectangleF(0, 320, img.Width, 70), strFormat);

                fonr.Dispose();
                fonb.Dispose();
                foni.Dispose();
                fonu.Dispose();
                fons.Dispose();

                g.Flush();
            }

            pbPreview.Image = img;
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
