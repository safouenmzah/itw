using System;
namespace ItWorksAssessment.Models
{
    public abstract class Document: IDocument
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public abstract void Print();     

    }
}
