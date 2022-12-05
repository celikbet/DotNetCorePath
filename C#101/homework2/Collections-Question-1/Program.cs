using System;
using System.Collections;

namespace CollectionsQuestion1 {

    public class Program {

        static void Main(string[] args) 
        {
            ArrayList primeNumbers = new ArrayList();
            ArrayList nonPrimeNumbers = new ArrayList();

            int counter = 0;

            while (counter < 20) 
            {
                bool result = Int32.TryParse(Console.ReadLine(), out int number);
                if (result && number>0) 
                {
                    if (IsPrimeNumber(number))
                        primeNumbers.Add(number);
                    else 
                        nonPrimeNumbers.Add(number);

                    counter++;                  
                } 
                else 
                {
                    Console.WriteLine("Only positive numbers allowed!");
                }           
            }
             

            // Sort & Print Array Values
            primeNumbers.Sort();
            DisplayElements(primeNumbers);

            nonPrimeNumbers.Sort();
            DisplayElements(nonPrimeNumbers);

            // Print the Number of Elements within Arrays
            int p = primeNumbers.Count;
            int np = nonPrimeNumbers.Count;

            Console.WriteLine($"Number of elements within Prime Number: {p.ToString()}");
            Console.WriteLine($"Number of elements within Non-Prime Number: {np.ToString()}");

            // Calculate & Print the Average of Numbers
            decimal primeSum = Summation(primeNumbers);
            decimal nonPrimeSum = Summation(nonPrimeNumbers);

            decimal averagePrimeNumbers = Average(primeSum, p);
            Console.WriteLine($"Average of Prime Numbers: {averagePrimeNumbers.ToString()}");

            decimal averageNonPrimeNumbers = Average(nonPrimeSum, np);
            Console.WriteLine($"Average of Non-Prime Numbers: {averageNonPrimeNumbers.ToString()}");
            
        }

        static void DisplayElements(ArrayList data) 
        {
            foreach(var item in data) 
            {
                Console.WriteLine(item.ToString());
            }
        }
    
        static bool IsPrimeNumber(int number) 
        {
            for (int i=2; i<number; i++) 
            {
                if (number%i == 0)
                    return false;
            } 
            return true;
        }

        static decimal Summation(ArrayList array) 
        {
            decimal sum = 0;
            foreach(int item in array) {sum += item;}
            return sum;
        }

        static decimal Average(decimal total, int n) 
        {
            decimal average = total / n;
            return average;
        } 
    }
}
