using System;

namespace For40
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (!(a < b))
            {
                Console.WriteLine("Error: A >= B");
                return;
            }

            int x = 1;

            for(int i = a; i < b; i++)
            {
                for (int d = 0; d < x; d++) Console.WriteLine(i);
                x++;
            }
        }
    }
}
