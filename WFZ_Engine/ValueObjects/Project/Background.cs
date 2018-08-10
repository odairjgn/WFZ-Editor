using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
