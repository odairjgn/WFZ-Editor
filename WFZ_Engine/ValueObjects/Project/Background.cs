using System.ComponentModel;
using System.Drawing;

namespace WFZ_Engine.ValueObjects.Project
{
    public class Background
    {
        [Category("Background")]
        [Description("Base color of watchface")]
        [DisplayName("Background Color")]
        public Color BaseColor { get; set; } = Color.Black;
    }
}
