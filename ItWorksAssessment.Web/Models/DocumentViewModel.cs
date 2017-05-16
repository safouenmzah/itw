using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItWorksAssessment.Web.Models
{
    public class DocumentViewModel
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int NumberOfCopies { get; set; }
        public int Delay { get; set; }

        public DocumentTypeEnum DocumentType { get; set; }
    }
}