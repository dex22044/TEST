using System;

namespace If22
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if (x == 0 || y == 0){
                Console.WriteLine("X or Y equals 0"); return;
            }

            if (x > 0 && y > 0) Console.WriteLine("2");
            else if (x < 0 && y > 0) Console.WriteLine("1");
            else if (x > 0 && y < 0) Console.WriteLine("3");
            else if (x < 0 && y < 0) Console.WriteLine("4");
        }
    }
}
