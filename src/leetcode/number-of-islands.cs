using System.Collections;

namespace Task;
public class NumberOfIslands
{
    public static int NumIslands(char[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int islands = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == '1')
                {
                    islands++;
                    FindNext(grid, i, j);
                }
            }
        }
        Console.WriteLine(islands);
        return islands;
    }

    private static void FindNext(char[][] grid, int i, int j)
    {
        if (IsValid(grid, i, j))
        {
            grid[i][j] = '0';
            FindNext(grid, i - 1, j);
            FindNext(grid, i + 1, j);
            FindNext(grid, i, j - 1);
            FindNext(grid, i, j + 1);

        }
    }
    private static bool IsValid(char[][] grid, int i, int j)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        if (i < 0 || j < 0 || i >= m || j >= n || grid[i][j] == '0')
        {
            return false;
        }
        return true;
    }
}