using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Your Name");
            string name = Console.ReadLine();
            bool isIncludeA = false;

            for (int i = 0; i < name.Length; i++)
            {
                char a = name[i];
                if(a == 'a')
                {
                    isIncludeA = true;
                }
                
            }

            Console.WriteLine(isIncludeA);
        }
    }
}
