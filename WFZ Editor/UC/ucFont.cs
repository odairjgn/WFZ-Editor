using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WFZ_Data.Entity;
using WFZ_Data.Services;
using WFZ_Editor.Extentions;

namespace WFZ_Editor.UC
{
    public partial class ucFont : UserControl
    {
        public ucFont(FontInfo f)
        {
            InitializeComponent();
            var folder = FileManager.GetFontFolder(f.Id);
            var img = new DirectoryInfo(folder).GetFiles("*.png").FirstOrDefault();

            if (img != null)
            {
                using (var fs = File.Open(img.FullName, FileMode.Open))
                {
                    pbPreview.Image = Image.FromStream(fs);
                    fs.Close();
                }
            }

            lbName.Text = f.Name;
            lbDetails.Text = $"#{f.Id:D8} ({f.Date})";
            FontInfo = f;
        }

        public FontInfo FontInfo { get; }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Delete();
        }

        private async void Delete()
        {
            try
            {
                var pasta = FileManager.GetFontFolder(FontInfo.Id);
                await WFZ_Data.Respositories.Fonts.Delete(FontInfo);

                if(Directory.Exists(pasta))
                    Directory.Delete(pasta, true);

                Parent.Controls.Remove(this);
            }
            catch (Exception e)
            {
                e.ShowError();
            }
        }
    }
}
