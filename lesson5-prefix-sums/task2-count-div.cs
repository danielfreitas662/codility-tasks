namespace Tasks;

public static class CountDiv
{
  public static int Solution(int A, int B, int K)
  {
    int upToB = B / K;

    int lessThanA = (A - 1) / K;

    return upToB - lessThanA;
  }
}