using System;

public class ThreeSumClosestClass
{
    public int ThreeSumClosest(int[] numbers, int target)
    {
        int firstTry = numbers[0] + numbers[1] + numbers[2];

        Array.Sort(numbers);

        for (int i = 0; i + 2 < numbers.Length; ++i)
        {
            if (i > 0 && numbers[i] == numbers[i - 1])
                continue;
            int l = i + 1;
            int r = numbers.Length - 1;
            while (l < r)
            {
                int sum = numbers[i] + numbers[l] + numbers[r];
                if (sum == target)
                    return sum;
                if (Math.Abs(sum - target) < Math.Abs(firstTry - target))
                    firstTry = sum;
                if (sum < target)
                    ++l;
                else
                    --r;
            }
        }

        return firstTry;
    }
}
