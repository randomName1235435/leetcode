using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class IsMatchClass
    {
        public bool IsMatch(string input, string pattern)
        {
            string currentRestPattern = pattern;
            int inputIndex = 0;
            
            while (currentRestPattern.Length != 0 || inputIndex < input.Length)
            {
                if (currentRestPattern.Length == 0 && inputIndex < input.Length) return false;
                if (currentRestPattern.Length > 1 && currentRestPattern[1] == '*')
                {
                    if (inputIndex >= input.Length)
                    {
                        currentRestPattern = currentRestPattern.Substring(2);
                        continue;
                    }
                    if (MatchWithAesterix(currentRestPattern.Substring(0, 2), input[inputIndex].ToString()))
                    {
                        inputIndex++;
                    }
                    else
                    {
                        currentRestPattern = currentRestPattern.Substring(2);
                    }
                }
                else
                {
                    currentRestPattern = currentRestPattern.Substring(1);
                    if (inputIndex >= input.Length)
                    {
                        return false;
                    }
                    if (DefaultMatch(currentRestPattern.Substring(0, 1), input[inputIndex].ToString()))
                        inputIndex++;
                    else return false;
                }
            }
            return true;
        }

        private bool DefaultMatch(string pattern, string input)
        {
            if (pattern[0] == '.') return input != null && input.Length > 0;
            return pattern == input;
        }

        private bool MatchWithAesterix(string pattern, string input)
        {
            if (pattern[0] == '.') return input != null && input.Length > 0;
            return pattern[0].ToString() == input;
        }
    }
}
