using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial
{
    class Program
    {

        public static int Fibonacci(int n)
        {
            int x = 0, y = 1, z;
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)

                    Console.WriteLine(x);
                else
                {
                    if (i == 2)

                        Console.WriteLine(y);


                    else
                    {
                        z = x + y;
                        Console.WriteLine(z);
                        x = y;
                        y = z;
                    }
                }
            }
            return n;
        }

        public static void Main(string[] args)
        {

            int n;
            Console.Write("INGRESE NÚMERO N :");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("LOS NÚMEROS FIBONACCI SON :");
            Fibonacci(n);
            // Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
