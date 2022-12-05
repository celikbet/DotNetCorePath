using System;
using System.Collections;

namespace collectionsArrayList {

    public class Program {

        static void Main(string[] args) 
        {
            
            ArrayList list = new ArrayList();
            list.Add("name");
            list.Add(2);
            list.Add(true);
            list.Add('A');

            // Reach to elements into arrayList
            Console.WriteLine(list[0]);
            foreach(var item in list) {Console.WriteLine(item);}

            // AddRange
            Console.WriteLine("****** AddRange ******");
            string[] colors = {"Red", "Yellow", "Green"};
            List<int> numbers = new List<int>(){1,8,3,7,9,92,5};

            list.AddRange(colors);
            list.AddRange(numbers);

            foreach(var item in list) {Console.WriteLine(item);}


            // Sort
            Console.WriteLine("****** Sort ******");
            //list.Sort(); // throws an error on compile time since all element can't be sorted!

            ArrayList numberList = new ArrayList();
            numberList.AddRange(numbers);
            numberList.Sort();
            foreach(var item in numberList) {Console.WriteLine(item);}

            // BinarySearch
            Console.WriteLine("****** Binary Search ******");
            Console.WriteLine(numberList.BinarySearch(9));

            // Reverse
            Console.WriteLine("****** Reverse ******");
            numberList.Reverse();
            foreach(var item in numberList) {Console.WriteLine(item);}

            // Clear
            Console.WriteLine("****** Clear ******");
            numberList.Clear();
            foreach(var item in numberList) {Console.WriteLine(item);}

        }
    }
}
