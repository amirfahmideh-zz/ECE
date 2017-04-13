using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ECE
{
    public class LetterDateTime
    {
        [XmlAttribute]
        public DateType ShowAs { get; set; }
        [XmlText]
        public string Value { get; set; }
        public LetterDateTime()
        {

        }
        public LetterDateTime(string datetime, DateType showAs)
        {
            Value = datetime;
            ShowAs = showAs;
        }
    }
}
