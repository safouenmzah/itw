using System;

namespace ItWorksAssessment.Models
{
    public class SlowDocument: Document
    {
        public int Delay { get; set; }
         
        public override void Print()
        {
            Console.WriteLine("Print Method :: SLow Document Class");
        }

        //public override string Print()
        //{
        //    Console.WriteLine("Print Method :: SLow Document Class");
        //    return base.Print();
        //}
    }
}
