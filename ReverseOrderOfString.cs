using System;

namespace ConsoleApp
{
     class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Enter The String :");
            string s = Console.ReadLine();
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    count++;
                }
                else
                {
                    for (int j = i + 1; count > 0; j++)
                    {
                        Console.Write(s[j]);
                        count--;
                    }
                       Console.Write(" ");
                }
              
            }
            for (int i = 0; i <= count; i++)
            {
                Console.Write(s[i]);
            }
            Console.ReadLine();
        }
    }
    
}
