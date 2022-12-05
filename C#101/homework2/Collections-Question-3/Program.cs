using System;

namespace CollectionsQuestion3 {

    public class Program {

        static void Main(string[] args) 
        {
            string sentence = Console.ReadLine();
            char[] vowels = SearhForVowels(sentence);
            DisplayEachCharacter(vowels); 

        }

        static char[] SearhForVowels(string data) 
        {
            char[] vowelCharacters = new char[]{'a', 'e', 'i', 'o', 'u'};
            char[] vowels = new char[]{};
                     
            for(int i=0; i<vowelCharacters.Length; i++) 
            {
                if(data.ToLower().Contains(vowelCharacters[i])) 
                {
                    Array.Resize(ref vowels, i+1);
                    vowels[i] = vowelCharacters[i];
                }
            }

            return vowels;
        }

        static void DisplayEachCharacter(char[] characters) 
        {
            foreach(char item in characters) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
