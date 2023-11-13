namespace InterviewCodingStudies;

/**
 *- #223. Rectangle Area
 * - https://leetcode.com/problems/rectangle-area/
 */

public class RectangleArea
{
    //the total area covered by the two rectangles.
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
    {
        var xOverlap = GetRectOverLap(ax2, bx2, ax1, bx1);
        var yOverlap = GetRectOverLap(ay2, by2, ay1, by1);

        return (GetArea(ax1, ay1, ax2, ay2) +
                GetArea(bx1, by1, bx2, by2)) - (xOverlap * yOverlap);
    }
    
    // Get the smallest right hand width || height
    // Get the highest left hand width || height
    // To determine the overlap value
    private int GetRectOverLap(int minCoordOne, int minCoordTwo, int maxCoordOne, int maxCoordTwo)
    {
        var minValueTwo = Math.Min(minCoordOne, minCoordTwo);
        var maxValueOne = Math.Max(maxCoordOne, maxCoordTwo);
        return Math.Max(minValueTwo - maxValueOne, 0);
    }
    
    private int GetArea(int x1, int y1, int x2, int y2)
        => (x2 - x1) * (y2 - y1);
}