using System;

namespace collectionsDictionary {
    public class Program {

        static void Main(string[] args) 
        {
            // system.collections.generic

            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(10, "name10");
            users.Add(12, "name12");
            users.Add(18, "name18");
            users.Add(20, "name20");

            // Reach to element of an dictionary
            Console.WriteLine("****** Reach to Dictionary Elements ******");
            Console.WriteLine(users[12]);
            foreach(var item in users) {Console.WriteLine(item);}

            // Count
            Console.WriteLine("****** Count Dictionary Elements ******");
            Console.WriteLine(users.Count);

            // Contains
            Console.WriteLine("****** Contains ******");
            Console.WriteLine(users.ContainsKey(18));
            Console.WriteLine(users.ContainsValue("name20"));

            // Remove
            Console.WriteLine("****** Remove ******");
            users.Remove(12);
            foreach(var item in users) {Console.WriteLine(item);}

            // Print Only Values
            Console.WriteLine("****** Values ******");
            foreach(var item in users) {Console.WriteLine(item.Value);}
            foreach(var item in users.Values) {Console.WriteLine(item);}

            // Print Only Keys
            Console.WriteLine("****** Keys ******");
            foreach(var item in users) {Console.WriteLine(item.Key);}
            foreach(var item in users.Keys) {Console.WriteLine(item);}


        }
    }
}
