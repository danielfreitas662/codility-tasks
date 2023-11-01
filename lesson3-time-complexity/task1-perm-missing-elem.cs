namespace Tasks;

public static class PermMissingElement
{
  public static int Solution(int[] A)
  {
    int n = A.Length;
    long expectedSum = (long)(n + 1) * (n + 2) / 2;
    long actualSum = 0;

    for (int i = 0; i < n; i++)
    {
      actualSum += A[i];
    }

    return (int)(expectedSum - actualSum);
  }
}