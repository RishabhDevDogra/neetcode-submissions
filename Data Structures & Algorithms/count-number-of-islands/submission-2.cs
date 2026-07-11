public class Solution {
    int [][]dirs = 
        {
            new []{1,0},
            new []{-1,0},
            new []{0,-1},
            new []{0,1}
        };

    public int NumIslands(char[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int islands = 0;

        
        for(int r = 0;r<rows;r++)
        {
            for(int c = 0;c<cols;c++)
            {
                if(grid[r][c]=='1'){
                    islands++;
                    Dfs(grid,r,c);
                }
            }
        }

        return islands;
    }
    void Dfs(char[][]grid,int r ,int c)
    {
        
        if(r<0 || c < 0 || r >= grid.Length || c >= grid[0].Length ||
            grid[r][c] == '0')
            {
                return;
            }

        //mark water 
        grid[r][c] = '0';
         // Visit all 4 directions
        Dfs(grid, r - 1, c); // Up
        Dfs(grid, r + 1, c); // Down
        Dfs(grid, r, c - 1); // Left
        Dfs(grid, r, c + 1); // Right
    }
    void Bfs(char[][]grid, int r , int c)
    {
        Queue<int[]> q = new();
        //mark water 
        grid[r][c] = '0';
        q.Enqueue(new int[]{r,c});
        while(q.Count>0)
        {
            var node = q.Dequeue();
            int row = node[0], col = node[1];
            foreach(var dir in dirs)
            {
                int nr = row + dir[0], nc = col + dir[1];

                if(nr>=0 &&  nc >= 0 &&
                    nr < grid.Length && nc < grid[0].Length &&
                    grid[nr][nc] == '1'
                )
                { 
                    q.Enqueue(new int[] { nr, nc });
                    grid[nr][nc] = '0';
                }
            }
        }
    }

    
}