namespace typeConversions 
{
    public class Program 
    {
        static void Main(string [] args) 
        {
            // Implicit Conversion (Bilinçsiz Dönüşümler)
            Console.WriteLine("*****Implicit Conversion (Bilinçsiz Dönüşümler)*****");
            byte b = 5;
            sbyte sb = 30;
            short s = 10;

            int total = b + sb + s;
            Console.WriteLine("total = " + total);

            long l = total;
            Console.WriteLine("l = " + l);

            float f = l;
            Console.WriteLine("f = " + f);

            string ss = "betul";
            char ch = 'k';
            object g = ss + ch + total;
            Console.WriteLine("object:"+ g);



            // Explicit Conversion (Bilinçli Dönüşümler)
            Console.WriteLine("*****Explicit Conversion (Bilinçli Dönüşümler)*****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y=" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t=" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v=" + v);

            // *****ToString Method*****
            Console.WriteLine("*****ToString Method*****");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy=" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz=" + zz);

            // System.Convert Class
            Console.WriteLine("*****System.Convert Class*****");
            string s1="10", s2="20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam =" + toplam);


            // Parse Method
            Console.WriteLine("*****Parse Method*****");
            ParseMethod();


        }

        public static void ParseMethod() 
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1: " + rakam1);

           
            double1 = Double.Parse(metin2);
            Console.WriteLine("double1: " + double1);
        }
    }
}
