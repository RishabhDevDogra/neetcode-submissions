public class Solution {
    public int NumIslands(char[][] grid) {

        int rows = grid.Length;
        int cols = grid[0].Length;

        int islands = 0;

        int[][] dirs = new int[][]
        {
            new int[]{1,0},
            new int[]{-1,0},
            new int[]{0,1},
            new int[]{0,-1}
        };

        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(grid[r][c] == '1')
                {
                    islands++;

                    Queue<(int, int)> queue = new Queue<(int, int)>();

                    queue.Enqueue((r, c));

                    // mark visited
                    grid[r][c] = '0';

                    while(queue.Count > 0)
                    {
                        var (row, col) = queue.Dequeue();

                        foreach(var dir in dirs)
                        {
                            int nr = row + dir[0];
                            int nc = col + dir[1];

                            if(nr >= 0 && nr < rows &&
                               nc >= 0 && nc < cols &&
                               grid[nr][nc] == '1')
                            {
                                grid[nr][nc] = '0';

                                queue.Enqueue((nr, nc));
                            }
                        }
                    }
                }
            }
        }

        return islands;
    }
}