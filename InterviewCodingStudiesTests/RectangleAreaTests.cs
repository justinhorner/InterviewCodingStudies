using InterviewCodingStudies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCodingStudiesTests;

[TestClass]
public class RectangleAreaTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var solution = new RectangleArea();
        var result = solution.ComputeArea(-3, 0, 3, 4, 0, -1, 9, 2);
        Assert.AreEqual(45, result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        var solution = new RectangleArea();
        var result = solution.ComputeArea(-2, -2, 2, 2, -2, -2, 2, 2);
        Assert.AreEqual(16, result);
    }
}