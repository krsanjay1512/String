using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string :");
            string input =Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char,int>();
            foreach (var chars in input)
            {
                if (!dict.ContainsKey(chars)) {
                    dict.Add(chars,1);
                }
                else
                {
                    dict[chars]++;
                }
            }
            foreach (var data in dict) {
                Console.WriteLine("{0}-{1}",data.Key,data.Value);
            }


            
            Console.ReadLine();
        }
    }

}
