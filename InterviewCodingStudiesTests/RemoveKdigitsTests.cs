using InterviewCodingStudies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCodingStudiesTests;

[TestClass]
public class RemoveKdigitsTests
{
    [DataTestMethod]
    [DataRow("1432219", 3, "1219")]
    [DataRow("10200", 1, "200")]
    [DataRow("10", 2, "0")]
    public void UnitTestMethod1(string num, int digitsToRemove, string expectedResult)
    {
        var solution = new RemoveKdigits();
        var result = solution.RemoveDigits(num, digitsToRemove);
        Assert.AreEqual(expectedResult, result);
    }
}