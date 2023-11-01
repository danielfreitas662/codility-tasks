namespace Tasks;

public static class MaxCounters
{
  public static int[] Solution(int N, int[] A)
  {
    var counters = new int[N];
    var globalMax = 0;
    var localMax = 0;

    for (var i = 0; i < A.Length; i++)
    {
      if (A[i] >= 1 && A[i] <= N)
      {
        if (counters[A[i] - 1] < globalMax)
        {
          counters[A[i] - 1] = globalMax;
        }
        counters[A[i] - 1]++;
        localMax = Math.Max(localMax, counters[A[i] - 1]);
      }
      if (A[i] == N + 1)
      {
        globalMax = localMax;
      }
    }
    for (var i = 0; i < N; i++)
    {
      if (counters[i] < globalMax)
      {
        counters[i] = globalMax;
      }
    }
    return counters;
  }
}

/*
3,4,4,6,1,4,4,6,2,1

0,0,1,0,0
0,0,1,1,0
0,0,1,2,0
--set max 2--
1,0,1,2,0
1,0,1,3,0
1,0,1,4,0
--set max 4--
1,1,1,4,0
2,1,1,4,0

0,0,1,0,0
0,0,1,1,0
0,0,1,2,0
2,2,2,2,2 - max 2
3,2,2,2,2
3,2,2,3,2
3,2,2,4,2
4,4,4,4,4 - max 4
4,5,4,4,4
5,5,4,4,4

0,0,1,0,0
0,0,1,1,0
0,0,1,2,0
max 2
3,0,1,2,0
3,0,1,3,0
3,0,1,4,0
max 4
3,5,1,4,0
5,5,1,4,0

x < max -> max
x >= max -> x

*/