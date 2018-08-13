using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using WFZ_Engine.Extentions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SQLite.Net;
using WFZ_Data;
using WFZ_Data.Entity;
using WFZ_Data.Services;
using WFZ_Engine.Componentes;
using WFZ_Engine.XMLFiles;

namespace WFZ_Engine.Services
{
    public class FontWriterAndReader
    {
        public FontWriterAndReader(ConfirmDelegate confirm, ShowErrorDelegate showError)
        {
            Confirm = confirm;
            ShowError = showError;
        }

        public delegate bool ConfirmDelegate(string msg);

        public delegate void ShowErrorDelegate(string msg);

        public ConfirmDelegate Confirm { get; }
        public ShowErrorDelegate ShowError { get; }

        public async Task SaveFont(string name, long id, Dictionary<char, Bitmap> images)
        {
            var fontinfo = await Respositories.Fonts.Find(id);
            try
            {
                if (fontinfo == null)
                {
                    fontinfo = new FontInfo()
                    {
                        Name = name
                    };

                    await Respositories.Fonts.Insert(fontinfo);
                    fontinfo.Id = id = await Respositories.Fonts.GetLastId();
                }
                else
                {
                    fontinfo.Date = DateTime.Now;
                }


                await Respositories.Fonts.InsertOrReplace(fontinfo);
            }
            catch (SQLiteException e) when (e.Message == "Constraint")
            {
                throw new Exception("Name must be unique!", e);
            }


            var fontwtz = new WatchFace();
            var fontFolder = new DirectoryInfo(FileManager.GetFontFolder(id));
            var fontfolder8c = new DirectoryInfo(Path.Combine(fontFolder.FullName, "8c"));

            if (!fontfolder8c.Exists)
                fontfolder8c.Create();

            fontFolder.GetFiles().AsParallel().ForAll(f => f.Delete());
            foreach (var bitmap in images)
            {
                if (bitmap.Value == null) continue;
                var filename = GetName(bitmap.Key);
                var item = new WatchFaceWatchFaceItem();
                item.type = ItemType.Font;
                item.config = $"@wfz/font/{id:D8}/{filename}";
                item.charset = bitmap.Key.ToString();
                fontwtz.WatchFaceItem.Add(item);

                var png = Path.Combine(fontFolder.FullName, filename);
                var png8c = Path.Combine(fontfolder8c.FullName, filename);

                bitmap.Value.Save(png, ImageFormat.Png);
                using (var bitmap8c = bitmap.Value.To8CPallet())
                {
                   bitmap8c.Save(png8c, ImageFormat.Png);
                }
            }

            var xmlserializer = new XmlSerializer(fontwtz.GetType());
            using (var strwriter = new StreamWriterUTF8(Path.Combine(fontFolder.FullName, "font.xml")))
            {
                var ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                xmlserializer.Serialize(strwriter, fontwtz, ns);
                strwriter.Close();
            }
        }

        private string GetName(char bitmapKey)
        {
            if (char.IsLetter(bitmapKey) && char.IsLower(bitmapKey))
                return $"{bitmapKey}_.png";
            else if (char.IsLetterOrDigit(bitmapKey))
                return $"{bitmapKey}.png";
            else
                return $"{((int)bitmapKey):X4}.png";
        }
    }
}
