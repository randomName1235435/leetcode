namespace leetCode
{
    public class MySqrtClass
    {
        public int MySqrt(int x)
        {
            int mid;
            var leftCandidate = 0;
            var rightCandidate = x / 2 + 1;

            while (leftCandidate + 1 < rightCandidate)
            {
                mid = leftCandidate + (rightCandidate - leftCandidate) / 2;
                if (mid == x / mid)
                {
                    return mid;
                }

                if (mid < x / mid)
                {
                    leftCandidate = mid;
                }
                else
                {
                    rightCandidate = mid;
                }
            }

            if (leftCandidate == x / leftCandidate)
            {
                return leftCandidate;
            }

            if (rightCandidate == x / rightCandidate)
            {
                return rightCandidate;
            }
            return leftCandidate;
        }
    }
}