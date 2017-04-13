using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE
{
    public class RelatedLetter
    {
        public RelationType RelationType { get; set; }
        public string RelatedLetterNo { get; set; }
        public LetterDateTime RelatedLetterDateTime { get; set; }
        public Sender RelatedLetterSender { get; set; }
    }
}
