using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class FindMedianSortedArraysClass
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var sorted = new List<int>(nums1);
            sorted.AddRange(nums2);
            sorted.Sort();
            if (sorted.Count() % 2 == 1) return sorted[(sorted.Count() / 2)];
            else
            {
                var first = sorted[(sorted.Count() - 1) / 2];
                var second = sorted[(sorted.Count()) / 2];
                float result = (first + second) / 2f;
                return result;
            }
        }
    }
}
