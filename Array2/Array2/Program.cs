using System;
using System.Collections.Generic;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int64> powers = new List<Int64>();

            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                powers.Add((Int64)Math.Pow(2, i));
            }

            foreach(Int64 num in powers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
