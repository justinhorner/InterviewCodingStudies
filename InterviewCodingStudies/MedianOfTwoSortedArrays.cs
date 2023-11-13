using System;
using System.Collections.Generic;

namespace InterviewCodingStudies;

/*
 * - #4. Median of Two Sorted Arrays
 * - https://leetcode.com/problems/median-of-two-sorted-arrays/
 */

public class MedianOfTwoSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var joinedArray = JoinArraysAndSortV2(nums1, nums2);

        var joinedLength = joinedArray.Length;

        //if it's odd, just grab the middle value
        if (joinedLength % 2 != 0)
        {
            var middleIndex = Math.Abs(joinedLength / 2);
            return joinedArray[middleIndex];
        }
        else
        {
            var middleRightIndex = Math.Abs(joinedLength / 2);
            var middleLeftIndex = middleRightIndex - 1;
            return ((double)joinedArray[middleLeftIndex] + (double)joinedArray[middleRightIndex]) / 2;
        }
    }

    private int[] JoinArraysAndSortV1(int[] nums1, int[] nums2)
    {
        var joinedArray = new List<int>();
        joinedArray.AddRange(nums1);
        joinedArray.AddRange(nums2);
        
        joinedArray.Sort();
        return joinedArray.ToArray();
    }

    private int[] JoinArraysAndSortV2(int[] nums1, int[] nums2)
    {
        var combined = new int[nums1.Length + nums2.Length];
        Array.Copy(nums1, combined, nums1.Length);
        Array.Copy(nums2, 0,combined, nums1.Length, nums2.Length);
        Array.Sort(combined);
        return combined;
    }
}