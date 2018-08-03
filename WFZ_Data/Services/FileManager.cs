using System.IO;

namespace WFZ_Data.Services
{
    public class FileManager
    {
        public static string Root
        {
            get
            {
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "Files");
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                return folder;
            }
        }

        public static string DBFolder
        {
            get
            {
                var folder = Path.Combine(Root, "Data");
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                return folder;
            }
        }

        public static string FontsFolder
        {
            get
            {
                var folder = Path.Combine(Root, "Fonts");
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                return folder;
            }
        }

        public static string DBFileName => Path.Combine(DBFolder, "Database.db");

        public static string GetFontFolder(long id)
        {
            var f = Path.Combine(FontsFolder, id.ToString("D8"));
            if (!Directory.Exists(f)) Directory.CreateDirectory(f);
            return f;
        }
    }
}
