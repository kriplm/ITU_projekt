using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ITU_mb.Skripty
{
    public class tabulka
    {
        [XmlAttribute(AttributeName = "typ")]
        public string typ { get; set; }
        [XmlElement(ElementName = "radek")]
        public List<radek> radek { get; set; }
    }
}
