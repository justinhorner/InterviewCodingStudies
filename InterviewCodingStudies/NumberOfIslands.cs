namespace InterviewCodingStudies;

/**
 * - 200. Number of Islands
 * - https://leetcode.com/problems/number-of-islands/
 */
public class NumberOfIslands
{
    private int _numberOfRows;
    private int _numberOfColumns;
    
    public int GetNumberOfIslands(char[][] grid)
    {
        var totalNumberOfIslands = 0;
            
        _numberOfRows = grid.Length;
        _numberOfColumns = grid[0].Length;

        for (var r = 0; r < _numberOfRows; r++)
        {
            for (var c = 0; c < _numberOfColumns; c++)
            {
                if (grid[r][c] == '1')
                {
                    totalNumberOfIslands++;
                    FindLandCells(grid, r, c);
                }
            }
        }

        return totalNumberOfIslands;
    }

    /// <summary>
    /// Loops through each cell to determine if the cell is a land cell.
    /// If so, we change it to a water cell and recursively evaluate
    /// the surrounding (+- 1, horizontally and vertically) cells
    /// </summary>
    private void FindLandCells(char[][] grid, int row, int column)
    {
        if (IsALandCell(grid, row, column))
        {
            grid[row][column] = '0';
            FindLandCells(grid, (row + 1), column);
            FindLandCells(grid, (row - 1), column);
            FindLandCells(grid, row, (column + 1));
            FindLandCells(grid, row, (column - 1));
        }
    }

    private bool IsALandCell(char[][] grid, int row, int column)
        => (row >= 0 && row < _numberOfRows)
           && (column >= 0 && column < _numberOfColumns)
           && grid[row][column] == '1';
}