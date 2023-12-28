using System.Collections.Generic;
using System.Linq;

namespace InterviewCodingStudies;

/**
 * Given an array of integers, return the majority element. If there is no
 * majority element, return if the array is majority even or odd numbers,
 * and if there is none, say so.
 *
 * https://buttondown.email/cassidoo/archive/look-for-the-ridiculous-in-everything-and-you/
 * 
 * Example:
 * > majority([3,1,4,1])
 * > "1"
 * 
 * > majority([33,44,55,66,77])
 * > "Majority odds"
 *
 * > majority([1,2,3,4])
 * > "No majority"
 */
public class MajorityElement
{
    public string GetMajority(int[] items)
    {
        var grouped = items.GroupBy(x => x);

        if (grouped.Any(x => x.Count() > 1))
        {
            var majority = grouped.MaxBy(x => x.Count());
            return majority.Key.ToString();
        }
        else
        {
            var odds = new List<int>();
            var evens = new List<int>();

            foreach (var num in items)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            if (odds.Count == evens.Count)
            {
                return "No majority";
            }
            
            return odds.Count > evens.Count ? "Majority odds" : "Majority evens";
        }
    }
}