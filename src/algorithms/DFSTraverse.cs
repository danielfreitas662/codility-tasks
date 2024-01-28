namespace Tasks;

public class DFS
{
    private bool[,] Visited;
    private readonly int[][] _grid;
    private readonly int _rows;
    private readonly int _cols;
    private Stack<Tuple<int, int>> st { get; set; }
    public DFS(int[][] grid)
    {
        _grid = grid;
        _rows = grid.Length;
        _cols = grid[0].Length;
    }
    public void Traverse()
    {
        Visited = new bool[_rows, _cols];
        for (int i = 0; i < _rows; i++)
        {
            for (int j = 0; j < _cols; j++)
            {
                Visited[i, j] = false;
            }
        }
        DFSExecute(0, 0);
        Console.WriteLine();
    }

    private void DFSExecute(int row, int col)
    {
        st = new Stack<Tuple<int, int>>();
        st.Push(new Tuple<int, int>(row, col));
        while (st.Count > 0)
        {
            var curr = st.Pop();
            row = curr.Item1;
            col = curr.Item2;

            if (!IsValid(row, col))
            {
                continue;
            }
            Visited[row, col] = true;
            Console.Write(_grid[row][col] + " ");
            st.Push(new Tuple<int, int>(row - 1, col));
            st.Push(new Tuple<int, int>(row, col - 1));
            st.Push(new Tuple<int, int>(row + 1, col));
            st.Push(new Tuple<int, int>(row, col + 1));
        }
    }


    private bool IsValid(int row, int col)
    {
        if (row < 0 || col < 0 || row >= _rows || col >= _cols)
        {
            return false;
        }
        if (Visited[row, col])
        {
            return false;
        }
        return true;
    }
}