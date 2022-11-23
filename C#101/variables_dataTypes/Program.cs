// See https://aka.ms/new-console-template for more information
namespace variables 
{
    public class Program 
    {
        public static void Main (string[] args) 
        {
            byte b = 5; //1 byte
            sbyte sb = 5; //1 byte

            short s = 5; //2 byte
            ushort us = 5; //2 byte
            Int16 i16 = 2; //2 byte
            int i = 2; //4 byte
            uint ui = 2;  //4 byte
            Int32 i32 = 2;  //4 byte
            Int64 i64 = 2;  //8 byte
            long l = 5; //8 byte
            ulong ul = 5; //8 byte
            float f = 6; //4 byte
            double dValue = 4.5; // 8 byte
            decimal deValue = 4.5M; // 16 byte


            char ch = 'a'; // 2 byte
            string st = "string"; // sınırsız

            bool notFalse = true;
            bool notTrue = false;

            DateTime datetime = DateTime.Now;
            Console.WriteLine(datetime);

            // Object examples:
            object ob1 = "x"; 
            object ob2 = 'y';
            object ob3 = 2;
            object ob4 = 4.2;

            // String examples:
            string str1 = string.Empty;
            str1 = "string";
            string name = "betul";
            string surname = "celik cetin";
            string fullname = name + " " + surname;

            // Integer examples:
            int integer1 = 5;
            int integer2 = 4;
            int integer3 = integer1 * integer2;

            // Boolean examples:
            bool bb = 10>1;

            // Variable Conversions:
            string str20 = "20";
            int int30 = 30;
            string newValue =  str20 + int30.ToString();
            Console.WriteLine(newValue);

            int newInteger = int30 + Convert.ToInt32(str20);
            Console.WriteLine(newInteger);

            int anotherInteger = int30 + int.Parse(str20);
            Console.WriteLine(anotherInteger);

            string date = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(date);

            string anotherDate = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(anotherDate);

            string time = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(time);

        }
    }
}
