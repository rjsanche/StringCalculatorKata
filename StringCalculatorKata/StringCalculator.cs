using System;

namespace StringCalculatorKata
{
    public static class StringCalculator
    {
        private static char[] delimiters = new char[] { ',', '\n' };
        public static int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            string[] slices = input.Split(delimiters);
            int sum = 0;
            foreach (string slice in slices)
            {
                sum += int.Parse(slice);
            }
            return sum;

        }
    }
}
