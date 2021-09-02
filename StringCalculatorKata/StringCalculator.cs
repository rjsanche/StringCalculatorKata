﻿using System;

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
            foreach (string slice in slices)
            {
                sum += int.Parse(slice);
            }
            return sum;

        }

        private static char[] GetNewDelimitersCollection(ref string input)
        {
            if (input.StartsWith("//"))
            {
                string startNewDelimiterToken = "//";
                char delimiter = input.Substring(input.IndexOf(startNewDelimiterToken) + startNewDelimiterToken.Length, 1)[0];
                input = input.Substring(input.IndexOf('\n') + 1);
                char[] newDelimiters = new char[defaultDelimiters.Length + 1];
                defaultDelimiters.CopyTo(newDelimiters, 0);
                newDelimiters[newDelimiters.Length - 1] = delimiter;
                return newDelimiters;
            }
            return null;
        }


    }
}
