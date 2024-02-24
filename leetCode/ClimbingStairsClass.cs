using System.Collections.Generic;

namespace leetCode
{
    public class ClimbingStairsClass
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2)
                return n;

            var distinctWaysToEachStair = new int[n + 1];
            distinctWaysToEachStair[1] = 1;
            distinctWaysToEachStair[2] = 2;

            for (var i = 3; i <= n; i++)
            {
                distinctWaysToEachStair[i] = distinctWaysToEachStair[i - 1] + distinctWaysToEachStair[i - 2];
            }

            return distinctWaysToEachStair[n];
        }
    }
}