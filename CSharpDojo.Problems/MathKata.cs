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
    
    // Recursive implementation
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
    
    // List + for loop implementation
    public static long FibonacciListAndLoop(int n)
    {
        List<int> f = new List<int>();
        for (int i = 0; i <= n; i++)
        {
            if (i == 0 || i == 1)
            {
                f.Add(i);
                continue;
            }
            f.Add(f[i - 1] + f[i - 2]);
        } 
        return f[n];
    }

    // Two pointer implementation
    public static long Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return 1;
        }
        int f = 0;
        int s = 1;
        int r = 0;
        for (int i = 2; i <= n; i++)
        {
            r = f + s;
            f = s;
            s = r;
        }
        return r;
    }

    /// <summary>
    /// Returns true if the number is prime.
    /// Example: 17 -> true, 15 -> false
    /// </summary>
    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Returns the greatest common divisor of two numbers.
    /// Example: GCD(48, 18) -> 6
    /// </summary>
     
    // Recursive implementation of Euclidean algorithm
    public static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        return GCD(b, a % b);
    }
}
