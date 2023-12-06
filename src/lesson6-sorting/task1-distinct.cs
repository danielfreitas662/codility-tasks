namespace Tasks;

public static class Distinct
{
  public static int Solution(int[] A)
  {
    var count = new Dictionary<int, int>();
    for (int i = 0; i < A.Length; i++)
    {
      count[A[i]] = count.ContainsKey(A[i]) ? A[i]++ : 1;
    }
    return count.Count;
  }
}