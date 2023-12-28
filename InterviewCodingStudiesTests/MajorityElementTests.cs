using InterviewCodingStudies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCodingStudiesTests;

[TestClass]
public class MajorityElementTests
{
    [DataTestMethod]
    [DataRow(new int[] { 3,1,4,1 }, "1")]
    [DataRow(new int[] { 33,44,55,66,77 }, "Majority odds")]
    [DataRow(new int[] { 1,2,3,4 }, "No majority")]
    [DataRow(new int[] { 1,2,66,44,3 }, "Majority evens")]
    public void UnitTestMethod1(int[] items, string expectedResult)
    {
        var solution = new MajorityElement();
        var result = solution.GetMajority(items);
        Assert.AreEqual(expectedResult, result);
    }
}