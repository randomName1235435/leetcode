using System;
using System.Collections.Generic;

namespace leetCode
{
    public class LetterCombinationsClass
    {
        private Dictionary<char, string> maaping = new Dictionary<char, string>();

        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return Array.Empty<string>();

            maaping.Add('2', "abc");
            maaping.Add('3', "def");
            maaping.Add('4', "ghi");
            maaping.Add('5', "jkl");
            maaping.Add('6', "mno");
            maaping.Add('7', "pqrs");
            maaping.Add('8', "tuv");
            maaping.Add('9', "wxyz");

            var result = new List<string>();
            AddCombinations(digits, 0, string.Empty, result);
            return result;

        }

        void AddCombinations(string digits, int index, string path, List<string> result)
        {
            if (path.Length == digits.Length)
            {
                result.Add(path);
                return;
            }

            char digit = digits[index];
            string letters = this.maaping[digit];

            foreach (char letter in letters)
            {
                this.AddCombinations(digits, index + 1, path + letter, result);
            }
        }
    }
}
