using ItWorksAssessment.Models;
using ItWorksAssessment.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItWorksAssessment.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Print(DocumentViewModel document)
        {
            IDocument _document = null;
            //Create Document using IDocument interface
            switch (document.DocumentType)
            {
                case DocumentTypeEnum.SlowDocument:
                    _document = DocumentFactory
                        .Create(DocumentTypeEnum.SlowDocument, document);
                    return PartialView("~/Views/Shared/_DocumentDetails.cshtml", _document);

                case DocumentTypeEnum.StandardDocument:
                    _document = DocumentFactory
                        .Create(DocumentTypeEnum.StandardDocument, document);
                    return PartialView("~/Views/Shared/_DocumentDetails.cshtml", _document);

                case DocumentTypeEnum.QuickDocument:
                    _document = DocumentFactory
                        .Create(DocumentTypeEnum.QuickDocument, document);
                    return PartialView("~/Views/Shared/_DocumentDetails.cshtml", _document);

                default:
                    return PartialView("~/Views/Shared/_Error.cshtml");
            }


        }

        //public ActionResult Print(DocumentViewModel document)
        //{
        //    IDocument _document = null;
        //    //Create Document using IDocument interface
        //    switch (document.DocumentType)
        //    {
        //        case DocumentTypeEnum.SlowDocument:
        //            _document = DocumentFactory
        //                .Create(DocumentTypeEnum.SlowDocument, document);                   
        //            return PartialView("~/Views/Shared/_SlowDocumentDetails.cshtml", _document);

        //        case DocumentTypeEnum.StandardDocument:
        //            _document = DocumentFactory
        //                .Create(DocumentTypeEnum.StandardDocument, document);                   
        //            return PartialView("~/Views/Shared/_StandardDocumentDetails.cshtml", _document);

        //        case DocumentTypeEnum.QuickDocument:
        //            _document = DocumentFactory
        //                .Create(DocumentTypeEnum.QuickDocument, document);                    
        //            return PartialView("~/Views/Shared/_QuickDocumentDetails.cshtml", _document);

        //        default:                    
        //            return PartialView("~/Views/Shared/_Error.cshtml");
        //    }


        //}
    }
}