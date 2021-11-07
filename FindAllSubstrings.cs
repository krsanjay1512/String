using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
             Console.WriteLine("Enter the string :");
            string word = Console.ReadLine();

            for (int i = 1; i < word.Length; i++)
            {
                for (int j = 0; j <= word.Length - i; j++)
                {
                    Console.WriteLine(word.Substring(j, i));
                }
            }
            Console.ReadKey();

        }
    }

}
