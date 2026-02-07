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

    // TopKFrequent tests
    [Fact]
    public void TopKFrequent_ShouldReturnTopK()
    {
        var items = new[] { 1, 1, 1, 2, 2, 3 };
        var result = CollectionKata.TopKFrequent(items, 2);
        Assert.Equal(new[] { 1, 2 }, result.OrderBy(x => x).ToArray());
    }

    [Fact]
    public void TopKFrequent_ShouldHandleKLessThanOrEqualZero()
    {
        var items = new[] { 1, 2, 3 };
        var result = CollectionKata.TopKFrequent(items, 0);
        Assert.Empty(result);
    }

    [Fact]
    public void TopKFrequent_ShouldHandleEmptyInput()
    {
        var result = CollectionKata.TopKFrequent(Array.Empty<int>(), 3);
        Assert.Empty(result);
    }

    // GroupAnagrams tests
    [Fact]
    public void GroupAnagrams_ShouldGroupCorrectly()
    {
        var words = new[] { "eat", "Tea", "tan", "ate", "nat", "bat" };
        var result = CollectionKata.GroupAnagrams(words);

        Assert.True(result.ContainsKey("aet"));
        Assert.True(result.ContainsKey("ant"));
        Assert.True(result.ContainsKey("abt"));

        AssertStringGroup(result["aet"], new[] { "eat", "Tea", "ate" });
        AssertStringGroup(result["ant"], new[] { "tan", "nat" });
        AssertStringGroup(result["abt"], new[] { "bat" });
    }

    [Fact]
    public void GroupAnagrams_ShouldHandleEmptyInput()
    {
        var result = CollectionKata.GroupAnagrams(Array.Empty<string>());
        Assert.Empty(result);
    }

    // LongestConsecutive tests
    [Fact]
    public void LongestConsecutive_ShouldFindLongestSequence()
    {
        var numbers = new[] { 100, 4, 200, 1, 3, 2 };
        Assert.Equal(4, CollectionKata.LongestConsecutive(numbers));
    }

    [Fact]
    public void LongestConsecutive_ShouldHandleDuplicates()
    {
        var numbers = new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
        Assert.Equal(9, CollectionKata.LongestConsecutive(numbers));
    }

    [Fact]
    public void LongestConsecutive_ShouldHandleEmpty()
    {
        Assert.Equal(0, CollectionKata.LongestConsecutive(Array.Empty<int>()));
    }

    private static void AssertStringGroup(IEnumerable<string> actual, IEnumerable<string> expected)
    {
        Assert.Equal(expected.OrderBy(x => x).ToArray(), actual.OrderBy(x => x).ToArray());
    }
}
