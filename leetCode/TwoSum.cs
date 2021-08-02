using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class TwoSum
    {
        public int[] TwoSumm(int[] nums, int target)
        {
            var needed = new int[nums.Length];
            var ret = new int[2];
            int currentNeeded = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                var current = nums[i];
                currentNeeded = target - nums[i];
                if (nums.Contains(currentNeeded))
                {
                    return new int[2] { i, Array.IndexOf(nums , currentNeeded,i+1) };
                }
            }
            return null;
        }
    }
}

