
namespace Tasks;

public static class SortingArray
{
  public static void Sort(int[] array)
  {
    var N = array.Length;
    QuickSort(array, 0, N - 1);
  }

  private static void QuickSort(int[] array, int low, int high)
  {
    if (low < high)
    {
      var pivot = Partition(array, low, high);
      QuickSort(array, low, pivot - 1);
      QuickSort(array, pivot + 1, high);
    }
  }
  private static int Partition(int[] array, int low, int high)
  {
    var i = low - 1;

    for (int j = low; j < high; j++)
    {
      if (array[j] < array[high])
      {
        i++;
        Swap(array, i, j);
      }
    }

    Swap(array, i + 1, high);
    return i + 1;
  }
  private static void Swap(int[] array, int i, int j)
  {
    (array[j], array[i]) = (array[i], array[j]);
  }
  public static void PrintArray(int[] array)
  {
    var result = "";
    foreach (var n in array)
    {
      result += $"{n} ";
    }
  }
}