namespace Tasks;

public static class MaxProductOfThree
{
  public static int Solution(int[] A)
  {
    Array.Sort(A);
    return Math.Max(A[0] * A[1] * A[^1], A[^3] * A[^2] * A[^1]);
  }
}