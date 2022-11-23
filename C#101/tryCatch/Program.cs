using System;

namespace errorManagement 
{
    public class Program 
    {
        static void Main(string [] args) 
        {

            try
            {
                //Console.WriteLine("Enter a number");
                //int number = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("This is the number you entered: " + number);

                //int a = int.Parse(null);
                //int a = int.Parse("test");  
                int a = int.Parse("99999999999");  
            }
            // catch(Exception ex)
            // {
            //     Console.WriteLine("Hata: " + ex.Message.ToString());
            // }            
            // catch(ArgumentNullException ex) 
            // {
            //     Console.WriteLine("You entered null value");
            //     Console.WriteLine(ex);
            // }
            // catch(FormatException ex) 
            // {
            //     Console.WriteLine("Data format is not correct!");
            //     Console.WriteLine(ex);
            // }            
            catch(OverflowException ex) 
            {
                Console.WriteLine("You entered too high or too small value!");
                Console.WriteLine(ex);
            }
            finally 
            {
                Console.WriteLine("Task is completed!");
            }
                            
        }
    }
}
