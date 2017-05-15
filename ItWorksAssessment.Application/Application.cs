using System;
using ItWorksAssessment.CachingDecorater;
using ItWorksAssessment.Library;
using System.Threading;
using ItWorksAssessment.Helper;
using ItWorksAssessment.Models;

namespace ItWorksAssessment.Application
{
    public class Application
    {
        public static void Main(string[] args)
        {
            //without using caching
            var service = new ItWorksAssessmentService();
            var result = service.PrintNumbers(50);
            Console.Write("[");
            Console.Write(string.Join(",", result));
            Console.Write("]");



            Console.WriteLine("````````````````````````");

            //using caching
            var wrappedService = new ItWorksAssessmentService();
            var cachedService = new CachingService(wrappedService);
            var cachedResult = cachedService.PrintNumbers(50);
            Console.Write("[");
            Console.Write(string.Join(",", cachedResult));
            Console.Write("]");

            Console.WriteLine();
            Console.WriteLine("Waiting 10 seconds...");
            Console.WriteLine();

            Thread.Sleep(10000);

            Console.Write("[");
            Console.Write(string.Join(",", cachedService.PrintNumbers(20)));
            Console.Write("]");

            Console.WriteLine();
            Console.WriteLine("Waiting 5 seconds...");
            Console.WriteLine();

            Thread.Sleep(5000);

            Console.Write("[");
            Console.Write(string.Join(",", cachedService.PrintNumbers(20)));
            Console.Write("]");


            Console.WriteLine();
            Console.WriteLine("Waiting 20 seconds...");
            Console.WriteLine();

            Thread.Sleep(20000);

            Console.Write("[");
            Console.Write(string.Join(",", cachedService.PrintNumbers(20)));
            Console.Write("]");



            //Reverse an input string


            Console.WriteLine();
            Console.WriteLine("Input a string...");
            var input = Console.ReadLine();
            Console.WriteLine("Reversed string is: " + input.Reverse());
        }
    }
}
