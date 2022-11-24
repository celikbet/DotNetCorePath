using System;

namespace forLoop {
    public class Program {
        static void Main(string[] args) 
        {
            // Count the all odd numbers to the number entered on terminal
            Console.WriteLine("Please enter a number");
            int count = int.Parse(Console.ReadLine());
            for (int i=1; i<=count; i++) 
            {
                if(i%2 == 1) 
                    Console.WriteLine(i);
            }

            // Calculate summation of add numbers & summation of even numbers within the range 1-1000
            int sumOdd = 0;
            int sumEven = 0;

            for (int i=1; i<=1000; i++) 
            {
                if (i%2 == 1) 
                    sumOdd += i;
                else
                    sumEven += i;
            }

            Console.WriteLine("Summation of Even numbers: " + sumEven);
            Console.WriteLine("Summation of Odd numbers: " + sumOdd);

            // Use of Break && Continue
            for (int i=1; i<10; i++) 
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }

            for (int i=1; i<10; i++) 
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }


        }
    }
}
