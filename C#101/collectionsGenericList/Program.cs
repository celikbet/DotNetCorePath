using System;

namespace collectionsGenericList {

    public class Program {

        static void Main(string[] args) 
        {
            // List<T> class
            // System.Collection.Generic
            // T = object türündedir. (liste içerisindeki nesnelerin tipini ifade ediyor.)

            List<int> numberList = new List<int>();

            numberList.Add(23);
            numberList.Add(10);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(92);
            numberList.Add(34);


            List<string> colorList = new List<string>();
            colorList.Add("Red");
            colorList.Add("Blue");
            colorList.Add("Orange");
            colorList.Add("Yellow");
            colorList.Add("Green");

            // Count Number of Element within the list
            Console.WriteLine(colorList.Count());
            Console.WriteLine(numberList.Count());


            foreach(var item in numberList) 
                Console.WriteLine(item);

            foreach(var item in colorList) 
                Console.WriteLine(item);


            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));

            // Remove Element by Value
            numberList.Remove(4);
            colorList.Remove("Red");

            // Remove Element by Index
            numberList.RemoveAt(0);
            colorList.RemoveAt(2);

            // Search within the List
            if (numberList.Contains(10)) 
            {
                Console.WriteLine("10 is found on the list");
            }

            // Reach to index by value 
            Console.WriteLine(colorList.BinarySearch("Yellow"));

            // Convert to List
            string[] animals = {"Cat", "Dog", "Bird"};
            List<string> animalList = new List<string>(animals);

            // Clear the List
            animalList.Clear();

            // Save object within the list
            List<Users> userList = new List<Users>();
            // objects of users class required to assign element into it
            Users userOne = new Users(); 
            userOne.Name = "name1"; 
            userOne.Surname = "lastName1";
            userOne.Age = 27;

            Users userTwo = new Users(); 
            userTwo.Name = "name2"; 
            userTwo.Surname = "lastName2";
            userTwo.Age = 28;

            // assing users to Users object
            userList.Add(userOne);
            userList.Add(userTwo);

            List<Users> newUserList = new List<Users>();
            newUserList.Add(new Users(){
                Name = "newName1",
                Surname = "newLastName1",
                Age = 29,  
            });

            foreach(var user in userList) {
                Console.WriteLine("User Name: " + user.Name);
                Console.WriteLine("User LastName: " + user.Surname);
                Console.WriteLine("User Age: " + user.Age);
            }

            userList.Clear();


        }
    }

    public class Users {
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}
