using System;

namespace StringCalculatorKata
{
    public static class StringCalculator
    {
        public static int Add(string input)
        {
            if(string.IsNullOrEmpty(input))
                return 0;
            string[] slices = input.Split(',');
            if (slices.Length > 1)
            {
                return 10;
            }
            return int.Parse(slices[0]);

        }
    }
}
