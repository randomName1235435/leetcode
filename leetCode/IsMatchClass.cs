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
            if (pattern.Length == 0) return input.Length == 0;
            bool first_match = (input.Length != 0 && (pattern[0] == input[0] || pattern[0] == '.'));
            if (pattern.Length >= 2 && pattern[1] == '*')
                return (IsMatch(input, pattern.Substring(2)) || (first_match && IsMatch(input.Substring(1), pattern)));
            return first_match && IsMatch(input.Substring(1), pattern.Substring(1));
        }
    }
}
