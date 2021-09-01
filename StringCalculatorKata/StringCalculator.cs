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
                return int.Parse(slices[0]) + int.Parse(slices[1]);
            }
            return int.Parse(slices[0]);

        }
    }
}
