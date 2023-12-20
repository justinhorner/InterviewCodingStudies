using System.Collections.Generic;
using System.Linq;

namespace InterviewCodingStudies;

/**
 * 402. Remove K Digits 
 * https://leetcode.com/problems/remove-k-digits/
 */

public class RemoveKdigits
{
    public string RemoveDigits(string num, int k)
    {
        var digitsList = new List<int>();
        var length = num.Length;

        for (int i = 0; i < length; i++)
        {
            var tempList = num.ToCharArray().ToList();

            if ((i + k) > length)
            {
                break;
            }
            
            tempList.RemoveRange(i, k);

            if (tempList.Count == 0)
            {
                return 0.ToString();
            }
            
            var digits = int.Parse(new string(tempList.ToArray()));
            digitsList.Add(digits);
        }

        //var temp = digitsList.OrderDescending().First();
        var temp = digitsList.Order().First();
        return temp.ToString();
    }
}