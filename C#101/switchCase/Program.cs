using System;

namespace switchCase {
    public class Program {
        static void Main(string[] args) 
        {
            int month = DateTime.Now.Month;

            // Expression
            switch (month)   
            {
                case 1:
                    Console.WriteLine("In January");
                    break;
                case 2:
                    Console.WriteLine("In February");
                    break;
                case 4:
                    Console.WriteLine("In April");
                    break;  
                case 3:
                    Console.WriteLine("In March");
                    break;       
                default:
                    Console.WriteLine("Wrong data!");
                break;
            }


            switch(month) 
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("The Winter is coming!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("It is Spring!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer Party!");
                    break;  
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("It is Autumn!");
                    break;                 
                default:
                    break;
            }

        }
    }
}
