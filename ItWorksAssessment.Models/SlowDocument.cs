using System;
using System.Threading;

namespace ItWorksAssessment.Models
{
    public class SlowDocument: StandardDocument
    {
        public int Delay { get; set; }
         
        public override void Print()
        {
            Console.WriteLine("Print Method :: SLow Document Class");

            for (int i = 1; i <= NumberOfCopies; i++)
            {
                Thread.Sleep(Delay * 1000);       
                WriteResults(this);
            }
        }

        
    }
}
