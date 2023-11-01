namespace Tasks;

public static class MissingInteger
{
  public static int Solution(int[] A)
  {
    if (A.Length == 1 && A[0] > 1) return 1;
    var requiredLength = 0;

    for (var i = 0; i < A.Length; i++)
    {
      requiredLength = Math.Max(A[i], requiredLength);
    }

    var positiveNumbers = new bool[requiredLength + 1];

    for (var i = 0; i < A.Length; i++)
    {
      if (A[i] > 0)
      {
        positiveNumbers[A[i]] = true;
      }
    }

    for (var i = 1; i < positiveNumbers.Length; i++)
    {
      if (!positiveNumbers[i]) return i;
    }

    return positiveNumbers.Length;
  }
}
