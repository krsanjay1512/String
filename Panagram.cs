using System;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string :");
            string input = Console.ReadLine();
            string alpha = "asdfghjklzxcvbnmqwertyuiop";
            string result = "panagram";
            for (int i=0;i<alpha.Length;i++)
            {
                if (!input.ToLower().Contains(alpha[i]))
                {
                    result="Not Panagram";
                    break;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

}
