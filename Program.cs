using System;

namespace anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Enter the first phrase>");
            string phrase1 = Console.ReadLine().ToUpper().Replace(" ", "");
            //2
            Console.WriteLine("Enter the second phrase>");
            string phrase2 = Console.ReadLine().ToUpper().Replace(" ", "");

            // convert
            char[] phrase1Chars = phrase1.ToCharArray();
            char[] phrase2Chars = phrase2.ToCharArray();

            // Sort
            Array.Sort(phrase1Chars);
            Array.Sort(phrase2Chars);

            // equal?
            bool areAnagrams = true;
            if (phrase1Chars.Length != phrase2Chars.Length)
            {
                areAnagrams = false;
            }
            else
            {
                for (int i = 0; i < phrase1Chars.Length; i++)
                {
                    if (phrase1Chars[i] != phrase2Chars[i])
                    {
                        areAnagrams = false;
                        break;
                    }
                }
            }

            // final
            if (areAnagrams)
            {
                Console.WriteLine("Is an anagram");
            }
            else
            {
                Console.WriteLine("Is not an anagram.");
            }
        }
    }
}

