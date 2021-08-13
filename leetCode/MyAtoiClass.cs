using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class MyAtoiClass
    {
        public int MyAtoi(string param)
        {
            param = param.Trim();
            if (param == null || param.Length == 0) return 0;
            var result = 0;
            char first = param[0];
            bool isPositiv = true;
            int startIndex = 0;
            if (first == '+')
            {
                isPositiv = true;
                startIndex = 1;
            }
            else
            {
                if (first == '-')
                {
                    isPositiv = false;
                    startIndex = 1;
                }
            }

            for (int i = startIndex; i < param.Length; i++)
            {

                int current = param[i] - 48;
                if (current < 0 || current > 9) break;
                if (result > int.MaxValue / 10 || int.MaxValue - current < result * 10)
                {
                    return isPositiv ? int.MaxValue : int.MinValue;
                }
                result *= 10;
                result += current;
            }

            if (!isPositiv)
                result *= -1;

            return result;
        }
    }
}
