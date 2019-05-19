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

            song = song.Replace("a", vowel);
            song = song.Replace("á", vowel);
            song = song.Replace("â", vowel);
            song = song.Replace("ã", vowel);
            song = song.Replace("à", vowel);
            song = song.Replace("e", vowel);
            song = song.Replace("é", vowel);
            song = song.Replace("ê", vowel);
            song = song.Replace("i", vowel);
            song = song.Replace("í", vowel);
            song = song.Replace("î", vowel);
            song = song.Replace("o", vowel);
            song = song.Replace("ó", vowel);
            song = song.Replace("ô", vowel);
            song = song.Replace("u", vowel);
            song = song.Replace("ú", vowel);
            song = song.Replace("û", vowel);
            
            Console.WriteLine(song);
        }
    }
}
