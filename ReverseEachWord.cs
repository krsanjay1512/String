namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The String :");
            string input = Console.ReadLine();
            string[] ar = input.Split(' ');
            string str = "";
            foreach (string words in ar)
            {
                string str1 = "";
                for (int i = words.Length-1; i >= 0; i--)
                {
                    str1 = str1 + words[i];
                }
                str = str + str1 + " ";
            }
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }

}
