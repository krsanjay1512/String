using System;

namespace Find2ndHighestFreqInString
{
    class Program
    {
               
        static void Main(string[] args)
        {
            string input = "hgffsdghfdshgg";
            int first = 0, second = 0;
            int[] arr = new int[256];

            for (int i = 0; i < input.Length; i++)
            {
                arr[input[i]]++;
            }

            for (int i = 0; i < 256; i++)
            {
                if (arr[i] > arr[first])
                {
                    second = first;
                    first = i;
                }
                else if (arr[i] > arr[second] && arr[i] != arr[first])
                {
                    second = i;

                }

            }
            Console.WriteLine((char)second);
            Console.ReadLine();
        }
    }
}
