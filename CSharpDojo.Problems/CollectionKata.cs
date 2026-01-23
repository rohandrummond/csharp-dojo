namespace CSharpDojo.Problems;

/// <summary>
/// Collection and LINQ exercises.
/// Implement each method to make the tests pass.
/// </summary>
public static class CollectionKata
{
    /// <summary>
    /// Groups words by their first letter (case-insensitive).
    /// Example: ["apple", "Ant", "bear"] -> { 'A': ["apple", "Ant"], 'B': ["bear"] }
    /// Keys should be uppercase.
    /// </summary>
    public static Dictionary<char, List<string>> GroupByFirstLetter(IEnumerable<string> words)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the most frequent element in the collection.
    /// If there's a tie, return any of the most frequent.
    /// Throws ArgumentException if collection is empty.
    /// Example: [1, 2, 2, 3, 3, 3, 4] -> 3
    /// </summary>
    public static T MostFrequent<T>(IEnumerable<T> items) where T : notnull
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Flattens a nested list into a single list.
    /// Example: [[1, 2], [3, 4], [5]] -> [1, 2, 3, 4, 5]
    /// </summary>
    public static List<T> Flatten<T>(IEnumerable<IEnumerable<T>> nested)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns elements that appear in both collections.
    /// Example: [1, 2, 3, 4] and [3, 4, 5, 6] -> [3, 4]
    /// </summary>
    public static List<T> Intersection<T>(IEnumerable<T> first, IEnumerable<T> second)
    {
        throw new NotImplementedException();
    }
}
