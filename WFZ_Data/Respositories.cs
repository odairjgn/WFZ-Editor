using WFZ_Data.Entity;
using WFZ_Data.Services;

namespace WFZ_Data
{
    public static class Respositories
    {
        private static GenericRepositorie<FontInfo> _fonts;
        public static GenericRepositorie<FontInfo> Fonts => _fonts ?? (_fonts = new GenericRepositorie<FontInfo>());
    }
}
