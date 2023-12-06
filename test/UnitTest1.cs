using Tasks;

namespace test;

public class UnitTest1
{
    [Theory]
    [InlineData("Codility We test coders", 1, "...")]
    [InlineData("Codility We test coders", 2, "...")]
    [InlineData("Codility We test coders", 3, "...")]
    [InlineData("Codility We test coders", 4, "...")]
    [InlineData("Codility We test coders", 5, "...")]
    [InlineData("Codility We test coders", 6, "...")]
    [InlineData("Codility We test coders", 7, "...")]
    [InlineData("Codility We test coders", 8, "...")]
    [InlineData("Codility We test coders", 9, "...")]
    [InlineData("Codility We test coders", 10, "...")]
    [InlineData("Codility We test coders", 11, "...")]
    [InlineData("Codility We test coders", 12, "Codility ...")]
    [InlineData("Codility We test coders", 13, "Codility ...")]
    [InlineData("Codility We test coders", 14, "Codility ...")]
    [InlineData("Codility We test coders", 15, "Codility We ...")]
    [InlineData("Codility We test coders", 16, "Codility We ...")]
    [InlineData("Codility We test coders", 17, "Codility We ...")]
    [InlineData("Codility We test coders", 18, "Codility We ...")]
    [InlineData("Codility We test coders", 19, "Codility We ...")]
    [InlineData("Codility We test coders", 20, "Codility We test ...")]
    [InlineData("Codility We test coders", 21, "Codility We test ...")]
    [InlineData("Codility We test coders", 22, "Codility We test ...")]
    [InlineData("Codility We test coders", 23, "Codility We test coders")]
    [InlineData("Codility We test coders", 24, "Codility We test coders")]
    [InlineData("Codility We test coders", 25, "Codility We test coders")]
    public void Test1(string text, int K, string expected)
    {
        var result = TruncateString.Solution(text, K);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("My name is daniel and this is a test", 1, "...")]
    [InlineData("My name is daniel and this is a test", 2, "...")]
    [InlineData("My name is daniel and this is a test", 3, "...")]
    [InlineData("My name is daniel and this is a test", 4, "...")]
    [InlineData("My name is daniel and this is a test", 5, "...")]
    [InlineData("My name is daniel and this is a test", 6, "My ...")]
    [InlineData("My name is daniel and this is a test", 7, "My ...")]
    [InlineData("My name is daniel and this is a test", 8, "My ...")]
    [InlineData("My name is daniel and this is a test", 9, "My ...")]
    [InlineData("My name is daniel and this is a test", 10, "My ...")]
    [InlineData("My name is daniel and this is a test", 11, "My name ...")]
    [InlineData("My name is daniel and this is a test", 12, "My name ...")]
    [InlineData("My name is daniel and this is a test", 13, "My name ...")]
    [InlineData("My name is daniel and this is a test", 14, "My name is ...")]
    [InlineData("My name is daniel and this is a test", 15, "My name is ...")]
    [InlineData("My name is daniel and this is a test", 16, "My name is ...")]
    [InlineData("My name is daniel and this is a test", 17, "My name is ...")]
    [InlineData("My name is daniel and this is a test", 18, "My name is ...")]
    [InlineData("My name is daniel and this is a test", 19, "My name is ...")]
    [InlineData("My name is daniel and this is a test", 20, "My name is ...")]
    [InlineData("My name is daniel and this is a test", 21, "My name is daniel ...")]
    [InlineData("My name is daniel and this is a test", 36, "My name is daniel and this is a test")]
    public void Test2(string text, int K, string expected)
    {
        var result = TruncateString.Solution(text, K);
        Assert.Equal(expected, result);
    }
}