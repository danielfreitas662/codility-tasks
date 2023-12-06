namespace Tasks;

public static class GenomicRangeQuery
{
  public static int[] Solution(string S, int[] P, int[] Q)
  {
    int N = S.Length;
    int M = P.Length;
    int[] result = new int[M];

    // Prefix sums for each nucleotide
    int[,] prefixSums = new int[4, N + 1];

    for (int i = 0; i < N; i++)
    {
      char nucleotide = S[i];
      // Increment the corresponding nucleotide count
      prefixSums[0, i + 1] = prefixSums[0, i] + (nucleotide == 'A' ? 1 : 0);
      prefixSums[1, i + 1] = prefixSums[1, i] + (nucleotide == 'C' ? 1 : 0);
      prefixSums[2, i + 1] = prefixSums[2, i] + (nucleotide == 'G' ? 1 : 0);
      prefixSums[3, i + 1] = prefixSums[3, i] + (nucleotide == 'T' ? 1 : 0);
    }
    Console.WriteLine(prefixSums[1, 1]);

    for (int k = 0; k < M; k++)
    {
      int start = P[k];
      int end = Q[k] + 1; // +1 because of how prefix sums are set up

      // Check for each nucleotide
      for (int j = 0; j < 4; j++)
      {
        if (prefixSums[j, end] - prefixSums[j, start] > 0)
        {
          result[k] = j + 1;
          break;
        }
      }
    }

    return result;
  }
}