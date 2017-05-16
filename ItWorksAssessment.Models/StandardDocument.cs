using System;

namespace ItWorksAssessment.Models
{
    public class StandardDocument: Document
    {
        public int NumberOfCopies { get; set; }       
        public override void Print()
        {
            Console.WriteLine("Print Method :: Standard Document Class");

            for (int i = 1; i < NumberOfCopies; i++)
            {
                WriteResults(this);
            }
        }        
    }
}
