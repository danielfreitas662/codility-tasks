namespace Tasks;

public class FindMaxFishChallengeRecursion
{
    public int FindMaxFish(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int maxFish = 0;
        bool[,] visited = new bool[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                maxFish = Math.Max(maxFish, DFS(grid, visited, i, j));
            }
        }
        Console.WriteLine(maxFish);
        return maxFish;
    }

    private int DFS(int[][] grid, bool[,] visited, int r, int c)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        if (r < 0 || c < 0 || r >= m || c >= n || visited[r, c] || grid[r][c] == 0)
        {
            return 0;
        }

        visited[r, c] = true;
        int fishes = grid[r][c];

        fishes += DFS(grid, visited, r - 1, c);
        fishes += DFS(grid, visited, r + 1, c);
        fishes += DFS(grid, visited, r, c - 1);
        fishes += DFS(grid, visited, r, c + 1);
        return fishes;
    }
}