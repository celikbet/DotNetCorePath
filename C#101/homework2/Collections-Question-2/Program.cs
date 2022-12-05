using System;
using System.Collections;

namespace CollectionsQuestion2 {

    public class Program {

        static void Main(string[] args) 
        {

            Console.WriteLine("Please enter 20 numbers with empty spaces on one line");
            int[] numbers = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int n = 3;

            Array.Sort(numbers);
            int minSum = Summation(numbers, n);
            int minAverage = Average(minSum, n);
            Console.WriteLine($"Sum of Three Lowest Numbers: {minSum}");
            Console.WriteLine($"Average of Three Lowest Numbers: {minAverage}");

            Array.Reverse(numbers);
            int maxSum = Summation(numbers, n);
            int maxAverage = Average(maxSum, n);
            Console.WriteLine($"Sum of Three Highest Numbers: {maxSum}");
            Console.WriteLine($"Average of Three Highest Numbers: {maxAverage}");

            Console.WriteLine($"Sum of the Averages: {minAverage + maxAverage}");            

        }


        static int Summation(int[] numberArray, int n) 
        {
            int sum = 0;
            for (int j=0; j<n; j++) 
                sum += numberArray[j];

            return sum;
        }

        static int Average(int total, int n) 
        {
            return total / n;
        }
    }
}
