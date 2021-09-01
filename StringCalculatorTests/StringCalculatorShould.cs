using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorKata;

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
    }
}
