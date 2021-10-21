using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "google";
            Dictionary<char, int> dict = new Dictionary<char,int>();
            foreach (var chars in s)
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
