namespace Tasks;

public static class OddCcurencesInArray
{
  public static int Solution(int[] A)
  {
    var collection = new Dictionary<int, int>();
    for (var i = 0; i < A.Length; i++)
    {
      if (!collection.ContainsKey(A[i]))
      {
        collection[A[i]] = 1;
      }
      else
      {
        collection[A[i]]++;
      }
    }
    var result = -1;
    foreach (var v in collection)
    {
      if (v.Value % 2 > 0)
      {
        result = v.Key;
        break;
      }
    }
    return result;
  }
}