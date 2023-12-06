using Tasks;


namespace test;

public class QuickSortTests
{
  [Fact]
  public void SortedArray()
  {
    var array = new int[] { 1, 2, 3, 4, 5 };
    var expected = new int[] { 1, 2, 3, 4, 5 };
    SortingArray.Sort(array);
    Assert.Equal(expected, array);
  }
  [Fact]
  public void UnsortedArray()
  {
    var array = new int[] { 5, 4, 3, 2, 1 };
    var expected = new int[] { 1, 2, 3, 4, 5 };
    SortingArray.Sort(array);
    Assert.Equal(expected, array);
  }
  [Fact]
  public void LargeUnsortedarray()
  {
    var array = new int[1000];
    for (int i = 0; i < 1000; i++)
    {
      array[i] = new Random().Next(0, 1000);
    }
    var expected = array.OrderBy(x => x).ToArray();
    SortingArray.Sort(array);
    Assert.Equal(expected, array);
  }
}