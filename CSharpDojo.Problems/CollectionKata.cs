using System.IO.Pipelines;

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
        Dictionary<char, List<string>> groups = new();
        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                char letter = char.ToUpper(word[0]);
                if (!groups.TryGetValue(letter, out List<string>? wordList))
                {
                    wordList = new List<string>();
                    groups[letter] = wordList;
                }
                wordList.Add(word);        
            }
        }
        return groups;
    }

    /// <summary>
    /// Returns the most frequent element in the collection.
    /// If there's a tie, return any of the most frequent.
    /// Throws ArgumentException if collection is empty.
    /// Example: [1, 2, 2, 3, 3, 3, 4] -> 3
    /// </summary>
    public static T MostFrequent<T>(IEnumerable<T> items) where T : notnull
    {
        if (items == null || !items.Any())
        {
            throw new ArgumentException("items cannot be empty");
        }
        Dictionary<T, int> counts = new();
        T mostFrequent = default!;
        int maxCount = 0;
        foreach (T item in items)
        {
            counts.TryGetValue(item, out int count);
            count++;
            counts[item] = count;
            if (count > maxCount)
            {
                mostFrequent = item;
                maxCount = count;
            }
        }
        return mostFrequent;
    }

    /// <summary>
    /// Flattens a nested list into a single list.
    /// Example: [[1, 2], [3, 4], [5]] -> [1, 2, 3, 4, 5]
    /// </summary>
    
    // LINQ SelectMany approach
    // public static List<T> Flatten<T>(IEnumerable<IEnumerable<T>> nested)
    // {
    //     return nested.SelectMany(i => i).ToList();
    // }

    // Nested foreach approach (most performant)
    public static List<T> Flatten<T>(IEnumerable<IEnumerable<T>> nested)
    {
        List<T> result = new();
        foreach (IEnumerable<T> list in nested)
        {
            foreach (T item in list)
            {
                result.Add(item);
            }
        }
        return result;
    }

    /// <summary>
    /// Returns elements that appear in both collections.
    /// Example: [1, 2, 3, 4] and [3, 4, 5, 6] -> [3, 4]
    /// </summary>
     
    // Basic implementation (good memory but bad time complexity due to Contains being linear search)
    // public static List<T> Intersection<T>(IEnumerable<T> first, IEnumerable<T> second)
    // {
    //     List<T> result = new();
    //     foreach (T item in first)
    //     {
    //         if (second.Contains(item))
    //         {
    //             result.Add(item);
    //         }
    //     }
    //     return result;
    // }

    // HashSet IntersectWith implementation (better time complexity due to HashSet being a hash table, but worse memory)
    public static List<T> Intersection<T>(IEnumerable<T> first, IEnumerable<T> second)
    {
        HashSet<T> result = new(first);
        result.IntersectWith(second);
        return result.ToList();
    }

    /// <summary>
    /// Returns the k most frequent elements.
    /// If k <= 0, returns empty list.
    /// Example: [1,1,1,2,2,3], k=2 -> [1,2]
    /// </summary>
    public static List<T> TopKFrequent<T>(IEnumerable<T> items, int k) where T : notnull
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Groups words that are anagrams of each other (case-insensitive).
    /// Keys should be the sorted lowercase characters of the word.
    /// Example: ["eat","Tea","tan"] -> { "aet": ["eat","Tea"], "ant": ["tan"] }
    /// </summary>
    public static Dictionary<string, List<string>> GroupAnagrams(IEnumerable<string> words)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the length of the longest consecutive sequence.
    /// Example: [100,4,200,1,3,2] -> 4 (1,2,3,4)
    /// </summary>
    public static int LongestConsecutive(IEnumerable<int> numbers)
    {
        throw new NotImplementedException();
    }
}
