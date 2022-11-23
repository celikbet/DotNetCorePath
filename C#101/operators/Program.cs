// See https://aka.ms/new-console-template for more information
namespace operators
{
    public class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("***** Atama ve İşlemli Atama *****");

            int x = 3;
            int y = 3;

            y = y+2;
            Console.WriteLine("y+2 :", y);

            y += 2;
            Console.WriteLine("y+=2 : ", y);

            y /= 1;
            Console.WriteLine("y/=2 : ", y);

            x *= 2;
            Console.WriteLine("x *=2 : ", x);

            Console.WriteLine("***** Mantıksal Operatörler *****");
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted) 
                Console.WriteLine("Perfect!");


            if (isSuccess || isCompleted) 
                Console.WriteLine("Great!");

            if (isSuccess && !isCompleted) 
                Console.WriteLine("Fine!");


            Console.WriteLine("***** İlişkisel Operatörler (>, <, <=, >=, ==, !=) *****");
            int a = 3;
            int b = 4;
            bool result;

            result = a<b;
            Console.WriteLine(result);

            result = a>b;
            Console.WriteLine(result);

            result = a>=b;
            Console.WriteLine(result);

            result = a<=b;
            Console.WriteLine(result); 

            result = a==b;
            Console.WriteLine(result); 

            result = a!=b;
            Console.WriteLine(result); 


            Console.WriteLine("***** Aritmatik Operatörler (/, *, +, -, %) ***** ");
            int value1 = 10;
            int value2 = 5;
            int resultValue;
            
            resultValue = value1/value2;
            Console.WriteLine(resultValue); 

            resultValue = value1*value2;
            Console.WriteLine(resultValue); 

            resultValue = value1+value2;
            Console.WriteLine(resultValue);             

            resultValue = ++value1;
            Console.WriteLine(resultValue);            

            resultValue = 20 % 3;
            Console.WriteLine(resultValue);   


        }

    }
}
