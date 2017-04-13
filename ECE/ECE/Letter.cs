using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ECE
{
    public class Letter
    {
        public Protocol Protocol { get; set; }
        public Software Software { get; set; }
        public Sender Sender { get; set; }
        public Receiver Receiver { get; set; }
        public List<OtherReceiver> OtherReceivers { get; set; } = new List<OtherReceiver>();
        public string LetterNo { get; set; }
        public LetterDateTime LetterDateTime { get; set; }
        public List<RelatedLetter> RelatedLetters { get; set; } = new List<RelatedLetter>();
        public string Subject { get; set; }
        public Priority Priority { get; set; }
        public Classification Classification { get; set; }
        public List<Keyword> Keywords { get; set; } = new List<Keyword>();
        public List<Origin> Origins { get; set; } = new List<Origin>();
        public List<Attachment> Attachments { get; set; } = new List<Attachment>();
        public static string Serialize(Letter letter)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(letter.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, letter);
                return stringWriter.ToString();
            }
        }
        public static Letter DeSerialize(string xmlText)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Letter));
            using (StringWriter stringWriter = new StringWriter())
            {
                StringReader stringReader = new StringReader(xmlText);
                return (Letter)xmlSerializer.Deserialize(stringReader);
            }
        }
    }
}
