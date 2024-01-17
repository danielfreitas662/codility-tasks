using Tasks;

namespace test;

public class LongestSubstringWithoutRepeatingCharactersTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    public void Test1(string s, int expected)
    {
        var result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }

}