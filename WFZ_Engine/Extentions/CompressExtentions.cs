using System.IO.Compression;
using System.Text;

namespace WFZ_Engine.Extentions
{
    public static class CompressExtentions
    {
        public static async void Teste()
        {
            ZipArchive zip = ZipFile.Open("zip", ZipArchiveMode.Update, Encoding.UTF8);
            var strm = zip.Entries[0].Open();
            await strm.WriteAsync(new byte[] {1, 2, 3}, 0, 3);
        }
    }
}
