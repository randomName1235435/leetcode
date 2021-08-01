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
            var ret = new int[2];
            for (int i = 0; i < nums.Count(); i++)
            {
                var current = nums[i];
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    var next = nums[j];
                    if (current + next == target)
                    {
                        ret[0] = i;
                        ret[1] = j;
                        return ret;
                    }
                }
            }
            return null;
        }
    }
}

