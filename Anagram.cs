using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {

         public static bool IsAnagram(string str1,string str2)
        {
            var s1 = str1.ToLower().ToCharArray();
            var s2 = str2.ToLower().ToCharArray();
            Array.Sort(s1);
            Array.Sort(s2);

            return new string(s1)== new string(s2);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string :");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter 1st string :");
            string str2 = Console.ReadLine();
            Console.WriteLine(IsAnagram(str1,str2));
            Console.ReadLine();


        }
    }

}
