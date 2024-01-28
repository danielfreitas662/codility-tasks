namespace Tasks;

public static class FindMaxFishChallenge
{
    public static int FindMaxFish(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int maxFish = 0;
        bool[,] visited = new bool[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] > 0)
                    maxFish = Math.Max(maxFish, DFS(grid, visited, i, j));
            }
        }
        Console.WriteLine(maxFish);
        return maxFish;
    }

    private static int DFS(int[][] grid, bool[,] visited, int r, int c)
    {
        if (!IsValid(grid, visited, r, c))
        {
            return 0;
        }
        visited[r, c] = true;
        int fishCount = grid[r][c];

        //Explore adjacent cells
        fishCount += DFS(grid, visited, r - 1, c);
        fishCount += DFS(grid, visited, r + 1, c);
        fishCount += DFS(grid, visited, r, c - 1);
        fishCount += DFS(grid, visited, r, c + 1);
        return fishCount;
    }

    private static bool IsValid(int[][] grid, bool[,] visited, int r, int c)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        if (r < 0 || c < 0 || r >= m || c >= n || visited[r, c] || grid[r][c] == 0)
        {
            return false;
        }
        return true;
    }
}