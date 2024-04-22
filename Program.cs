using System;

namespace Vowelizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the sentence you want to vowelize: ");
            string song = Console.ReadLine();

            Console.Write("What is the vowel you want? ");
            string vowel = Console.ReadLine();
            string[] characters = { "a", "á", "â", "ã", "à", "e", "é", "ê", "i", "í", "î", "o", "ó", "ô", "u", "ú", "û" };
            
            foreach (string character in characters)
            {
                 Console.WriteLine(song.Replace(character, vowel));
            }            
        }
    }
}
