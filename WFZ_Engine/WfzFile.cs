using System.Collections.Generic;
using WFZ_Engine.ValueObjects.Contents;
using WFZ_Engine.XMLFiles;

namespace WFZ_Engine
{
    public class WfzFile
    {
        public watchfaceinfo Description { get; set; } = new watchfaceinfo();
        public WatchFace WatchFace { get; set; } = new WatchFace();

        public List<WatchFace> ElementsLists { get; set; }
        public List<Resource> Resources { get; set; } = new List<Resource>();
    }
}
