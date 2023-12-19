using InterviewCodingStudies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCodingStudiesTests;

[TestClass]
public class SortColorsTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var solution = new SortColors();
        var testValue = new[] { 2, 0, 2, 1, 1, 0 };
        solution.DoSort(testValue);
        var expected = new int[] { 0, 0, 1, 1, 2, 2 };
        CollectionAssert.AreEqual(expected, testValue);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        var solution = new SortColors();
        var testValue = new[] { 2, 0, 1 };
        solution.DoSort(testValue);
        var expected = new int[] { 0, 1, 2 };
        CollectionAssert.AreEqual(expected, testValue);
    }
}