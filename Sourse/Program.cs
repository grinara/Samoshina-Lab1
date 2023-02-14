using System;
namespace Sourse
{
     class Program
    {
        static void Main()
        {
            Console.Write("число - ");
            var num = Int64.Parse(Console.ReadLine());
            Console.Write("степень - ");
            var step = Int64.Parse(Console.ReadLine());
            int s = 1, s1 = 0;
            for(int i = 1; i <= step; i++)
            {
                for(int j = 1; j <= num; j++)
                {
                    s1 = s1 + s;
                }
                s = s1;
                s1 = 0;
            }
            Console.Write(s);
        }
    }
}