﻿using NUnit.Framework;

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
        [TestCase(40, "Forty")]
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

        [Test]
        [TestCase(29, "Twenty Nine")]
        [TestCase(38, "Thirty Eight")]
        [TestCase(47, "Forty Seven")]
        [TestCase(56, "Fifty Six")]
        [TestCase(65, "Sixty Five")]
        [TestCase(74, "Seventy Four")]
        [TestCase(83, "Eighty Three")]
        [TestCase(92, "Ninety Two")]
        [TestCase(91, "Ninety One")]
        public void TwoDigits(int number, string numberName)
        {
            Assert.AreEqual(numberName, Converter.NumberToString(number));
        }

        [Test]
        [TestCase(100, "One Hundred")]
        [TestCase(200, "Two Hundred")]
        [TestCase(300, "Three Hundred")]
        [TestCase(400, "Four Hundred")]
        [TestCase(500, "Five Hundred")]
        [TestCase(600, "Six Hundred")]
        [TestCase(700, "Seven Hundred")]
        [TestCase(800, "Eight Hundred")]
        [TestCase(900, "Nine Hundred")]
        [TestCase(101, "One Hundred and One")]
        [TestCase(209, "Two Hundred and Nine")]
        [TestCase(310, "Three Hundred and Ten")]
        [TestCase(411, "Four Hundred and Eleven")]
        [TestCase(520, "Five Hundred and Twenty")]
        [TestCase(617, "Six Hundred and Seventeen")]
        [TestCase(763, "Seven Hundred and Sixty Three")]
        [TestCase(847, "Eight Hundred and Forty Seven")]
        [TestCase(999, "Nine Hundred and Ninety Nine")]
        public void MultiplesOf100To900(int number, string numberName)
        {
            Assert.AreEqual(numberName, Converter.NumberToString(number));
        }
    }
}
