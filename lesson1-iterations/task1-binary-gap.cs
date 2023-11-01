
namespace Tasks;
public static class BinaryGap
{
  public static int Solution(int number)
  {
    var stringNumber = Convert.ToString(number, 2);
    if (stringNumber.Length <= 2) return 0;
    var gapStart = false;
    var localLength = 0;
    var maxLength = 0;
    for (var i = 1; i < stringNumber.Length; i++)
    {
      if (stringNumber[i] == '1' && stringNumber[i - 1] == '0' && gapStart)
      {
        maxLength = Math.Max(maxLength, localLength);
      }
      if (stringNumber[i] == '0' && stringNumber[i - 1] == '1')
      {
        gapStart = true;
        localLength = 0;
      }
      if (gapStart && stringNumber[i] == '0')
      {
        localLength++;
      }
    }
    return maxLength;
  }
}