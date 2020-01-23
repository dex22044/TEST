using System;
using System.Collections.Generic;

namespace Array20
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, l, n;
            List<double> arr = new List<double>();
            var rand = new Random(new Random().Next(-10,10));
            k = Convert.ToInt32(Console.ReadLine());
            l = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            if(!(1<=k && k<=l && l <= n))
            {
                Console.WriteLine("Error: non 1<=K<=L<=N");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                arr.Add(rand.Next(-100000,100000)/100.0);
            }

            double sum=0;

            for (int i = k; i <= l; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);
        }
    }
}
