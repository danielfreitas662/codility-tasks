
namespace Tasks;

public static class FindMaxFishChallengeStack
{
    public static int FindMaxFish(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        bool[,] visited = new bool[m, n];
        int fishes = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] != 0)
                {
                    fishes = Math.Max(fishes, DFS(grid, visited, i, j));
                }
            }
        }
        Console.WriteLine(fishes);
        return fishes;
    }

    private static int DFS(int[][] grid, bool[,] visited, int i, int j)
    {

        int m = grid.Length;
        int n = grid[0].Length;

        Stack<Tuple<int, int>> stack = new();
        stack.Push(new Tuple<int, int>(i, j));

        int fishes = 0;
        while (stack.Count > 0)
        {
            var curr = stack.Pop();
            var r = curr.Item1;
            var c = curr.Item2;

            if (r < 0 || r >= m || c < 0 || c >= n || visited[r, c] || grid[r][c] == 0)
            {
                continue;
            }
            visited[r, c] = true;
            fishes += grid[r][c];

            stack.Push(new Tuple<int, int>(r - 1, c));
            stack.Push(new Tuple<int, int>(r + 1, c));
            stack.Push(new Tuple<int, int>(r, c - 1));
            stack.Push(new Tuple<int, int>(r, c + 1));
        }
        return fishes;
    }
}