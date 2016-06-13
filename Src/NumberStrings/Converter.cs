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
            return digitMap[number];
        }
    }
}
