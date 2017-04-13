using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ECE.Letter letter = new ECE.Letter();
            letter.Subject = "نامه آزمایشی";
            letter.LetterNo = "1385/05/05";
            letter.Priority = new ECE.Priority("فوری", "5");
            letter.Protocol = new ECE.Protocol("ECE");
            letter.Software = new ECE.Software("Whiz.ir", Guid.NewGuid().ToString());
            letter.Sender = new ECE.Sender("Algorithm Pouya", "100");
            letter.Receiver = new ECE.Receiver("Algorithm Pouya", "100");
            letter.Keywords.Add(new ECE.Keyword() { Value = "LetterInformation" });
            letter.LetterDateTime = new ECE.LetterDateTime(DateTime.Now, ECE.DateType.Gregorian);

            var serlizeString = ECE.Letter.Serialize(letter);
            Console.WriteLine(serlizeString);
            Console.ReadKey();

        }
    }
}
