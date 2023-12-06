namespace Tasks;

public static class FrogRiverOne
{
  public static int Solution(int X, int[] A)
  {
    var expectedSum = X * (X + 1) / 2;
    var fallenLeaves = new Dictionary<int, int>();
    var sum = 0;
    var result = -1;
    for (var i = 0; i < A.Length; i++)
    {
      if (!fallenLeaves.ContainsKey(A[i]))
      {
        fallenLeaves[A[i]] = A[i];
        sum += A[i];
        if (sum == expectedSum)
        {
          result = i;
        }
      }
    }
    return result;
  }
}