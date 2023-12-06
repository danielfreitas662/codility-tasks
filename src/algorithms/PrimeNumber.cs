namespace Tasks;


public static class PrimeNumber
{
  public static int CountDivisors(int n)
  {
    var i = 1;
    var result = 0;
    while (i * i < n)
    {
      if (n % i == 0)
      {
        result += 2;
      }
      i++;
    }
    if (i * i == n)
    {
      result++;
    }
    return result;
  }

  public static bool Primality(int n)
  {
    var i = 2;
    while (i * i <= n)
    {
      if (n % i == 0)
      {
        return false;
      }
      i++;
    }
    return true;
  }
}