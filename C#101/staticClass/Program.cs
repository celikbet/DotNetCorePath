using System;

namespace staticClass {

    class Program {

        static void Main(string[] args) 
        {
            Console.WriteLine("Number of Employee: {0}", Employee.NumberOfEmployee);
            Employee newEmployee1 = new Employee("nameOne", "lastNameOne", "IT-Department");
            Console.WriteLine("Number of Employee: {0}", Employee.NumberOfEmployee);
            Employee newEmployee2 = new Employee("nameTwo", "lastNameTwo", "IT-Department");
            Employee newEmployee3 = new Employee("nameThree", "lastNameThree", "IT-Department");
            Console.WriteLine("Number of Employee: {0}", Employee.NumberOfEmployee);


            // Calculations
            Console.WriteLine("Summation Result: {0}", Calculations.Sum(100,200));
            Console.WriteLine("Subtraction Result: {0}", Calculations.Subtract(400,50));

        }
    }

    class Employee {

        // Create static property of Employee Class
        private static int numberOfEmployee;

        // Make Property "numberOfEmployee" as be change by only Employee Class - set is not allowed 
        public static int NumberOfEmployee { get => numberOfEmployee; }

        private string Name;
        private string LastName;
        private string Department;

        // Create Static Constructor Method of Employee Class
        static Employee() {
            numberOfEmployee = 0;

        }


        // Create Constructor Method of Employee Class with properties
        public Employee(string name, string lastName, string department)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Department = department;
            numberOfEmployee ++;
        }
    }

    static class Calculations 
    {
        public static long Sum(int number1, int number2) 
        {
            return number1 + number2;
        }

        public static long Subtract(int number1, int number2) 
        {
            return number1 - number2;
        }
    }

}
