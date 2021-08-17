using System;

namespace leetCode
{
    public class MaxAreaClass
    {
        public int MaxArea(int[] input)
        {
            int currentMax = 0;
            int leftIndex = 0;
            int rightIndex = input.Length - 1;
            int currentArea = 0;

            while (leftIndex < rightIndex)
            {
                int currentheight = Math.Min(input[leftIndex], input[rightIndex]);
                int currentWidth = rightIndex - leftIndex;
                currentArea = currentWidth * currentheight;
                if (currentArea > currentMax)
                    currentMax = currentArea;
                if (input[leftIndex] > input[rightIndex])
                    rightIndex--;
                else
                    leftIndex++;
            }
            return currentMax;
        }
    }
}
