using ItWorksAssessment.Interface;
using System.Collections.Generic;

namespace ItWorksAssessment.Library
{
    public class ItWorksAssessmentService : IItWorksAssessmentService
    {
        /// <summary>
        /// Prints the list of Numbers Less Than Passed Number
        /// And Divisible By Seven
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int[] PrintNumbers(int number)
        {
            List<int> myList = new List<int>();
            if (number > 0)
            {
                for (int i = 1; i < number; i++)
                {
                    if (i % 7 == 0)
                    {
                        myList.Add(i);                   
                    }                   
                }
                return myList.ToArray();
            }
            else
            {
                //commented to handle the case where we pass 0 as a paramter
                //or a negative number similarily
                //myList.Add(0);
                return myList.ToArray();
            }
        }
    }

}
