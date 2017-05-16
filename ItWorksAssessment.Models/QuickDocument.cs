

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
    }
}
