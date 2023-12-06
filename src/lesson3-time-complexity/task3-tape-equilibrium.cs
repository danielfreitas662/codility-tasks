namespace Tasks;

public static class TapeEquilibrium
{
  public static int Solution(int[] A)
  {
    var currentSum = A[0];
    var minSum = int.MaxValue;
    var totalSum = 0;

    //Get total sum
    for (var i = 0; i < A.Length; i++)
    {
      totalSum += A[i];
    }

    for (var i = 1; i < A.Length; i++)
    {
      var rest = totalSum - currentSum;
      var sum = Math.Abs(currentSum - rest);
      if (sum < minSum)
      {
        minSum = sum;
      }
      currentSum += A[i];
    }
    return minSum;
  }
}