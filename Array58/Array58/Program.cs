using System;
using System.Collections.Generic;

namespace Array58
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> a = new List<int>();
			List<int> b = new List<int>();
			int n = Convert.ToInt32(Console.ReadLine());
			var rand = new Random(new Random().Next(-10, 10));
			for (int i = 0; i < n; i++)
			{
				a.Add(rand.Next(-100000, 100000));
			}

			for(int i = 0; i < n; i++)
			{
				int temp = 0;
				for (int j = 0; j < i; j++) temp += a[j];
				b.Add(temp);
			}

			foreach (int i in b) Console.WriteLine(i);
		}
	}
}
