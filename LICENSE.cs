using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] frr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                frr[i] = r.Next(10);
                Console.Write(frr[i] + " ");
            }
            Console.WriteLine();
            int min = frr[0];
            for (int i = 0; i < 10; i++)
            {
                if (frr[i] < min) min = frr[i];
            }
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
