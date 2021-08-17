using System;
using System.Collections.Generic;
using System.Linq;

namespace leetCode
{
    public class IntToRomanClass
    {
        Dictionary<int, string> literals = new Dictionary<int, string>() {
        {1000,"M"},
        {900,"CM"},
        {500,"D"},
        {400,"CD"},
        {100,"C"},
        {90,"XC"},
        {50,"L"},
        {40,"XL"},
        {10,"X"},
        {9,"IX"},
        {5,"V"},
        {4,"IV"},
        {1,"I"},
        };
        public string IntToRoman(int input)
        {
            string output = "";
            foreach (var item in literals)
            {
                while (input >= item.Key)
                {
                    output += item.Value;
                    input -= item.Key;
                }
            }
            return output;
        }
    }
}
