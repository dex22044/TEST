using System;

namespace Series4
{
    class Program
    {
        static void Main(string[] args)
        {
            int res1 = 0,res2 = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x= Convert.ToInt32(Console.ReadLine());
                res1 += x;
                res2 *= x;
            }
            Console.WriteLine(res1);
            Console.WriteLine(res2
                );
        }
    }
}
