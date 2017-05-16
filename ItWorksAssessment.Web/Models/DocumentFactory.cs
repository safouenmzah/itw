using ItWorksAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItWorksAssessment.Web.Models
{
    public class DocumentFactory
    {
        public static IDocument Create(DocumentTypeEnum documentType, 
            DocumentViewModel documentViewModel)
        {
            IDocument document = null;

            switch (documentType)
            {
                case DocumentTypeEnum.SlowDocument:
                    document = new SlowDocument
                    {
                        Name = documentViewModel.Name,
                        Content = documentViewModel.Content,
                        Delay = documentViewModel.Delay,
                        NumberOfCopies = documentViewModel.NumberOfCopies
                    };
                    break;

                case DocumentTypeEnum.StandardDocument:
                    document = new StandardDocument
                    {
                        Name = documentViewModel.Name,
                        Content = documentViewModel.Content,                        
                        NumberOfCopies = documentViewModel.NumberOfCopies
                    };
                    break;

                case DocumentTypeEnum.QuickDocument:
                    document = new QuickDocument
                    {
                        Name = documentViewModel.Name,
                        Content = documentViewModel.Content                       
                    };
                    break;
            }

            return document;

        }
    }
}