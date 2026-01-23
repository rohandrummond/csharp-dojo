using System.Reflection.PortableExecutable;
using System.Text;

namespace CSharpDojo.Problems;

public static class StringKata
{
    /// <summary>
    /// Reverses the input string.
    /// Example: "hello" -> "olleh"
    /// </summary>
    public static string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        int l = 0;
        int r = chars.Length - 1;
        while (l < r)
        {
            char t = chars[l];
            chars[l] = chars[r];
            chars[r] = t;
            l++;
            r--;
        }
        return new string(chars);
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
        string normal = input.Replace(" ", "").ToLower();
        int l = 0;
        int r = normal.Length - 1;
        while (l < r)
        {
            if (normal[l] != normal[r])
            {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }

    /// <summary>
    /// Converts a string to title case (first letter of each word capitalized).
    /// Example: "hello world" -> "Hello World"
    /// </summary>
    public static string ToTitleCase(string input)
    {
        if (input.Length == 0)
        {
            return input;
        }
        StringBuilder sb = new StringBuilder(input.ToLower());
        sb[0] = char.ToUpper(sb[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if (sb[i - 1] == ' ')
            {
                sb[i] = char.ToUpper(sb[i]);
            }
        }
        return sb.ToString();
    }
}
