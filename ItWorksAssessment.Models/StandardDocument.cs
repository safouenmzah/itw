using System;

namespace ItWorksAssessment.Models
{
    public class StandardDocument: Document
    {
        public int NumberOfCopies { get; set; }       
        public override void Print()
        {
            Console.WriteLine("Print Method :: Standard Document Class");
        }

        //public override string Print()
        //{
        //    Console.WriteLine("Print Method :: Standard Document Class");
        //    string result = string.Empty;
        //    for (int i = 1; i < NumberOfCopies;)
        //    {
        //        var _array = " Document Name is : " + Name + " and its content is: " + Content;
        //        result = string.Join(" , ", _array);
        //    }

        //    return result;
        //}

    }
}
