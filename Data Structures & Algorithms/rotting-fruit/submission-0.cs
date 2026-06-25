public class Solution {
    public int OrangesRotting(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        int fresh = 0;
        int minutes = 0;
        Queue<(int row, int col)> q = new Queue<(int, int)>();
        int [][] dirs = new int[][]
        {
            new int []{1,0},
            new int []{-1,0},
            new int []{0,-1},
            new int []{0,1}
        };
        for(int r =0; r<rows;r++)
        {
            for(int c =0; c<cols;c++)
            {
                if (grid[r][c] == 2)
                {
                    q.Enqueue((r, c));
                }
                else if (grid[r][c] == 1)
                {
                    fresh++;
                }
            }
        }
        while(q.Count > 0 && fresh > 0)
        {
            int size = q.Count;
            
            for(int i = 0; i < size; i++)
            {
                var (r,c) = q.Dequeue();
                foreach(var dir in dirs)
                {
                    int nr = r + dir[0], nc = c + dir[1];
                    if(nr >=0 && nc >= 0 &&
                        nr < grid.Length && nc < grid[0].Length &&
                        grid[nr][nc] == 1)
                    {
                        //Rot it
                        grid[nr][nc] = 2;
                        fresh --;
                        q.Enqueue((nr,nc));
                    }

                }
                
            }
            minutes ++;
        }

        return fresh == 0 ? minutes : -1;
    }
}
