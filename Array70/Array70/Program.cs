using System;
using System.Collections.Generic;

namespace Array70
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> a = new List<int>();
			var rand = new Random(new Random().Next(-10, 10));
			int n = Convert.ToInt32(Console.ReadLine());
			if (n % 2 == 1)
			{
				Console.WriteLine("Error: n not %2==0");
				return;
			}
			for (int i = 0; i < n; i++)
			{
				a.Add(rand.Next(-100000, 100000));
			}
			for(int i = 0; i < a.Count / 2; i++)
			{
				int tmp = a[i];
				int tmp2 = a[a.Count/2+i];
				a[i] = tmp2;
				a[a.Count / 2 + i] = tmp;
			}
			foreach (int i in a) Console.WriteLine(i);
		}
	}
}
