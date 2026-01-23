using CSharpDojo.Problems;

namespace CSharpDojo.Tests;

public class StringKataTests
{
    // Reverse tests
    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("world", "dlrow")]
    [InlineData("a", "a")]
    [InlineData("", "")]
    [InlineData("racecar", "racecar")]
    public void Reverse_ShouldReverseString(string input, string expected)
    {
        Assert.Equal(expected, StringKata.Reverse(input));
    }

    // CountVowels tests
    [Theory]
    [InlineData("hello", 2)]
    [InlineData("HELLO", 2)]
    [InlineData("xyz", 0)]
    [InlineData("aeiou", 5)]
    [InlineData("AEIOU", 5)]
    [InlineData("Hello World", 3)]
    [InlineData("", 0)]
    public void CountVowels_ShouldCountCorrectly(string input, int expected)
    {
        Assert.Equal(expected, StringKata.CountVowels(input));
    }

    // IsPalindrome tests
    [Theory]
    [InlineData("racecar", true)]
    [InlineData("hello", false)]
    [InlineData("A man a plan a canal Panama", true)]
    [InlineData("Was it a car or a cat I saw", true)]
    [InlineData("", true)]
    [InlineData("a", true)]
    [InlineData("ab", false)]
    public void IsPalindrome_ShouldDetectPalindromes(string input, bool expected)
    {
        Assert.Equal(expected, StringKata.IsPalindrome(input));
    }

    // ToTitleCase tests
    [Theory]
    [InlineData("hello world", "Hello World")]
    [InlineData("HELLO WORLD", "Hello World")]
    [InlineData("hELLO wORLD", "Hello World")]
    [InlineData("a", "A")]
    [InlineData("", "")]
    [InlineData("the quick brown fox", "The Quick Brown Fox")]
    public void ToTitleCase_ShouldConvertCorrectly(string input, string expected)
    {
        Assert.Equal(expected, StringKata.ToTitleCase(input));
    }
}
