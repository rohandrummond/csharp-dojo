using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace CSharpDojo.Problems;

/// <summary>
/// Mathematical exercises.
/// Implement each method to make the tests pass.
/// </summary>
public static class MathKata
{
    /// <summary>
    /// Returns the factorial of n (n!).
    /// Example: 5 -> 120 (5 * 4 * 3 * 2 * 1)
    /// Throws ArgumentException for negative numbers.
    /// </summary>
    public static long Factorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Argument must be a positive number");
        }
        if (n <= 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    /// <summary>
    /// Returns the nth Fibonacci number (0-indexed).
    /// Sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21...
    /// Example: Fibonacci(6) -> 8
    /// </summary>
    public static long Fibonacci(int n)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns true if the number is prime.
    /// Example: 17 -> true, 15 -> false
    /// </summary>
    public static bool IsPrime(int number)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the greatest common divisor of two numbers.
    /// Example: GCD(48, 18) -> 6
    /// </summary>
    public static int GCD(int a, int b)
    {
        throw new NotImplementedException();
    }
}
