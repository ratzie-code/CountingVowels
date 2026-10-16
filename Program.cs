using System;

namespace Count_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            int vowelCount = CountVowels(input);
            Console.WriteLine($"Number of vowels in the string: {vowelCount}");
        }

        static int CountVowels(string str)
        {
            int count = 0;
            {
                if ("aeiou".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
