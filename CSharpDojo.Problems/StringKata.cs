using System.Reflection.PortableExecutable;

namespace CSharpDojo.Problems;

public static class StringKata
{
    /// <summary>
    /// Reverses the input string.
    /// Example: "hello" -> "olleh"
    /// </summary>
    public static string Reverse(string input)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Counts the number of vowels (a, e, i, o, u) in the string.
    /// Should be case-insensitive.
    /// Example: "Hello World" -> 3
    /// </summary>
    public static int CountVowels(string input)
    {
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            char c = char.ToLower(input[i]);
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    count++;
                    break;
            }
        }
        return count;
    }

    /// <summary>
    /// Returns true if the string is a palindrome (reads same forwards and backwards).
    /// Should be case-insensitive and ignore spaces.
    /// Example: "A man a plan a canal Panama" -> true
    /// </summary>
    public static bool IsPalindrome(string input)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Converts a string to title case (first letter of each word capitalized).
    /// Example: "hello world" -> "Hello World"
    /// </summary>
    public static string ToTitleCase(string input)
    {
        throw new NotImplementedException();
    }
}
