public class Solution {
    private int[][] dirs = {
        new []{-1,0},
         new []{1,0},
          new []{0,1},
           new []{0,-1}
    };
    public int MaxAreaOfIsland(int[][] grid) {
      int rows = grid.Length;
      int cols = grid[0].Length;
      int maxArea = 0;

      for(int r = 0; r < rows ; r++){
        for(int c = 0; c < cols; c ++)
        {
            if(grid[r][c]==1)
            {
                maxArea = Math.Max(maxArea,Dfs(grid,r,c));
            }
        }
      }
      return maxArea;

    }
    public int Dfs(int[][] grid, int r , int c)
    {
        int area = 1;
        if(r<0 || c < 0 || r >= grid.Length || c >= grid[0].Length
          || grid[r][c] == 0)
          return 0 ;
        //mark water 
        grid[r][c] = 0;

        foreach(var dir in dirs)
        {
            int nr = r + dir[0];
            int nc = c + dir[1];
            area += Dfs(grid,nr,nc);
        }
       
        return area;

    }
}
