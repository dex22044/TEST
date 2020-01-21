using System;

namespace While21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool result=false;
            int numberNum = 1, numC = 1;
            double res=1;
            while (res >= 1)
            {
                res = n / Math.Pow(10,numC);
                numC++;
            }
            while (numberNum < numC && !result)
            {
                int num = (int)(n % Math.Pow(10, numberNum)/ Math.Pow(10, numberNum-1));
                if ((num % 2) == 1) result = true;
                numberNum++;
            }
            if (result) Console.WriteLine("TRUE");
            else Console.WriteLine("FALSE");
        }
    }
}
