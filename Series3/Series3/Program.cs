using System;

namespace Series3
{
    class Program
    {
            static void Main(string[] args)
            {
                int res = 0;
                for (int i = 0; i < 10; i++)
                {
                    res += Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(res / 10);
            }
    }
}
