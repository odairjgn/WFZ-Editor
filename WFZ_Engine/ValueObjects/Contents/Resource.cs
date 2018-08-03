using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFZ_Engine.ValueObjects.Contents
{
    public enum ResourceType
    {
        Font,
        Background,
        TimeHands,
        Scales,
        Bitmaps
    }

    public abstract class Resource
    {
        public abstract ResourceType Type { get; }
    }
}
