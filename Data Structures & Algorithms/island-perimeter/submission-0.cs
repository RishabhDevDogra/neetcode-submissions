public class Solution
{
    public int IslandPerimeter(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == 1)
                {
                    return Dfs(grid, r, c);
                }
            }
        }

        return 0;
    }

    private int Dfs(int[][] grid, int r, int c)
    {
        // Out of bounds contributes to perimeter
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length)
            return 1;

        // Water contributes to perimeter
        if (grid[r][c] == 0)
            return 1;

        // Already visited contributes nothing
        if (grid[r][c] == -1)
            return 0;

        // Mark as visited
        grid[r][c] = -1;

        return Dfs(grid, r + 1, c) +
               Dfs(grid, r - 1, c) +
               Dfs(grid, r, c + 1) +
               Dfs(grid, r, c - 1);
    }
}