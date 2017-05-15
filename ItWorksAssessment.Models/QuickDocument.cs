

using System;

namespace ItWorksAssessment.Models
{
    public class QuickDocument: Document
    {       
        public override void Print()
        {
            Console.WriteLine("Print Method :: Quick Document Class");
            WriteResults(this);

        }


        private static void WriteResults(QuickDocument document)
        {
            WriteResults("Document Name", document.Name);
            WriteResults("Document Content", document.Content);
        }

        private static void WriteResults(string description, string result)
        {
            Console.WriteLine($"{description}: {result}", description, result);
        }
       
    }
}
