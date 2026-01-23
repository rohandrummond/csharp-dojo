using CSharpDojo.Problems;

namespace CSharpDojo.Tests;

public class MathKataTests
{
    // Factorial tests
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(5, 120)]
    [InlineData(10, 3628800)]
    [InlineData(3, 6)]
    public void Factorial_ShouldCalculateCorrectly(int n, long expected)
    {
        Assert.Equal(expected, MathKata.Factorial(n));
    }

    [Fact]
    public void Factorial_ShouldThrowForNegative()
    {
        Assert.Throws<ArgumentException>(() => MathKata.Factorial(-1));
    }

    // Fibonacci tests
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    [InlineData(6, 8)]
    [InlineData(10, 55)]
    public void Fibonacci_ShouldCalculateCorrectly(int n, long expected)
    {
        Assert.Equal(expected, MathKata.Fibonacci(n));
    }

    // IsPrime tests
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(17, true)]
    [InlineData(15, false)]
    [InlineData(97, true)]
    [InlineData(100, false)]
    [InlineData(1, false)]
    [InlineData(0, false)]
    [InlineData(-5, false)]
    public void IsPrime_ShouldIdentifyPrimes(int number, bool expected)
    {
        Assert.Equal(expected, MathKata.IsPrime(number));
    }

    // GCD tests
    [Theory]
    [InlineData(48, 18, 6)]
    [InlineData(54, 24, 6)]
    [InlineData(17, 13, 1)]
    [InlineData(100, 25, 25)]
    [InlineData(7, 7, 7)]
    [InlineData(0, 5, 5)]
    [InlineData(5, 0, 5)]
    public void GCD_ShouldCalculateCorrectly(int a, int b, int expected)
    {
        Assert.Equal(expected, MathKata.GCD(a, b));
    }
}
