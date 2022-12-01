using System;

namespace methods {
    public class Program {

        static void Main(string[] args) {

            // structure of a method
            // erişim_belirteci geri_dönüşümtipi method_adı(parametre listesi/arguman) { Komutlar; return; }

            Methods methods = new Methods();

            int a = 2;
            int b = 3;

            // CallByValue
            int sum = methods.Summation(a,b);
            methods.Display(sum.ToString());

            // CallByReference
            int sum2 =  methods.IncreaseByOneToSum(ref a, ref b);
            methods.Display(sum2.ToString());
            methods.Display((a+b).ToString());
        }
    }


    public class Methods {

        public int Summation(int x, int y) {                 
            return x+y;
        }

        public void Display(string data) {
            Console.WriteLine(data); 
        }
        
        public int IncreaseByOneToSum(ref int x, ref int y) {
            x+=1;
            y+=1;
            return x+y;

        }
    }
}
