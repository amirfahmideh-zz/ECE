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
        private DateTime _datetime;

        [XmlAttribute]
        public DateType ShowAs { get; set; }

        [XmlText]
        public string Value { get { return _datetime.ToString("s", System.Globalization.CultureInfo.InvariantCulture); } set { DateTime.Parse(value); } }
        public LetterDateTime()
        {

        }
        public LetterDateTime(DateTime datetime, DateType showAs)
        {
            _datetime = datetime;
            ShowAs = showAs;
        }
    }
}
