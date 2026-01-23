namespace CSharpDojo.Problems;

/// <summary>
/// The classic FizzBuzz kata.
/// Implement each method to make the tests pass.
/// </summary>
public static class FizzBuzzKata
{
    /// <summary>
    /// Returns "Fizz" if divisible by 3, "Buzz" if divisible by 5,
    /// "FizzBuzz" if divisible by both, otherwise the number as a string.
    /// Example: 3 -> "Fizz", 5 -> "Buzz", 15 -> "FizzBuzz", 7 -> "7"
    /// </summary>
    public static string FizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 ==0)
        {
            return "FizzBuzz";
        }
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        if (number % 5 == 0)
        {
            return "Buzz";
        }
        return number.ToString();
    }

    /// <summary>
    /// Returns a list of FizzBuzz results from 1 to n (inclusive).
    /// Example: FizzBuzzRange(5) -> ["1", "2", "Fizz", "4", "Buzz"]
    /// </summary>
    public static List<string> FizzBuzzRange(int n)
    {
        List<string> results = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            results.Add(FizzBuzz(i));
        }
        return results;
    }
}
