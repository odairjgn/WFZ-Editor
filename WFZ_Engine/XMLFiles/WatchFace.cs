using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WFZ_Engine.XMLFiles
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WatchFace
    {

        /// <remarks/>
        [XmlElement("WatchFaceItem")]
        public List<WatchFaceWatchFaceItem> WatchFaceItem { get; set; } = new List<WatchFaceWatchFaceItem>();

        /// <remarks/>
        [XmlAttribute]
        public string version { get; set; } = "1.0";
    }
}
