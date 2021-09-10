using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class LongestCommonPrefixClass
    {
        public string LongestCommonPrefix(string[] input)
        {
            if (input == null || input.Length == 0) return "";

            string shortestItem = input.First();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length < shortestItem.Length)
                    shortestItem = input[i];
            }
            if (shortestItem.Length == 0) return "";
            int j = 1;
            do
            {
                var currentprefix = shortestItem.Substring(0, j);
                if (input.Any(x => x.Substring(0, j) != currentprefix))
                {
                    return shortestItem.Substring(0, --j);
                }
                j++;
            } while (j <= shortestItem.Length);
            return shortestItem;
        }
    }
}
