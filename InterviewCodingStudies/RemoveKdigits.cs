using System.Text;

namespace InterviewCodingStudies;

/**
 * 402. Remove K Digits 
 * https://leetcode.com/problems/remove-k-digits/
 */

public class RemoveKdigits
{
    public string RemoveDigits(string num, int digitsToRemove)
    {
        if (num.Length == digitsToRemove)
        {
            return 0.ToString();
        }

        var sb = new StringBuilder();

        foreach (char c in num)
        {
            // if we have digits to remove, something in our string builder and 
            // the last char of the SB is greater than our current char, 
            // remove the sb char and add the current char to sb
            while (digitsToRemove > 0 && sb.Length > 0 && sb[sb.Length - 1] > c)
            {
                sb.Length--;
                digitsToRemove--;
            }
            sb.Append(c);
        }
        
        sb.Length -= digitsToRemove;
        string result = sb.ToString().TrimStart('0');
        return result.Length == 0 ? "0" : result;
    }
}