using System;

namespace classAccessModifiersConstructorMethod {

    public class Program {

        static void Main(string[] args) 
        {
            Console.WriteLine("****** First Employee ******");
            Employee employeeOne = new Employee("nameOne", "lastNameOne", 2385599, "IT-Deparment");
            employeeOne.EmployeeInformation();

            Console.WriteLine("****** Second Employee ******");
            Employee employeeTwo = new Employee();
            employeeTwo.Name = "nameTwo";
            employeeTwo.LastName = "lastNameTwo";
            employeeTwo.Number = 2386699;
            employeeTwo.Department = "Sales-Department";
            employeeTwo.EmployeeInformation();

            Console.WriteLine("****** Third Employee ******");
            Employee employeeThree = new Employee("nameThree", "lastNameThree");
            employeeThree.EmployeeInformation();

        }                   
    }

    class Employee 
    {
        public string Name;
        public string LastName;
        public int Number;
        public string Department;

        // Constructor Method of Employee Class with parameters
        public Employee(string name, string lastname, int number, string deparment) 
        {
            this.Name = name;
            this.LastName = lastname;
            this.Number = number;
            this.Department = deparment;
        }

        // Constructor Method of Employee Class without parameters
        public Employee() {}

        // Another Constructor Method of Employee Class with only 2 parameters
        public Employee(string name, string lastname) 
        {
            this.Name = name;
            this.LastName = lastname;
        }


        public void EmployeeInformation()
        {
            Console.WriteLine("Employee' Name: " + Name);
            Console.WriteLine("Employee' LastName: " + LastName);
            Console.WriteLine("Employee' Number: " + Number);
            Console.WriteLine("Employee' Department: " + Department);
        }

    }
}
