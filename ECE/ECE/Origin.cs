using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ECE
{
    public class Origin
    {
        [XmlAttribute]
        public string ContentType { get; set; }
        [XmlAttribute]
        public string Extension { get; set; }
        [XmlAttribute]
        public string Description { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
