using System;
using System.Collections.Generic;

namespace Array54
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> a = new List<int>();
			int n = Convert.ToInt32(Console.ReadLine());
			var rand = new Random(new Random().Next(-10, 10));
			for (int i = 0; i < n; i++)
			{
				a.Add(rand.Next(-100000, 100000));
			}

			List<int> b = new List<int>();
			foreach(int i in a)
			{
				if (i % 2 == 0) b.Add(i);
			}
			Console.WriteLine(b.Count);
			foreach (int i in b) Console.WriteLine(i);
		}
	}
}
