using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;

public class ThreeSumClass
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var distincted = new HashSet<Tuple<int, int, int>>();
        Array.Sort(nums);

        var max = nums.Max();
        var min = nums.Min();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            var cache = nums.Skip(i+1).GroupBy(item => item).ToDictionary(k => k.Key, v => v.Count());
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                cache[nums[j]]--;

                var needed = 0 - (nums[i] + nums[j]);
                if (needed > max || needed < min) continue;

                if (cache.ContainsKey(needed) && cache[needed] > 0)
                {
                    var key = new Tuple<int, int, int>(nums[i], nums[j], needed);
                    if (!distincted.Contains(key))
                    {
                        distincted.Add(key);
                    }
                }
            }
        }

        var ret = distincted.Select(item => ((IList<int>)(new List<int>(3) { item.Item1, item.Item2, item.Item3 }))).ToList();
        return ret;
    }
}
