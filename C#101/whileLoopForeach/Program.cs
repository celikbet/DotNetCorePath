using System;

namespace whileLoopForeach {
    public class Program {
        static void Main(string[] args) 
        {
            // Calculate average of the numbers
            int number = int.Parse(Console.ReadLine());
            int count = 1;
            int summation = 0;

            while (count <= number) 
            {
                summation+=count;
                count++;
            }
            int average = summation/count;
            Console.WriteLine(average);

            // Print all the letters from a to z
            char character = 'a';
            while (character < 'z') 
            {
                Console.WriteLine(character);
                character++;
            }

            //Foreach
            string [] cars = {"BWM", "Volvo", "Toyota"};
            foreach(var item in cars) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
