using System.Collections.Generic;

namespace leetCode
{
    public class GenerateParenthesesClass
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            Stack<(string str, int open, int close)> stack = new Stack<(string, int, int)>();
            stack.Push(("", 0, 0));

            while (stack.Count > 0)
            {
                (string str, int open, int close) = stack.Pop();
                if (str.Length == n * 2)
                {
                    result.Add(str);
                }
                else
                {
                    if (open < n)
                    {
                        stack.Push((str + "(", open + 1, close));
                    }
                    if (close < open)
                    {
                        stack.Push((str + ")", open, close + 1));
                    }
                }
            }

            return result;
        }
    }
}