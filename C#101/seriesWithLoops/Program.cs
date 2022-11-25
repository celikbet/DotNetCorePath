using System;

namespace seriesWithLoops {
    public class Program {
        static void Main(string[] args) 
        {
            // Definitions
            string[] colors = new string[5];
            string[] animals = {"cat", "dog", "bird", "monkey"};
            int[] series1;
            series1 = new int[5];

            // Assign a value & Reach to value 
            colors[0] = "blue";
            Console.WriteLine(colors[0]);
            Console.WriteLine(animals[1]);
            series1[3] = 10;
            Console.WriteLine(series1[3]);

            // Series with Loops
            Console.WriteLine("Please enter the number of element!");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] numberSeries = new int[length];

            for (int i=0; i<length; i++) 
            {
                Console.WriteLine("Please enter {0} th element's value: ", i+1);
                numberSeries[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int summation = 0;
            foreach (var number in numberSeries) 
            {
                summation += number;
            }
            Console.WriteLine("Average: " + summation/length);

        }
    }
}
