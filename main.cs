using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Perfect numbers between 1 and 10000:");
        for (int i = 1; i <= 10000; i++)
        {
            if (IsPerfectNumber(i))
            {
                Console.WriteLine(i);
            }
        }

        
        RunUnitTests();
    }

    public static bool IsPerfectNumber(int number)
    {
        if (number <= 1)
            return false;

        int sum = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
                sum += i;
        }
        return sum == number;
    }

    static void RunUnitTests()
    {
        int[] testInputs = { 496, 68, 5112, 8128 };
        string[] expectedOutputs = { "Perfect Number", "Not A Perfect Number", "Not A Perfect Number", "Perfect Number" };

        Console.WriteLine("\nRunning Unit Tests...\n");

        for (int i = 0; i < testInputs.Length; i++)
        {
            int input = testInputs[i];
            string expected = expectedOutputs[i];
            bool isPerfect = IsPerfectNumber(input);
            string actual = isPerfect ? "Perfect Number" : "Not A Perfect Number";

            Console.WriteLine($"Test #{i + 1}");
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Expected Outcome: {expected}");
            Console.WriteLine($"Actual Outcome: {actual}");
            Console.WriteLine(actual == expected ? "Test Passed" : "Test Failed");
            Console.WriteLine();
        }
    }
}