using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WFZ_Engine.XMLFiles
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class WatchFaceWatchFaceItem
    {
        /// <remarks/>
        [XmlAttribute]
        public ItemType type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string config { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public short y { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool ySpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public short x { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool xSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public short width { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool widthSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public short height { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool heightSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string font { get; set; }

        [XmlAttribute]
        public string charset { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public ushort id { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool idSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public DataType dataType { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool dataTypeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public short model { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool modelSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string configList { get; set; }
    }
}