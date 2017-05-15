namespace ItWorksAssessment.Helpers
{
    public static class StringExtensions
    {
        public static string Reverse(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }
}
