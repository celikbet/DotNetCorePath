using System;

namespace seriesWithArrayClassMethod {
    public class Program {

        static void Main(string[] args) {
            // SORT (sorting array elements within order)
            int[] numberArray = {23, 12, 4, 86, 72, 3, 11, 17};
     
            Console.WriteLine("***Array Without Order***");
            foreach(var number in numberArray) {
                Console.WriteLine(number);
            }

            Console.WriteLine("***Order Array***");
            Array.Sort(numberArray);
            foreach(var number in numberArray) {
                Console.WriteLine(number);
            }

            // CLEAR (assign zero to the spesified element' value of an array)
            Console.WriteLine("***Clear Array***");
            Array.Clear(numberArray, 2, 2);
            foreach(var number in numberArray) {
                Console.WriteLine(number);
            }      

            // REVERSE (reverse order of array elements)
            Console.WriteLine("***Reverse Array***");
            Array.Reverse(numberArray);
            foreach(var number in numberArray) {
                Console.WriteLine(number);
            }  

            // INDEXOF (specify the index of element's value within array)
            Console.WriteLine("***Index Of Array***");
            Console.WriteLine(Array.IndexOf(numberArray, 23));

            // RESIZE (resize the array length)
            Console.WriteLine("***Resize Array***");
            Array.Resize<int>(ref numberArray, 9);
            numberArray[8] = 99;
            foreach(var number in numberArray) {
                Console.WriteLine(number);
            }  
            
        }
    }
}
