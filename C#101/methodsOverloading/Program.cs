using System;

namespace methodsOverloading {
    public class Program {

        static void Main(string[] args) {

            // Out Parameters
            string number = "999";
            bool result = int.TryParse(number, out int outNumber);
            if(result)
                Console.WriteLine($"Conversion is successful! OutNumber is {outNumber}");
            else 
            Console.WriteLine("Unsuccessful!");

            Methods methods = new Methods();
            methods.Summation(4, 5, out int sumResult);
            Console.WriteLine(sumResult);

            // Method Overloading
            int number1 = 999;
            methods.Display(number1.ToString());
            methods.Display(number1);
            methods.Display("betul", "celik cetin");

            // Decision w.r.t method's sign which is combined of method's name and method's parameters
            // creating same method with different name and/or different typed parameters allowed! and called Method Overloading!

        }
    }

    public class Methods {

        public void Summation(int a, int b, out int sum) {
            sum = a + b;
        }

        public void Display(string data) {
            Console.WriteLine(data);
        }

        public void Display(int data) {
            Console.WriteLine(data);
        }

        public void Display(string data, string data1) {
            Console.WriteLine(data);
        }

    }
}
