using CSharpDojo.Problems;

namespace CSharpDojo.Tests;

public class ArrayKataTests
{
    // FindMax tests
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 5)]
    [InlineData(new[] { 5, 4, 3, 2, 1 }, 5)]
    [InlineData(new[] { 3, 1, 4, 1, 5, 9, 2, 6 }, 9)]
    [InlineData(new[] { -5, -2, -10, -1 }, -1)]
    [InlineData(new[] { 42 }, 42)]
    public void FindMax_ShouldFindMaximum(int[] numbers, int expected)
    {
        Assert.Equal(expected, ArrayKata.FindMax(numbers));
    }

    [Fact]
    public void FindMax_ShouldThrowForEmptyArray()
    {
        Assert.Throws<ArgumentException>(() => ArrayKata.FindMax(Array.Empty<int>()));
    }

    // RemoveDuplicates tests
    [Fact]
    public void RemoveDuplicates_ShouldRemoveDuplicates()
    {
        var result = ArrayKata.RemoveDuplicates(new[] { 1, 2, 2, 3, 1, 4 });
        Assert.Equal(new[] { 1, 2, 3, 4 }, result);
    }

    [Fact]
    public void RemoveDuplicates_ShouldHandleNoDuplicates()
    {
        var result = ArrayKata.RemoveDuplicates(new[] { 1, 2, 3, 4 });
        Assert.Equal(new[] { 1, 2, 3, 4 }, result);
    }

    [Fact]
    public void RemoveDuplicates_ShouldHandleAllDuplicates()
    {
        var result = ArrayKata.RemoveDuplicates(new[] { 5, 5, 5, 5 });
        Assert.Equal(new[] { 5 }, result);
    }

    [Fact]
    public void RemoveDuplicates_ShouldHandleEmptyArray()
    {
        var result = ArrayKata.RemoveDuplicates(Array.Empty<int>());
        Assert.Empty(result);
    }

    // RotateLeft tests
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 3, 4, 5, 1, 2 })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 0, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 1, 2, 3 }, 1, new[] { 2, 3, 1 })]
    public void RotateLeft_ShouldRotateCorrectly(int[] input, int positions, int[] expected)
    {
        Assert.Equal(expected, ArrayKata.RotateLeft(input, positions));
    }

    // TwoSum tests
    [Fact]
    public void TwoSum_ShouldFindPair()
    {
        var result = ArrayKata.TwoSum(new[] { 2, 7, 11, 15 }, 9);
        Assert.NotNull(result);
        Assert.Equal(2, result.Length);
        Assert.Equal(9, new[] { 2, 7, 11, 15 }[result[0]] + new[] { 2, 7, 11, 15 }[result[1]]);
    }

    [Fact]
    public void TwoSum_ShouldReturnNullWhenNoSolution()
    {
        var result = ArrayKata.TwoSum(new[] { 1, 2, 3 }, 100);
        Assert.Null(result);
    }

    [Fact]
    public void TwoSum_ShouldWorkWithNegativeNumbers()
    {
        var result = ArrayKata.TwoSum(new[] { -3, 4, 3, 90 }, 0);
        Assert.NotNull(result);
        var numbers = new[] { -3, 4, 3, 90 };
        Assert.Equal(0, numbers[result[0]] + numbers[result[1]]);
    }
}
