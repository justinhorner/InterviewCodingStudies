using InterviewCodingStudies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCodingStudiesTests;

[TestClass]
public class RegularExpressionMatchingTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var solution = new RegularExpressionMatching();
        var result = solution.IsMatch("aa", "a");
        Assert.IsFalse(result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        var solution = new RegularExpressionMatching();
        var result = solution.IsMatch("aa", "a*");
        Assert.AreEqual(true, result);
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        var solution = new RegularExpressionMatching();
        var result = solution.IsMatch("ab", ".*");
        Assert.AreEqual(true, result);
    }
    
        
    [TestMethod]
    public void TestMethod4()
    {
        var solution = new RegularExpressionMatching();
        var result = solution.IsMatch("aab", "c*a*b");
        Assert.AreEqual(true, result);
    }
}