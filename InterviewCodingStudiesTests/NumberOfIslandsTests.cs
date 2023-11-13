using InterviewCodingStudies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewCodingStudiesTests;

[TestClass]
public class NumberOfIslandsTests
{
    [TestMethod]
    public void Should_Find_One_Island()
    {
        var grid = new char[][] 
        {
            new char[] {'1','1','1','1','0'},
            new char[] {'1','1','0','1','0'},
            new char[] {'1','1','0','0','0'},
            new char[] {'0','0','0','0','0'} 
        };

        var findIslands = new NumberOfIslands();
        var result = findIslands.GetNumberOfIslands(grid);
        Assert.AreEqual(1, result);
    }
    
    [TestMethod]
    public void Should_Find_One_Mini_Island()
    {
        var grid = new char[][] 
        {
            new char[] {'1','1'},
            new char[] {'1','1'}, 
        };

        var findIslands = new NumberOfIslands();
        var result = findIslands.GetNumberOfIslands(grid);
        Assert.AreEqual(1, result);
    }
    
    [TestMethod]
    public void Should_Find_No_Island()
    {
        var grid = new char[][] 
        {
            new char[] {'0','0'},
            new char[] {'0','0'}, 
        };

        var findIslands = new NumberOfIslands();
        var result = findIslands.GetNumberOfIslands(grid);
        Assert.AreEqual(0, result);
    }
    
    [TestMethod]
    public void Should_Find_Three_Islands()
    {
        var grid = new char[][] 
        {
            new char[] {'1','1','0','0','0'},
            new char[] {'1','1','0','0','0'},
            new char[] {'0','0','1','0','0'},
            new char[] {'0','0','0','1','1'}
        };

        var findIslands = new NumberOfIslands();
        var result = findIslands.GetNumberOfIslands(grid);
        Assert.AreEqual(3, result);
    }
    
    
    [TestMethod]
    public void Should_Find_Eight_Islands()
    {
        var grid = new char[][] 
        {
            new char[] {'1','1','0','0','0','1'},
            new char[] {'1','1','0','1','0','0'},
            new char[] {'0','0','1','0','0','0'},
            new char[] {'1','0','0','1','1','0'},
            new char[] {'0','1','0','0','0','0'},
            new char[] {'0','1','0','1','1','0'}
        };

        var findIslands = new NumberOfIslands();
        var result = findIslands.GetNumberOfIslands(grid);
        Assert.AreEqual(8, result);
    }
}