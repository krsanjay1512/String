using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string for count space:");
            string str = Console.ReadLine();
            int count = 0;
            for (int i=0;i<str.Length;i++)
            {
                if (str[i]==' ')
                {
                    count++;
                }
            }
            Console.WriteLine( count);
            Console.ReadLine();
        }
    }

}
