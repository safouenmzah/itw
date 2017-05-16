using System;
namespace ItWorksAssessment.Models
{
    public abstract class Document: IDocument
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public abstract void Print();
        protected void WriteResults(IDocument document)
        {
            WriteResults("Document Name", document.Name);
            WriteResults("Document Content", document.Content);
        }

        protected void WriteResults(string description, string result)
        {
            Console.WriteLine($"{description}: {result} at " + DateTime.Now, description, result);
        }
    }
}
