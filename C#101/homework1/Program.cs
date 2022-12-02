using System;

namespace homework1 {
    public class Program {

        static void Main(string[] args) 
        {
            /* PART 1:
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. 
            */
            Console.WriteLine("Please enter a positive number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Please enter {n1} positive numbers: ");
            List<int> numbers = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(value => Convert.ToInt32(value)).ToList();
            
            for(int i=0; i<n1; i++) 
            {
                if (numbers[i]%2 == 0)
                    Console.WriteLine(numbers[i]);
            }


            /* PART 2:
            Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.            
            */
            Console.WriteLine("Please enter two positive numbers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Please enter {n} positive numbers: ");
            List<int> numbers2 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(value => Convert.ToInt32(value)).ToList();
            
            for(int i=0; i<n; i++) 
            {
                if (numbers2[i]%m == 0 || numbers2[i] == m)
                    Console.WriteLine(numbers2[i]);
            }

            /* PART 3:
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.            
            */
            Console.WriteLine("Please enter a positive number: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Please enter {n3} words: ");
            List<string> wordList = Console.ReadLine().TrimEnd().Split(' ').ToList();
            wordList.Reverse();

            foreach (var item in wordList) 
            {
                Console.WriteLine(item);
            }      

            /* PART 4:
            Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            Cümledeki toplam kelime ve harf sayısını console'a yazdırın.            
            */
             Console.WriteLine("Please enter a sentence: ");
             string sentence = Console.ReadLine();
             string[] words = sentence.Split(" ");
             int numberOfWords = words.Count();
             int numberOfCharacter = sentence.Replace(" ", "").ToCharArray().Count();
             Console.WriteLine($"NumberOfWords: {numberOfWords} & NumberOfCharacter: {numberOfCharacter} in the sentence.");

             
        }
    }
}
