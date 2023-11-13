using InterviewCodingStudies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCodingStudiesTests;

[TestClass]
public class MedianOfTwoSortedArraysTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var solution = new MedianOfTwoSortedArrays();
        var result = solution.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
        Assert.AreEqual(2, result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        var solution = new MedianOfTwoSortedArrays();
        var result = solution.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 });
        Assert.AreEqual(2.5, result);
    }
}