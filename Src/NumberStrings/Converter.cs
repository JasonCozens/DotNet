using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberStrings
{
    public static class Converter
    {
        public static string NumberToString(int number)
        {
            var digitMap = new Dictionary<int, string>
            {
                {1, "One"},
                {2, "Two"},
                {3, "Three"},
                {4, "Four"},
                {5, "Five"},
                {6, "Six"},
                {7, "Seven"},
                {8, "Eight"},
                {9, "Nine"},
            };
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
                {4, "Fourty"},
                {5, "Fifty"},
                {6, "Sixty"},
                {7, "Seventy"},
                {8, "Eighty"},
                {9, "Ninety"},
            };
            if (0 < number & number < 10)
            {
                return digitMap[number];
            }
            if (10 < number & number < 20)
            {
                return teensMap[number];
            }
            if (9 < number & number < 100 & number % 10 == 0)
            {
                return tensMap[number / 10];
            }
            return $"{tensMap[number / 10]} {digitMap[number % 10]}";
        }
    }
}
