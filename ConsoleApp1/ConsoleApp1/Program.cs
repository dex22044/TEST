using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList mas = new ArrayList();

            mas.Add("A");
            mas.Add(10);
            mas.Add(10.2147316783462734631746123);
            mas.Add(new object());
            
            foreach(object o in mas)
            {
                Console.WriteLine(o.GetType()+"\t"+o);
            }

            List<string> mas2=new List<string>() { "2 пакетика травы", "AAAAAA" };

            foreach (object o in mas2)
            {
                Console.WriteLine(o.GetType() + "\t" + o);
            }

            List<string> mas3 = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (!input.Equals("END"))
                {
                    mas3.Add(input);
                }
                else break;
            }

            foreach (object o in mas3)
            {
                Console.WriteLine(o.GetType() + "\t" + o);
            }
        }
    }
}
