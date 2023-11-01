namespace Tasks;
public static class ArrayRotation
{
  public static int[] Solution(int[] A, int K)
  {
    if (A.Length == K) return A;
    var rotatedArray = A;
    var rotations = K < A.Length ? K : K % A.Length;
    for (var i = 1; i <= rotations; i++)
    {
      rotatedArray = Rotate(rotatedArray);
    }
    return rotatedArray;
  }
  public static int[] Rotate(int[] A)
  {
    var rotatedArray = new int[A.Length];
    rotatedArray[0] = A[A.Length - 1];
    for (var i = A.Length - 1; i > 0; i--)
    {
      rotatedArray[i] = A[i - 1];
    }
    return rotatedArray;
  }
}