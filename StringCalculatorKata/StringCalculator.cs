using System;

namespace StringCalculatorKata
{
    public static class StringCalculator
    {
        public static int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            string[] slices = input.Split(',');
            int sum = 0;
            foreach (string slice in slices)
            {
                sum += int.Parse(slice);
            }
            return sum;

        }
    }
}
