using NUnit.Framework;

namespace NumberStrings.NUnit
{
    [TestFixture]
    public class ConverterTest
    {
        [Test]
        [TestCase(1, "One")]
        [TestCase(2, "Two")]
        [TestCase(3, "Three")]
        [TestCase(4, "Four")]
        [TestCase(5, "Five")]
        [TestCase(6, "Six")]
        [TestCase(7, "Seven")]
        [TestCase(8, "Eight")]
        [TestCase(9, "Nine")]
        public void SingleDigit(int digit, string digitName)
        {
            Assert.AreEqual(digitName, Converter.NumberToString(digit));
        }

        [Test]
        [TestCase(10, "Ten")]
        [TestCase(20, "Twenty")]
        [TestCase(30, "Thirty")]
        [TestCase(40, "Fourty")]
        [TestCase(50, "Fifty")]
        [TestCase(60, "Sixty")]
        [TestCase(70, "Seventy")]
        [TestCase(80, "Eighty")]
        [TestCase(90, "Ninety")]
        public void MultiplesOf10To90(int number, string numberName)
        {
            Assert.AreEqual(numberName, Converter.NumberToString(number));
        }

        [Test]
        [TestCase(11, "Eleven")]
        [TestCase(12, "Twelve")]
        [TestCase(13, "Thirteen")]
        [TestCase(14, "Fourteen")]
        [TestCase(15, "Fifteen")]
        [TestCase(16, "Sixteen")]
        [TestCase(17, "Seventeen")]
        [TestCase(18, "Eighteen")]
        [TestCase(19, "Nineteen")]
        public void Teens(int digit, string digitName)
        {
            Assert.AreEqual(digitName, Converter.NumberToString(digit));
        }
    }
}
