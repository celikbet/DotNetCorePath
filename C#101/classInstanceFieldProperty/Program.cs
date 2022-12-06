using System;

namespace classInstanceFieldProperty {

    public class Program {

        static void Main(string[] args) 
        {
            // INFO
            //class ClassName
            //{
            //      [Access Modifiers] [Data Type] PropertyName
            //      [Access Modifiers] [Return Type] MethodName([ParameterList])
            //      {
            //          // method commands
            //      }
            //}

            // Access Modifiers: Public - Private - Internal - Protected


            // Create an instance from Employee Class
            Employee employeeOne = new Employee();
            employeeOne.Name = "nameOne";
            employeeOne.LastName = "lastNameOne";
            employeeOne.Number = 2385599;
            employeeOne.Department = "IT-Deparment";
            employeeOne.EmployeeInformation();
            Console.WriteLine("************************************");
            Employee employeeTwo = new Employee();
            employeeTwo.Name = "nameTwo";
            employeeTwo.LastName = "lastNameTwo";
            employeeTwo.Number = 2386699;
            employeeTwo.Department = "Sales-Department";
            employeeTwo.EmployeeInformation();


        }

        
        class Employee 
        {
            public string Name;
            public string LastName;
            public int Number;
            public string Department;

            public void EmployeeInformation()
            {
                Console.WriteLine("Employee' Name: " + Name);
                Console.WriteLine("Employee' LastName: " + LastName);
                Console.WriteLine("Employee' Number: " + Number);
                Console.WriteLine("Employee' Department: " + Department);


            }

        }

    }

}
