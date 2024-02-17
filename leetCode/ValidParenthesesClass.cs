using System.Collections.Generic;


namespace leetCode
{
    public class ValidParenthesesClass
    {
        private Dictionary<char, char> closing = new Dictionary<char, char>()
        {
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };
        public bool IsValid(string s)
        {
            var openIndex = 0;

            var openParenthesis = new Stack<char>();
            while (openIndex != s.Length)
            {
                var currentChar = s[openIndex];
                if (currentChar == 91 || currentChar == 123 || currentChar == 40)
                {
                    openParenthesis.Push(currentChar);
                }
                else
                {
                    if (openParenthesis.Count == 0)
                        return false;
                    if (this.closing[openParenthesis.Peek()] == currentChar)
                        openParenthesis.Pop();
                    else return false;
                }
                openIndex++;
            }

            return openParenthesis.Count <= 0;
        }
    }
}