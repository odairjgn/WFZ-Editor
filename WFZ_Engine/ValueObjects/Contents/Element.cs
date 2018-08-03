using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFZ_Engine.XMLFiles;

namespace WFZ_Engine.ValueObjects.Contents
{
    public abstract class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }
    }
}
