using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberStrings
{
    public static class Converter
    {
        public static Dictionary<int, string> UnitsMap => new Dictionary<int, string>
        {
            {1, "One"},
            {2, "Two"},
            {3, "Three"},
            {4, "Four"},
            {5, "Five"},
            {6, "Six"},
            {7, "Seven"},
            {8, "Eight"},
            {9, "Nine"}
        };

        public static string NumberToString(int number)
        {
            if (0 < number & number < 100)
            {
                return Convert1To99(number);
            }
            if (99 < number & number < 1000)
            {
                var hundreds = (number/100);
                return number%100 == 0
                    ? $"{UnitsMap[hundreds]} Hundred"
                    : $"{UnitsMap[hundreds]} Hundred and {Convert1To99(number%100)}";
            }
            if (999 < number & number < 10000)
            {
                var thousands = (number / 1000);
                if (number%1000 == 0)
                {
                    return $"{UnitsMap[thousands]} Thousand";
                }
                if (number/100%10 == 0)
                {
                    return $"{UnitsMap[thousands]} Thousand and {Convert1To99(number % 100)}";
                }
                return $"{ UnitsMap[thousands]} Thousand {UnitsMap[number / 100 % 10]} Hundred and {Convert1To99(number % 100)}";
            }
            return "";
        }

        private static string Convert1To99(int number)
        {
            var teensMap = new Dictionary<int, string>
            {
                {11, "Eleven"},
                {12, "Twelve"},
                {13, "Thirteen"},
                {14, "Fourteen"},
                {15, "Fifteen"},
                {16, "Sixteen"},
                {17, "Seventeen"},
                {18, "Eighteen"},
                {19, "Nineteen"},
            };
            var tensMap = new Dictionary<int, string>
            {
                {1, "Ten"},
                {2, "Twenty"},
                {3, "Thirty"},
                {4, "Forty"},
                {5, "Fifty"},
                {6, "Sixty"},
                {7, "Seventy"},
                {8, "Eighty"},
                {9, "Ninety"},
            };
            if (0 < number & number < 10)
            {
                return UnitsMap[number];
            }
            if (10 < number & number < 20)
            {
                return teensMap[number];
            }
            if (9 < number & number < 100 & number%10 == 0)
            {
                return tensMap[number/10];
            }
            if (9 < number & number < 100)
            {
                return $"{tensMap[number/10]} {UnitsMap[number%10]}";
            }
            return "";
        }
    }
}