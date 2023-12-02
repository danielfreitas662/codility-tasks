namespace Tasks;

public static class Triangle
{
  public static int Solution(int[] A)
  {
    var N = A.Length;
    if (N < 3) return 0;
    Array.Sort(A);
    for (int i = 0; i < N - 2; i++)
    {
      var P = (long)A[i];
      var Q = A[i + 1];
      var R = A[i + 2];
      if (P + Q > R) return 1;
    }
    return 0;
  }
}