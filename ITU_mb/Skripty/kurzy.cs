using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ITU_mb.Skripty
{
    [XmlRoot(ElementName = "kurzy")]
    public class kurzy
    {
        [XmlElement(ElementName = "banka")]
        public string banka { get; set; }
        [XmlElement(ElementName = "datum")]
        public string datum { get; set; }
        [XmlElement(ElementName = "poradi")]
        public string poradi { get; set; }
        [XmlElement(ElementName = "tabulka")]
        public List<tabulka> tabulka { get; set; }
        [XmlElement(ElementName = "Source")]
        public string Source { get; set; }
    }
}
