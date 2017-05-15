using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ItWorksAssessment.Library;

namespace ItWorksAssessment.Tests
{
    [TestClass]
    public class ItWorksAssessmentTests
    {
        private ItWorksAssessmentService _itWorksAssessmentService;


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
    }
}
