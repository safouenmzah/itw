using System.Linq;

namespace ItWorksAssessment.Helper
{
    public static class StringExtensions
    {
        public static string Reverse(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }
}



