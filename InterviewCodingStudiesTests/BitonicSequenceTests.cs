using System.Collections.Generic;
using InterviewCodingStudies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCodingStudiesTests;

[TestClass]
public class BitonicSequenceTests
{
    [DataTestMethod]
    [DataRow(new int[]{1,2,3,2}, true)]
    [DataRow(new int[]{1,2,3}, false)]
    [DataRow(new int[]{3,2,3}, false)]
    [DataRow(new int[]{3,2,1}, false)]
    [DataRow(new int[]{3,4,5,5,5,2,1}, true)]
    [DataRow(new int[]{6,7,8,9,3,2,1}, true)]
    public void UnitTestMethod1(int[] values, bool expectedResult)
    {
        var solution = new BitonicSequence();
        var result = solution.IsBitonicSequence(values);
        Assert.AreEqual(expectedResult, result);
    }
}