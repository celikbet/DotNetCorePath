using System;

namespace methodsString {

    public class Program {

        static void Main(string[] args) 
        {
            string variable = "Lecture CSharp, Welcome";
            string variable2 = "Lecture CSharp";
            string variable3 = "lecture CSharp, Welcome";

            // Length 
            Console.WriteLine(variable.Length);

            // ToUpper & ToLower
            Console.WriteLine(variable.ToUpper());
            Console.WriteLine(variable.ToLower());

            // Concat
            Console.WriteLine(string.Concat(variable, "Hello!"));

            // Compare & CompareTo
            Console.WriteLine(variable.CompareTo(variable2)); // returns true(0) / false(1) / -1
            Console.WriteLine(string.Compare(variable, variable3, true)); // ignoreCase=true > not sensitive to upper/lower case
            Console.WriteLine(string.Compare(variable, variable3, false)); // ignoreCase=false > sensitive to upper/lower case

            // Contains & EndsWith & StartWith
            Console.WriteLine(variable.Contains(variable2)); // returns boolean
            Console.WriteLine(variable.EndsWith("Welcome")); // returns boolean
            Console.WriteLine(variable.StartsWith("Hello!")); // returns boolean

            // IndexOf
            Console.WriteLine(variable.IndexOf("CS")); 
            Console.WriteLine(variable.IndexOf("bett")); // returns -1 since index does not exist!
            Console.WriteLine(variable.LastIndexOf("i")); 

            // Insert
            Console.WriteLine(variable.Insert(0, "Hello! ")); // starts from 0th index and add string 

            // PadLeft & PadRight
            Console.WriteLine(variable + variable2.PadLeft(30));
            Console.WriteLine(variable + variable2.PadLeft(30, '*'));
            Console.WriteLine(variable.PadRight(50, '-') + variable2);

            // Remove
            Console.WriteLine(variable.Remove(10));
            Console.WriteLine(variable.Remove(5,3));
            Console.WriteLine(variable.Remove(0,1));

            // Replace
            Console.WriteLine(variable.Replace("CSharp", "C#"));
            Console.WriteLine(variable.Replace(" ", "*"));

            // Split
            Console.WriteLine(variable.Split(' ')[1]); // returns the first index of a list that is made of strings splitted by spaces

            // Substring
            Console.WriteLine(variable.Substring(4)); // returns the characters starting from 4th index to last index
            Console.WriteLine(variable.Substring(4, 6)); // returns the characters starting from 4th index to 6th index


        }
    }
}
