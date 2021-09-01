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
    }
}
