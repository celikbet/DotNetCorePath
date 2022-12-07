using System;

namespace classEncapsulationProperty {

    public class Program {

        static void Main(string[] args) 
        {
            Student studentOne = new Student();
            studentOne.StudentName = "nameOne";
            studentOne.StudentLastName = "lastNameOne";
            studentOne.StudentNumber = 101;
            studentOne.ClassNumber = 1;
            studentOne.StudentInformation();
            studentOne.IncreaseClassLevel();

            Student studentTwo = new Student("nameTwo", "lastNameTwo", 102, 1);
            studentTwo.DecreaseClassLevel();
            studentTwo.DecreaseClassLevel();
            studentTwo.StudentInformation();

        }
    }

    class Student
    {
        private string studentName;
        private string studentLastName;
        private int studentNumber;
        private int classNumber;

        // create public property of private ones
        public string StudentName 
        { 
            get { return studentName; }
            set { studentName = value; } 
        }

        public string StudentLastName { get => studentLastName; set => studentLastName = value; }
        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public int ClassNumber 
        { 
            get => classNumber; 
            set 
            {
                if (value < 1) 
                {
                    Console.WriteLine("The lowest Class Number must be 1!");
                    classNumber = 1;
                } 
                else 
                {
                    classNumber = value;
                }
            } 
        }

        // create constructor method of Student Class with properties
        public Student(string studentName, string studentLastName, int studentNumber, int classNumber)
        {
            StudentName = studentName;
            StudentLastName = studentLastName;
            StudentNumber = studentNumber;
            ClassNumber = classNumber;
        }

        // create constructor method of Student Class without properties
        public Student() {}

        public void StudentInformation() 
        {
            Console.WriteLine("****** Student Information ******");
            Console.WriteLine("Student Name: {0}", this.StudentName);
            Console.WriteLine("Student Name: {0}", this.StudentLastName);
            Console.WriteLine("Student Name: {0}", this.StudentNumber);
            Console.WriteLine("Student Name: {0}", this.ClassNumber);
        }

        public void IncreaseClassLevel() 
        {
            this.ClassNumber = this.classNumber + 1;
        }

        public void DecreaseClassLevel() 
        {
            this.ClassNumber = this.classNumber - 1;        
        }
    }
}
