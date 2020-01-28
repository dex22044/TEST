using System;
using Primitives;

namespace Test18
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(3);
            c.add(5);
            Cons.WriteLine(Convert.ToString(c.getCount()));
        }
    }
}
