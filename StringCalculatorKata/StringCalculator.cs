using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public static class StringCalculator
    {
        private static char[] defaultDelimiters = new char[] { ',', '\n' };
        public static int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            char[] newDelimiters = GetNewDelimitersCollection(ref input);
            char[] separator = newDelimiters == null ? defaultDelimiters : newDelimiters;
            string[] slices = input.Split(separator);
            int sum = 0;
            List<string> errors = new List<string>();
            foreach (string slice in slices)
            {
                int number = int.Parse(slice);
                if(number < 0)
                {
                    errors.Add(slice);
                }
                sum += number;
            }
            if(errors.Any())
            {
                throw new NegativeInputException(String.Join(',', errors));
            }
            return sum;

        }

        private static char[] GetNewDelimitersCollection(ref string input)
        {
            char possibleDelimiter = defaultDelimiters[0];
            if (input.StartsWith("//"))
            {
                string startNewDelimiterToken = "//";
                possibleDelimiter = input.Substring(input.IndexOf(startNewDelimiterToken) + startNewDelimiterToken.Length, 1)[0];
                input = input.Substring(input.IndexOf('\n') + 1);
            }
            else
            {
                foreach (char c in input)
                {
                    if (!Char.IsDigit(c))
                    {
                        if (possibleDelimiter == c)
                        {
                            break;
                        }
                        if (!defaultDelimiters.Any(x => x == c))
                        {
                            possibleDelimiter = c;
                        }
                    }
                }
            }
            if (possibleDelimiter != defaultDelimiters[0])
            {
                char[] newDelimiters = new char[defaultDelimiters.Length + 1];
                defaultDelimiters.CopyTo(newDelimiters, 0);
                newDelimiters[newDelimiters.Length - 1] = possibleDelimiter;
                return newDelimiters;
            }
            return null;
        }


    }
}
