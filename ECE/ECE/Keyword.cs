using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ECE
{
    public class Keyword
    {
        [XmlText]
        public string Value { get; set; }
    }
}
