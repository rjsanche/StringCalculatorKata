using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorKata;
using System;

namespace StringCalculatorTests
{
    [TestClass]
    public class StringCalculatorShould
    {
        [TestMethod]
        public void ReturnZeroWhenEmptyInput()
        {
            //arrange
            string input = string.Empty;
            int expected = 0;
            //act
            var result = StringCalculator.Add(input);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnNumberWhenInputIsOneNumber()
        {
            //arrange
            string input = "1";
            int expected = 1;
            //act
            var result = StringCalculator.Add(input);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnSumWhenInputIsTwoNumbers()
        {
            //arrange
            string input = "1,2";
            int expected = 3;
            //act
            var result = StringCalculator.Add(input);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnSumWhenUnknownAmountOfNumbers()
        {
            //arrange
            string input = "1,2,3,4";
            int expected = 10;
            //act
            var result = StringCalculator.Add(input);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnSumWhenNewLinesBetweenNumbers()
        {
            //arrange
            string input = "1\n2,3";
            int expected = 6;
            //act
            var result = StringCalculator.Add(input);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnSumWhenSupportingNewDelimiters()
        {
            //arrange
            string input = "//;\n1;2;3";
            int expected = 6;
            //act
            var result = StringCalculator.Add(input);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnSumWhenSupportingNewDelimitersWithoutSpecify()
        {
            //arrange
            string input = "1;2;3";
            int expected = 6;
            //act
            var result = StringCalculator.Add(input);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ThrowExceptionWhenInputIsNegative()
        {
            //arrange
            string input = "-1;2;3";
            var expected = "negatives not allowed -1";
            //act
            var actual = Assert.ThrowsException<NegativeInputException>(() => StringCalculator.Add(input));
            //assert
            Assert.AreEqual(expected, actual.Message);
        }


        ///https://osherove.com/tdd-kata-1/
    }
}
