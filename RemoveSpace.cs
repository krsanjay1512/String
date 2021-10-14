using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string :");
            string s = Console.ReadLine();
            string t = "";
            for (int i=0;i<s.Length;i++)
            {
                if (s[i]!=' ')
                {
                    t = t + s[i];
                }
            }
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }

}
