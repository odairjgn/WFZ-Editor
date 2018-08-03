using System;
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
    public class watchfaceinfo
    {

        /// <remarks/>
        public decimal version { get; set; }

        /// <remarks/>
        public string author { get; set; }

        /// <remarks/>
        public string designer { get; set; }

        /// <remarks/>
        public string title { get; set; }

        /// <remarks/>
        public string basedOn { get; set; }

        /// <remarks/>
        public string preview { get; set; }

        /// <remarks/>
        public bool settings { get; set; }

        /// <remarks/>
        public string description { get; set; }
    }


}
