using System.Collections.Generic;

namespace InterviewCodingStudies;

/**
 * 75. Sort Colors
 * https://leetcode.com/problems/sort-colors/description/
 */

public class SortColors
{
    public void DoSort(int[] nums)
    {
        var reds = new List<int>();
        var whites = new List<int>();
        var blues = new List<int>();
        
        foreach (var number in nums) {
            switch (number)  {
                case 0: 
                    reds.Add(number);
                    break;
                case 1: 
                    whites.Add(number);
                    break;
                case 2: 
                    blues.Add(number);
                    break;
            }
        }
        
        var sorted = new List<int>();
        
        sorted.AddRange(reds);
        sorted.AddRange(whites);
        sorted.AddRange(blues);
        
        sorted.CopyTo(nums);
    }
}