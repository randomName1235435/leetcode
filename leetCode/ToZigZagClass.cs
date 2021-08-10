using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class ToZigZagClass
    {
        public string ToZigZag(string param, int rowsCount)
        {
            /*
                 a   e   i   m
                 b d f h j l n
                 c   g   k

                 PAYPALISHIRING
                 PAHNAPLSIIGYIR            

                 ABCDEFGHIHKLMN
                 AEIMBDFHJLNCGK
                 char    sourcePos   targetpos       diff    row
                 a           0           0           +0       1
                 b           1           4           +3       2
                 c           2           11          +9       3
                 d           3           5           +2       2
                 e           4           1           -3       1
                 f           5           6           +1       2
                 g           6           12          +6       3
                 h           7           7           +0       2
                 i           8           2           -6       1
                 j           9           8           -1       2
                 k           10          13          +3       3
                 l           11          9           -2       2
                 m           12          3           -9       1
                 n           13          10          -3       2
                 */

            if (rowsCount == 1) return param;

            List<string> rows = new List<string>();
            for (int i = 0; i < rowsCount; i++)
                rows.Add("");

            int currentRow = 0;
            bool goingDown = false;

            foreach (var currentChar in param)
            {
                rows[currentRow] += currentChar;
                if (currentRow == 0 || currentRow == rowsCount - 1) goingDown = !goingDown;
                currentRow += goingDown ? 1 : -1;
            }

            return string.Concat( rows);

        }
    }
}
