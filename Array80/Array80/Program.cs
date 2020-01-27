using System;
using System.Collections.Generic;

namespace Array80
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> a = new List<int>();
			var rand = new Random(new Random().Next(-10, 10));
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				a.Add(rand.Next(-100000, 100000));
			}

			for(int i = 0; i < n-1; i++)
			{
				a[i] = a[i + 1];
			}
			a[n-1] = 0;
			foreach (int i in a) Console.WriteLine(i);
		}
	}
}
