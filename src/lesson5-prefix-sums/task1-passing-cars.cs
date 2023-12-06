namespace Tasks;

public static class PassingCars
{
  public static int Solution(int[] A)
  {
    var zeros = 0;
    var passingCars = 0;
    for (var i = 0; i < A.Length; i++)
    {
      if (A[i] == 0)
      {
        zeros++;
      }
      else
      {
        passingCars += zeros;
      }
      if (passingCars > 1000000000) return -1;
    }
    return passingCars;
  }
}