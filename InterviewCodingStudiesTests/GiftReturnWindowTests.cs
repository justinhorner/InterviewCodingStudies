using InterviewCodingStudies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCodingStudiesTests;

[TestClass]
public class GiftReturnWindowTests
{
    [DataTestMethod]
    [DataRow("Dec 25, 2023", "Mar 23, 2024")]
    [DataRow("Jan 4, 2024", "Feb 2, 2024")]
    [DataRow("Dec 4, 2024", "Mar 3, 2025")]
    public void GiftReturnWindowTest(string input, string expectedResult)
    {
        var solution = new GiftReturnWindow();
        var result = solution.GetGiftReturnWindow(input);
        Assert.AreEqual(expectedResult, result);
    }
}