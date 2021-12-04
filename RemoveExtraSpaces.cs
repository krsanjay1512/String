using System;
namespace ConsoleApp1
{
    public class DeleteAllNumericValue
    {
        public static void Main(string[] args)
        {
            String s = "Sanjay    How     are you";
            String t = "";
            for (int i=0;i<s.Length;i++)
            {
                if (!(s[i]==' '))
                {
                    t = t + s[i];
                }
                else if (s[i]==' ' && s[i+1]!=' ')
                {
                    t = t + " ";
                }
            }
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }

}
