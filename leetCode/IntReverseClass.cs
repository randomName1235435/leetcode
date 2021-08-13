using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class IntReverseClass
    {
        public int Reverse(int param)
        {
            int ret = 0;
            while (param != 0)
            {
                int pop = param % 10;
                param /= 10;
                if (ret > int.MaxValue / 10 || (ret == int.MaxValue / 10 && pop > 7)) return 0;
                if (ret < int.MinValue / 10 || (ret == int.MinValue / 10 && pop < -8)) return 0;
                ret = ret * 10 + pop;
            }
            return ret;
        }
    }
}
