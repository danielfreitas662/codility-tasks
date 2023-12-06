namespace Tasks;

public static class PermCheck
{
  public static int Solution(int[] A)
  {
    long N = A.Length;
    long expectedSum = N * (N + 1) / 2;
    long actualSum = 0;
    var uniqueValues = new HashSet<int>();

    foreach (int value in A)
    {
      if (value > N)
      {
        return 0;
      }
      uniqueValues.Add(value);
      actualSum += value;
    }
    if (actualSum == expectedSum && uniqueValues.Count == N)
    {
      return 1;
    }
    else
    {
      return 0;
    }
  }
}