using Tasks;

namespace test;
public class PrimeNumberTests
{
  [Fact]
  public void Test1()
  {
    var expected = 2;
    var actual = PrimeNumber.CountDivisors(2);
    Assert.Equal(expected, actual);
  }
  [Fact]
  public void Test2()
  {
    var expected = 3;
    var actual = PrimeNumber.CountDivisors(4);
    Assert.Equal(expected, actual);
  }
  [Theory]
  [InlineData(2, true)]
  [InlineData(3, true)]
  [InlineData(4, false)]
  [InlineData(5, true)]
  [InlineData(6, false)]
  [InlineData(7, true)]
  [InlineData(8, false)]
  [InlineData(9, false)]
  [InlineData(10, false)]
  [InlineData(11, true)]
  [InlineData(12, false)]
  [InlineData(13, true)]
  [InlineData(14, false)]
  [InlineData(15, false)]
  public void Test3(int n, bool expected)
  {
    var actual = PrimeNumber.Primality(n);
    Assert.Equal(expected, actual);
  }
}