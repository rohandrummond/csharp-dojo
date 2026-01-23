using CSharpDojo.Problems;

namespace CSharpDojo.Tests;

public class CollectionKataTests
{
    // GroupByFirstLetter tests
    [Fact]
    public void GroupByFirstLetter_ShouldGroupCorrectly()
    {
        var words = new[] { "apple", "Ant", "bear", "Banana" };
        var result = CollectionKata.GroupByFirstLetter(words);

        Assert.Equal(2, result.Count);
        Assert.Contains('A', result.Keys);
        Assert.Contains('B', result.Keys);
        Assert.Equal(new[] { "apple", "Ant" }, result['A']);
        Assert.Equal(new[] { "bear", "Banana" }, result['B']);
    }

    [Fact]
    public void GroupByFirstLetter_ShouldHandleEmptyInput()
    {
        var result = CollectionKata.GroupByFirstLetter(Array.Empty<string>());
        Assert.Empty(result);
    }

    // MostFrequent tests
    [Fact]
    public void MostFrequent_ShouldFindMostFrequent()
    {
        var items = new[] { 1, 2, 2, 3, 3, 3, 4 };
        Assert.Equal(3, CollectionKata.MostFrequent(items));
    }

    [Fact]
    public void MostFrequent_ShouldWorkWithStrings()
    {
        var items = new[] { "a", "b", "b", "c" };
        Assert.Equal("b", CollectionKata.MostFrequent(items));
    }

    [Fact]
    public void MostFrequent_ShouldThrowForEmpty()
    {
        Assert.Throws<ArgumentException>(() => CollectionKata.MostFrequent(Array.Empty<int>()));
    }

    // Flatten tests
    [Fact]
    public void Flatten_ShouldFlattenNestedLists()
    {
        var nested = new List<List<int>>
        {
            new() { 1, 2 },
            new() { 3, 4 },
            new() { 5 }
        };
        var expected = new List<int> { 1, 2, 3, 4, 5 };
        Assert.Equal(expected, CollectionKata.Flatten(nested));
    }

    [Fact]
    public void Flatten_ShouldHandleEmptyInnerLists()
    {
        var nested = new List<List<int>>
        {
            new() { 1 },
            new(),
            new() { 2, 3 }
        };
        var expected = new List<int> { 1, 2, 3 };
        Assert.Equal(expected, CollectionKata.Flatten(nested));
    }

    // Intersection tests
    [Fact]
    public void Intersection_ShouldFindCommonElements()
    {
        var first = new[] { 1, 2, 3, 4 };
        var second = new[] { 3, 4, 5, 6 };
        var result = CollectionKata.Intersection(first, second);
        Assert.Equal(new[] { 3, 4 }, result.OrderBy(x => x).ToList());
    }

    [Fact]
    public void Intersection_ShouldReturnEmptyWhenNoCommon()
    {
        var first = new[] { 1, 2 };
        var second = new[] { 3, 4 };
        var result = CollectionKata.Intersection(first, second);
        Assert.Empty(result);
    }

    [Fact]
    public void Intersection_ShouldHandleEmptyInputs()
    {
        var result = CollectionKata.Intersection(Array.Empty<int>(), new[] { 1, 2 });
        Assert.Empty(result);
    }
}
