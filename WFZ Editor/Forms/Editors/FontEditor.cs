using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFZ_Data.Entity;
using WFZ_Editor.Extentions;
using WFZ_Editor.UC;
using WFZ_Engine.Extentions;
using WFZ_Engine.Services;

namespace WFZ_Editor.Forms.Editors
{
    public partial class FontEditor : Form
    {
        private readonly Action _refreshaction;
        private readonly FontInfo _font;
        private FontFamily _currentFont = null;

        private FontFamily CurrentFont
        {
            get => _currentFont;
            set
            {
                _currentFont = value;
                ApplyFont();
            }
        }

        private void ApplyFont()
        {
            lbFont.Text = _currentFont.Name;

            var tamanho = new Size(pbPreviewFont.Size.Width * 2, pbPreviewFont.Size.Height * 2);
            var img = new Bitmap(tamanho.Width, tamanho.Height);
            using (var g = Graphics.FromImage(img))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (var f = new Font(_currentFont, tamanho.Height, FontStyle.Regular, GraphicsUnit.Pixel))
                {
                    g.FillRectangle(Brushes.White, new Rectangle(Point.Empty, tamanho));
                    var fm = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString("159A", f, Brushes.Black, new Rectangle(Point.Empty, tamanho), fm);
                }

                pbPreviewFont.Image = img;
            }
        }

        public FontEditor(Action refreshaction = null, FontInfo font = null)
        {
            _refreshaction = refreshaction;
            _font = font;
            InitializeComponent();
            CurrentFont = new FontFamily("Arial");
        }

        private void checkBoxChar_CheckedChanged(object sender, EventArgs e)
        {
            var ck = (sender as checkBoxChar);
            var ctrl = flpChars.Controls.OfType<ucChar>().FirstOrDefault(c => c.Char == ck.Char);

            if (ctrl != null && !ck.Checked)
                flpChars.Controls.Remove(ctrl);
            else if (ctrl == null && ck.Checked)
            {
                var position = flpChars.Controls.OfType<ucChar>()
                    .Where(c => c.Char < ck.Char)
                    .OrderBy(c => c.Char)
                    .FirstOrDefault(c => c.Char == ck.Char);

                var nchar = new ucChar() { Char = ck.Char };
                flpChars.Controls.Add(nchar);

                var p = position != null ? flpChars.Controls.GetChildIndex(position) : -1;
                flpChars.Controls.SetChildIndex(nchar, p + 1);
            }
        }

        private void btForeColorT_Click(object sender, EventArgs e)
        {
            cpForeColor.Color = Color.Transparent;
        }

        private void btBackColorT_Click(object sender, EventArgs e)
        {
            cpBackColor.Color = Color.Transparent;
        }

        private void btSelectSystemFont_Click(object sender, EventArgs e)
        {
            var fontDialog = new CustomFontDialog();

            if (_currentFont != null)
                fontDialog.FontFamily = _currentFont;

            if (fontDialog.ShowDialog() != DialogResult.OK) return;

            CurrentFont = fontDialog.FontFamily;
        }

        private FontStyle GetStyleFont()
        {
            var fon = FontStyle.Regular;

            if (ckBold.Checked) fon |= FontStyle.Bold;
            if (ckItalic.Checked) fon |= FontStyle.Italic;
            if (ckUnderline.Checked) fon |= FontStyle.Underline;
            if (ckStrikeOut.Checked) fon |= FontStyle.Strikeout;

            return fon;
        }

        private async void btCreate_Click(object sender, EventArgs e)
        {
            try
            {
                btCreate.Enabled = false;

                var chars = flpChars.Controls.OfType<ucChar>().Select(ct => ct.Char).ToArray();
                var imgs = await CreateFont(chars);

                foreach (var img in imgs)
                {
                    var control = flpChars.Controls.OfType<ucChar>().FirstOrDefault(ct => ct.Char == img.Key);

                    if (control != null)
                    {
                        control.Image = img.Value;
                        control.Image8c = img.Value.To8CPallet();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ShowError();
            }
            finally
            {
                btCreate.Enabled = true;
            }
        }

        private Task<Dictionary<char, Bitmap>> CreateFont(char[] chars)
        {
            return Task.Run(() =>
            {
                using (var builder = new BitmapFontBuilder(new Font(CurrentFont, (float)nudSize.Value), cpForeColor.Color, cpBackColor.Color, (float)nudPaddingX.Value, (float)nudPaddingY.Value, ckFixedSize.Checked))
                {
                    return builder.BuildFont(chars);
                }
            });
        }

        private void btSelectFileFont_Click(object sender, EventArgs e)
        {
            if (ofdFont.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (var col = new PrivateFontCollection())
                {
                    col.AddFontFile(ofdFont.FileName);
                    CurrentFont = col.Families[0];
                }
            }
            catch (Exception ex)
            {
                ex.ShowError();
            }
        }

        private async void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                btSave.Enabled = false;
                if (string.IsNullOrEmpty(txtName.Text))
                    throw new Exception("Entre a name!");

                var writerreader = new FontWriterAndReader(Confirm, ShowError);
                var font = flpChars.Controls.OfType<ucChar>()
                    .Select(c => (c.Char, (c.Image as Bitmap, c.Image8c as Bitmap)))
                    .ToDictionary(t => t.Item1, t => t.Item2);
                await writerreader.SaveFont(txtName.Text, 0, font);
                Close();
            }
            catch (Exception ex)
            {
                ex.ShowError();
            }
            finally
            {
                btSave.Enabled = true;
            }
        }

        private void ShowError(string msg)
        {
            MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool Confirm(string msg)
        {
            var resp = MessageBox.Show(msg, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return resp == DialogResult.Yes;
        }

        private void FontEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _refreshaction?.Invoke();
            }
            catch
            {
                // ignored
            }
        }

        private void FontEditor_Load(object sender, EventArgs e)
        {
            if (_font == null)
            {
                var defaulchars = "0123456789:".ToCharArray();
                var chck = groupCheckBoxes.Controls.OfType<checkBoxChar>().Where(cb => defaulchars.Contains(cb.Char));
                foreach (var ck in chck)
                {
                    ck.Checked = true;
                }
            }
        }
    }
}
