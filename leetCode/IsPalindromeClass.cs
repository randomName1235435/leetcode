using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class IsPalindromeClass
    {
        public bool IsPalindrome(int param)
        {
            if (param < 0) return false;
            var length = (int)Math.Floor(Math.Log10(param)) + 1;

            for (int i = 0; i < length / 2; i++)
            {
                int left = (int)(param / Math.Pow(10, length - 1 - i) % 10);
                var right = (int)(param / Math.Pow(10, i ) % Math.Pow(10,  i+1) % 10);

                if (left != right)
                    return false;
            }
            return true;
        }
    }
}
