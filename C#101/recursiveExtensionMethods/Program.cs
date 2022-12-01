using System;

namespace recursiveExtensionMethods {
    public class Program 
    {
        static void Main(string[] args) 
        {
            // Recursive Functions

            // Calculate 3^4
            int result = 1;
            int number = 3;
            int exponential = 4;

            for (int i = 1; i < exponential+1; i++)
            {
                result = result * number;
            }
            Console.WriteLine(result);

            Calculations calculations = new Calculations();
            result = calculations.Exponential(number, exponential);
            Console.WriteLine(result);

            // Extension Methods
            string sentence = "betul celik cetin";
            bool checkResult = sentence.CheckSpaces();
            Console.WriteLine(checkResult);

            if(checkResult) {
                string newSentence = sentence.RemoveWhiteSpaces();
                Console.WriteLine(newSentence);
            }

            Console.WriteLine(sentence.MakeUpperCase());
            Console.WriteLine(sentence.MakeLowerCase());


            int[] numbers = {9, 3, 6, 2, 1, 5, 0};
            numbers.SortArray();
            numbers.Display();

            int value = 5;
            Console.WriteLine(value.IsEvenNumber());

            Console.WriteLine(sentence.GetFirstCharacter());

        }
    }

    public class Calculations 
    {
        public int Exponential(int number, int expo) {
            if (expo < 2)
                return number;
            else
                return Exponential(number, expo-1)*number;
        }
    }

    public static class Extensions 
    {

        public static bool CheckSpaces(this string data) 
        {
            return data.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string data) 
        {
            string[] series = data.Split(" ");
            return string.Join("", series);
        }

        public static string MakeUpperCase(this string data) 
        {
            return data.ToUpper();
        }

        public static string MakeLowerCase(this string data) 
        {
            return data.ToLower();
        }    

        public static int[] SortArray(this int[] data) 
        {
            Array.Sort(data);
            return data;
        }

        public static void Display(this int[] data) 
        {
            foreach (int item in data) 
            Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int data) 
        {
            return data%2 == 0;
        }

        public static string GetFirstCharacter(this string data)  
        {
            return data.Substring(0, 1);
        }
    }
}