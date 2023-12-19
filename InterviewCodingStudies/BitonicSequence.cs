using System;

namespace InterviewCodingStudies;

/**
 * 'Write a function that determines if an array of numbers is a bitonic sequence.'
 *  A bitonic sequence is a sequence of numbers in which the numbers are in increasing
 * order, and after a certain point, they start decreasing. Extra credit: print the
 * peak number in the sequence!
 * 
 * https://buttondown.email/cassidoo/archive/everything-has-beauty-but-not-everyone-sees-it/
 */

public class BitonicSequence
{
    public int GetPeakValueIndex(int[] values, int index, int maxValue = 0)
    {
        var maxValueIndex = 0;
        for (var i = index; i < values.Length; i++)
        {
            if (values[i] > maxValue)
            {
                maxValue = values[i];
                maxValueIndex = i;
            }
        }

        return maxValueIndex;
    }
    
    public bool IsBitonicSequence(int[] values)
    {
        int? peak;
        var firstPeakIndex = GetPeakValueIndex(values, 0);
        var nextPeakIndex = GetPeakValueIndex(values[(firstPeakIndex + 1)..], (firstPeakIndex + 1), values[firstPeakIndex]);

        var hasNoDescent = firstPeakIndex == (values.Length - 1);
        var hasSinglePeak = !hasNoDescent && ((firstPeakIndex != nextPeakIndex) && firstPeakIndex >= 1);
        
        peak = hasSinglePeak ? values[firstPeakIndex] : null;

        if (peak is not null)
        {
            Console.WriteLine(peak);
        }
        
        return peak is not null;
    }
}