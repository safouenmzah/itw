using ItWorksAssessment.Models;
using System;

namespace ItWorksAssessment.DocumentApplication
{
    public class DocumentApplication
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("````````` Documents Application````` ");

            IDocument document = CreateDocument();            

            GetDocumentName(document);
            GetDocumentContent(document);

            Console.WriteLine("Printing...");

            document.Print();

            
        }

        private static IDocument CreateDocument()
        {
            return new QuickDocument();
        }
        private static void GetDocumentName(IDocument document)
        {
            try
            {
                Console.WriteLine("Enter a name");
                document.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void GetDocumentContent(IDocument document)
        {
            try
            {
                Console.WriteLine("Enter a content");
                document.Content = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }    
  
    }
}
