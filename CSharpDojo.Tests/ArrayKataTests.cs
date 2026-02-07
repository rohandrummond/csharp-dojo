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

    // MaxSubarraySum tests
    [Theory]
    [InlineData(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 5, 4, -1, 7, 8 }, 23)]
    [InlineData(new[] { -3, -2, -1 }, -1)]
    public void MaxSubarraySum_ShouldFindMaxSum(int[] numbers, int expected)
    {
        Assert.Equal(expected, ArrayKata.MaxSubarraySum(numbers));
    }

    [Fact]
    public void MaxSubarraySum_ShouldThrowForEmptyArray()
    {
        Assert.Throws<ArgumentException>(() => ArrayKata.MaxSubarraySum(Array.Empty<int>()));
    }

    // MoveZeroes tests
    [Fact]
    public void MoveZeroes_ShouldMoveZeroesInPlace()
    {
        var numbers = new[] { 0, 1, 0, 3, 12 };
        ArrayKata.MoveZeroes(numbers);
        Assert.Equal(new[] { 1, 3, 12, 0, 0 }, numbers);
    }

    [Fact]
    public void MoveZeroes_ShouldHandleNoZeroes()
    {
        var numbers = new[] { 1, 2, 3 };
        ArrayKata.MoveZeroes(numbers);
        Assert.Equal(new[] { 1, 2, 3 }, numbers);
    }

    [Fact]
    public void MoveZeroes_ShouldHandleAllZeroes()
    {
        var numbers = new[] { 0, 0, 0 };
        ArrayKata.MoveZeroes(numbers);
        Assert.Equal(new[] { 0, 0, 0 }, numbers);
    }

    // MergeIntervals tests
    [Fact]
    public void MergeIntervals_ShouldMergeOverlaps()
    {
        var input = new[]
        {
            new[] { 1, 3 },
            new[] { 2, 6 },
            new[] { 8, 10 },
            new[] { 15, 18 }
        };
        var expected = new[]
        {
            new[] { 1, 6 },
            new[] { 8, 10 },
            new[] { 15, 18 }
        };

        var result = ArrayKata.MergeIntervals(input);
        AssertIntervalsEqual(expected, result);
    }

    [Fact]
    public void MergeIntervals_ShouldMergeTouchingIntervals()
    {
        var input = new[]
        {
            new[] { 1, 4 },
            new[] { 4, 5 }
        };
        var expected = new[]
        {
            new[] { 1, 5 }
        };

        var result = ArrayKata.MergeIntervals(input);
        AssertIntervalsEqual(expected, result);
    }

    [Fact]
    public void MergeIntervals_ShouldHandleEmpty()
    {
        var result = ArrayKata.MergeIntervals(Array.Empty<int[]>());
        AssertIntervalsEqual(Array.Empty<int[]>(), result);
    }

    [Fact]
    public void MergeIntervals_ShouldHandleSingleInterval()
    {
        var input = new[]
        {
            new[] { 1, 2 }
        };
        var result = ArrayKata.MergeIntervals(input);
        AssertIntervalsEqual(input, result);
    }

    private static void AssertIntervalsEqual(int[][] expected, int[][] actual)
    {
        Assert.Equal(expected.Length, actual.Length);
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i][0], actual[i][0]);
            Assert.Equal(expected[i][1], actual[i][1]);
        }
    }
}
