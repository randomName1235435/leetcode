using System.Collections.Generic;

namespace leetCode
{
    public class RomanToIntClass
    {
        Dictionary<string, int> literals = new Dictionary<string, int>() {
        {"M" , 1000   },
        {"CM", 900    },
        {"D" , 500    },
        {"CD", 400    },
        {"C" , 100    },
        {"XC", 90     },
        {"L" , 50     },
        {"XL", 40     },
        {"X" , 10     },
        {"IX", 9      },
        {"V" , 5      },
        {"IV", 4      },
        {"I" , 1      },
        };
        public int RomanToInt(string input)
        {
            int output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i + 1 != input.Length && literals.ContainsKey(input.Substring(i, 2)))
                {
                    output += literals[input.Substring(i, 2)];
                    i++;
                }
                else
                    output += literals[input[i].ToString()];
            }
            return output;
        }
    }
}
