using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class LongestPalindromeClass
    {
        public string LongestPalindrome(string param) {
            string longestPalindrome = "";
            int k = 0;
            for (int i = 0; i < param.Length; i++)
            {
                if (longestPalindrome.Length > param.Substring(i).Length)
                    return longestPalindrome;
                k = 1;
                while (k+i <= param.Length)
                {
                    string currentPalindromeCandidate = param.Substring(i, k);
                    if (IsPalindrome(currentPalindromeCandidate))
                    {
                        string currentPalindrome = currentPalindromeCandidate;
                        if (currentPalindrome.Length > longestPalindrome.Length)
                        {
                            longestPalindrome = currentPalindrome;
                        }
                    }
                    k++;
                }
            }
            return longestPalindrome;
        }

        public bool IsPalindrome(string currentPalindromeCandidate)
        {
            for (int i = 0; i < currentPalindromeCandidate.Length/2; i++)
            {
                if (currentPalindromeCandidate[i] != currentPalindromeCandidate[currentPalindromeCandidate.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}

