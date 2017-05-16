using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ItWorksAssessment.Library;
using ItWorksAssessment.Models;

namespace ItWorksAssessment.Tests
{
    [TestClass]
    public class ItWorksAssessmentTests
    {
        private ItWorksAssessmentService _itWorksAssessmentService;

        private static IDocument CreateQuickDocument()
        {
            return new QuickDocument
            {
                Name = "Quick Document",
                Content = "Quick Document Content..."                
            };
        }

       

        private static IDocument CreateStandardDocument()
        {
            return new StandardDocument
            {
                Name = "Standard Document",
                Content = "Standard Document Content",
                NumberOfCopies = 5
            };
        }

        private static IDocument CreateSlowDocument()
        {
            return new SlowDocument
            {
                Name = "Slow Document",
                Content = "Slow Document Content",
                NumberOfCopies = 7,
                Delay = 5
            };
        }

        public ItWorksAssessmentTests()
        {
            _itWorksAssessmentService = new ItWorksAssessmentService();
        }

        [TestMethod]
        public void ShouldReturnAnEmptyArray()
        {
            //Arrange
            int[] myArray = new int[0];          

            //Assert
            CollectionAssert.AreEqual(myArray, _itWorksAssessmentService.PrintNumbers(0));
        }

        [TestMethod]
        public void ShouldReturnASingeltonArrayWith0()
        {
            //Arrange
            int[] myArray = new int[] { 0 };

            //Assert
            CollectionAssert.AreEqual(myArray, _itWorksAssessmentService.PrintNumbers(0));
        }



        [TestMethod]
        public void ShouldReturnAnEmptyArrayFaked()
        {
            //Arrange
            int[] myArray = new int[0];

            var result = _itWorksAssessmentService.PrintNumbers(7);

            CollectionAssert.AreEqual(myArray, result);
        }


        [TestMethod]
        public void ShouldReturnASingeltonArrayWith7InIt()
        {
            //Arrange
            int[] myArray = new int[] { 7 };
            //Act
            var result = _itWorksAssessmentService.PrintNumbers(8);
            //Assert
            CollectionAssert.AreEqual(myArray, result);
        }

        [TestMethod]
        public void ShouldPrintASpecificArray()
        {
            //Arrange
            int[] myArray = new int[] { 7, 14, 21, 28, 35, 42, 49 };

            //Act
            var result = _itWorksAssessmentService.PrintNumbers(50);

            //Assert
            CollectionAssert.AreEqual(myArray, result);
        }


        #region Document Application tests
        [TestMethod]
        public void ShouldCallQuickDocumentPrintMethod()
        {
            //Arrange
            IDocument document = CreateQuickDocument();
            //Act
            document.Print();

            //Assert
            //console
        }

        [TestMethod]
        public void ShouldCallStandardDocumentPrintMethod()
        {
            //Arrange
            IDocument document = CreateStandardDocument();
            //Act
            document.Print();

            //Assert
            //console
        }

        [TestMethod]
        public void ShouldCallSlowDocumentPrintMethod()
        {
            //Arrange
            IDocument document = CreateSlowDocument();
            //Act
            document.Print();

            //Assert
            //console
        }
        #endregion
    }
}
