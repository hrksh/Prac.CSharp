using System.Runtime.CompilerServices;

namespace Prac.Algorithm;

public class FizzBuzz
{
    private static FizzBuzz _fizzBuzz = new FizzBuzz();
    public static FizzBuzz Init() => _fizzBuzz;
    
    private const string fizz = "fizz";
    private const string buzz = "buzz";
    
    /// <summary>
    /// FizzBuzz (自然数 100迄)
    /// </summary>
    /// <param name="number">入力値</param>
    public void ShowResult(int number)
    {
        if (number <= 0) return;
        if (number > 100) return;
        for (int i = 1; i <= number; i++)
        {
            if (i % 15 == 0)
                Console.WriteLine($"{i}:{fizz}{buzz}");
            else if (i % 5 == 0)
                Console.WriteLine($"{i}:{buzz}");
            else if (i % 3 == 0)
                Console.WriteLine($"{i}:{fizz}");
            else
                Console.WriteLine($"{i}:{i}");
        }
    }
}