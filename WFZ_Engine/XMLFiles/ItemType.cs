using System.Xml.Serialization;

namespace WFZ_Engine.XMLFiles
{
    public enum ItemType
    {
        [XmlEnum("background")]
        BackGround,

        [XmlEnum("statusbar")]
        StatusBar,

        [XmlEnum("timedigital")]
        TimeDigital,

        [XmlEnum("datawidget")]
        DataWidget,

        [XmlEnum("timehand")]
        TimeHand,

        [XmlEnum("font")]
        Font
    }
}