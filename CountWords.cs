using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The String :");
            string str = Console.ReadLine();
            int count = 0;
            for (int i=0;i<str.Length;i++)
            {
                if (str[i]==' ')
                {
                    count++;
                }
            }
            Console.WriteLine( count+1);
            Console.ReadLine();
        }
    }

}
