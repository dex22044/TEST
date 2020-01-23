using System;
using System.Collections.Generic;

namespace Array4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            List<int> arr = new List<int>();

            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                arr.Add(rand.Next(-10000,10000));
            }

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] % 2 == 0) Console.WriteLine(arr[i]);
            }
            for (int i = arr.Count-1; i >= 0; i--)
            {
                if (arr[i] % 2 != 0) Console.WriteLine(arr[i]);
            }
        }
    }
}
