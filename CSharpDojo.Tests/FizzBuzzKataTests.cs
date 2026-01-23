using CSharpDojo.Problems;

namespace CSharpDojo.Tests;

public class FizzBuzzKataTests
{
    // FizzBuzz single number tests
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]
    [InlineData(4, "4")]
    [InlineData(5, "Buzz")]
    [InlineData(6, "Fizz")]
    [InlineData(10, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(30, "FizzBuzz")]
    [InlineData(9, "Fizz")]
    [InlineData(25, "Buzz")]
    public void FizzBuzz_ShouldReturnCorrectResult(int number, string expected)
    {
        Assert.Equal(expected, FizzBuzzKata.FizzBuzz(number));
    }

    // FizzBuzzRange tests
    [Fact]
    public void FizzBuzzRange_ShouldReturnCorrectSequence()
    {
        var expected = new List<string> { "1", "2", "Fizz", "4", "Buzz" };
        Assert.Equal(expected, FizzBuzzKata.FizzBuzzRange(5));
    }

    [Fact]
    public void FizzBuzzRange_ShouldIncludeFizzBuzz()
    {
        var result = FizzBuzzKata.FizzBuzzRange(15);
        Assert.Equal(15, result.Count);
        Assert.Equal("FizzBuzz", result[14]); // 15th element (index 14)
    }

    [Fact]
    public void FizzBuzzRange_ShouldHandleSingleElement()
    {
        var result = FizzBuzzKata.FizzBuzzRange(1);
        Assert.Single(result);
        Assert.Equal("1", result[0]);
    }
}
