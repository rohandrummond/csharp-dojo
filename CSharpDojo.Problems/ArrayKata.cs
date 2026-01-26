namespace CSharpDojo.Problems;

/// <summary>
/// Array manipulation exercises.
/// Implement each method to make the tests pass.
/// </summary>
public static class ArrayKata
{
    /// <summary>
    /// Finds the maximum value in an array of integers.
    /// Throws ArgumentException if array is empty.
    /// Example: [3, 1, 4, 1, 5, 9] -> 9
    /// </summary>
    public static int FindMax(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException("arg array can't be empty");
        }
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    /// <summary>
    /// Returns a new array with duplicates removed, preserving order.
    /// Example: [1, 2, 2, 3, 1, 4] -> [1, 2, 3, 4]
    /// </summary>
    
    // Basic implementation using .Disctint()
    // public static int[] RemoveDuplicates(int[] numbers)
    // {
    //     return numbers.Distinct().ToArray();
    // }

    // More efficient implementation using HashSet
    public static int[] RemoveDuplicates(int[] numbers)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();
        foreach (int number in numbers)
        {
            if (seen.Add(number))
            {
                result.Add(number);
            }
        }
        return result.ToArray();
    }

    /// <summary>
    /// Rotates array elements to the left by n positions.
    /// Example: [1, 2, 3, 4, 5] rotated by 2 -> [3, 4, 5, 1, 2]
    /// </summary>
    
    // Split array at position and then swap 
    public static int[] RotateLeft(int[] numbers, int positions)
    {
        if (positions == numbers.Length)
        {
            return numbers;
        }
        int[] first = numbers[..positions];
        int[] second = numbers[positions..];
        return second.Concat(first).ToArray();
    }

    /// <summary>
    /// Returns the two indices of numbers that add up to the target.
    /// Returns null if no solution exists.
    /// Example: [2, 7, 11, 15] with target 9 -> [0, 1] (because 2 + 7 = 9)
    /// </summary>
     
    // Calculate complement needed and check with Array.IndexOf
    public static int[]? TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int needed = target - numbers[i];
            int found = Array.IndexOf(numbers, needed);
            if (found != -1)
            {
                return [i, found];
            }
        }
        return null;
    }
}
