using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFZ_Engine.ValueObjects.Project
{
    public class Project
    {
        [Category("Project")]
        [Description("Id")]
        [DisplayName("Id")]
        [ReadOnly(true)]
        public long? Id { get; set; }

        [Category("Project")]
        [Description("Project Name")]
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }

        [Category("Project")]
        [Description("Creation Time")]
        [DisplayName("Creation Time")]
        [ReadOnly(true)]
        public DateTime CreateTime { get; set; } = DateTime.Now;

        [Category("Description")]
        [Description("Name of WFZ")]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Category("Description")]
        [Description("Version of project")]
        [DisplayName("Version")]
        public decimal Version { get; set; } = 1;

        [Category("Description")]
        [Description("Description text")]
        [DisplayName("Description Text")]
        public string Description { get; set; }


        [Category("Description")]
        [Description("Author")]
        [DisplayName("Author")]
        public string Author { get; set; }

        [Category("Description")]
        [Description("Designer")]
        [DisplayName("Designer")]
        public string Designer { get; set; }

        [Category("Description")]
        [Description("Based On")]
        [DisplayName("Based On")]
        public string BasedOn { get; set; }

        [Browsable(false)]
        public Background Background { get; set; } = new Background();
    }
}
