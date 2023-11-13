using System;
using System.Linq;
using System.Text;

namespace InterviewCodingStudies;

/**
 * - #10. Regular Expression Matching
 * - https://leetcode.com/problems/regular-expression-matching/ 
 */

public class RegularExpressionMatching
{
    /// <summary>
    /// Determines if the provided string matches the provided pattern
    /// </summary>
    /// <param name="s">the string to match against, e.g. 'aa'</param>
    /// <param name="p">the pattern to match against, e.g. 'a*'</param>
    /// <returns></returns>
    public bool IsMatch(string s, string p)
    {
        //return IsMatchRecursion(s, p);
        return IsMatchDynamicProgramming(s, p);
    }

    private bool IsMatchRecursion(string s, string p)
    {
        if (p.Length == 0)
        {
            return s.Length == 0;
        }

        var originalMatch = ((s.Length > 0) && (p[0] == s[0] || p[0] == '.'));

        if (p.Length >= 2 && p[1] == '*')
        {
            return (IsMatchRecursion(s, p.Substring(2)) ||
                    (originalMatch && IsMatchRecursion(s.Substring(1), p)));
        }
        else
        {
            return originalMatch && IsMatchRecursion(s.Substring(1), p.Substring(1));
        }
    }

    private bool IsMatchDynamicProgramming(string s, string p)
    {
        var rows = s.Length;
        var columns = p.Length;
        
        var twoDimensionalArray = new bool[rows + 1, columns + 1];

        PrintTwoDimensionalArray(twoDimensionalArray);

        twoDimensionalArray[0,0] = true;

        for (int i = 2; i <= columns; i++)
        {
            if (p[i - 1] == '*')
            {
                // if we have an asterisk, look at the preceding char
                twoDimensionalArray[0,i] = twoDimensionalArray[0,i - 2];
            }
        }
        
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                // compare against the string or look for magic char in the pattern
                if ((s[i - 1] == p[j - 1]) || (p[j - 1] == '.'))
                {
                    twoDimensionalArray[i,j] = twoDimensionalArray[i - 1,j - 1];
                }
                else if (j > 1 && p[j - 1] == '*')
                {
                    twoDimensionalArray[i,j] = twoDimensionalArray[i,j - 2];
                    if ((p[j - 2] == '.') || (p[j - 2] == s[i - 1]))
                    {
                        twoDimensionalArray[i,j] = twoDimensionalArray[i,j] || twoDimensionalArray[i - 1,j];
                    }
                }
            }
        }

        PrintTwoDimensionalArray(twoDimensionalArray);
        return twoDimensionalArray[rows,columns];
    }

    private void PrintTwoDimensionalArray(bool[,] arr)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            var t = string.Join(",", GetRow(arr, i));
            sb.Append(t);
            Console.WriteLine(t);
        }

        // set it to a var so we can view in the debugger (while unit testing)
        var output = sb.ToString();
    }

    private bool[] GetRow(bool[,] arr, int rowNumber)
    {
        return Enumerable.Range(0, arr.GetLength(0))
            .Select(i => arr[rowNumber, 0])
            .ToArray();
    }
}