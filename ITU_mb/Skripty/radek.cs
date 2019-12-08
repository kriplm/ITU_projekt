using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ITU_mb.Skripty
{
    public class radek
    {
        [XmlAttribute(AttributeName = "kod")]
        public string kod { get; set; }
        [XmlAttribute(AttributeName = "mena")]
        public string mena { get; set; }
        [XmlAttribute(AttributeName = "mnozstvi")]
        public string mnozstvi { get; set; }
        [XmlAttribute(AttributeName = "kurz")]
        public string kurz { get; set; }
        [XmlAttribute(AttributeName = "zeme")]
        public string zeme { get; set; }

    }
}

