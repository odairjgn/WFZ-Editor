using SQLite.Net.Attributes;

namespace WFZ_Data.Entity
{
    [Table(nameof(FontInfo))]
    public class FontInfo : Entity
    {
        [NotNull, Unique]
        public string Name { get; set; }
    }
}
