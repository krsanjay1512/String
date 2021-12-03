using System;

namespace ConsoleApp1
{
    public class DeleteAllNumericValue
    {
        public static void Main(string[] args)
        {
            String s = "San3241jay";
            String t = "";
            for (int i=0;i<s.Length;i++)
            {
                if (!(s[i]>='0' && s[i]<='9'))
                {
                    t = t + s[i];
                }
            }
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }

}
