
namespace Algorithms.Examples;
public static class AlgorithmsConsole
{
    public static void WriteFibonacciNumbers(int maxNumber)
    {
        Console.WriteLine("Fibonacci Numbers");
        Console.WriteLine("---");
        var fibonacciNumbers = FibonacciNumbers(maxNumber);
        Console.WriteLine(string.Join(", ", fibonacciNumbers));
        Console.WriteLine("");
    }
    private static IEnumerable<int> FibonacciNumbers(int maxNumber)
    {
        for(int a = 0, b = 1; a <= maxNumber; (a, b) = (b, a + b))
        {
            if(a == 1 && b == 1)
            continue;
            yield return a;   
        }
    }

    public static void WriteTwoSum(int[] nums, int target)
    {
        Console.WriteLine("Two Sum");
        Console.WriteLine("---");
        var twoSumResult = TwoSum(nums, target);
        Console.WriteLine(string.Join(", ", twoSumResult));
    }
    private static IEnumerable<int> TwoSum(int[] nums, int target) {
        var seen = new HashSet<int>();

        foreach (var num in nums)
        {
            if (seen.Contains(target - num))
            {
                yield return target - num;
                yield return num;
                yield break; 
            }
            seen.Add(num);
        }
    }
} 