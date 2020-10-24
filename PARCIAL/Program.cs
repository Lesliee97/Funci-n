using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial
{
    class Program
    {

        public static int Primo(int mostrar_p)
        {
            int n, d;
            int primo;

            n = 2;
            while (mostrar_p > 0)
            {

               
                primo = 1;
                for (d = 2; d < n; ++d)
                {
                    if (n % d == 0)
                    {
                        primo = 0;
                       
                    }
                }

              
                if (primo != 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Los números primos son: {0}", n);
                    mostrar_p--;
                }
                n++;
            }

            Console.WriteLine("\n");
            return n;

        }
        static void Main(string[] args)
        {
            int n, np;

            Console.WriteLine("Ingrese un número :");
            n = int.Parse(Console.ReadLine());
            Primo(n);
            //Console.WriteLine(np);
            Console.ReadKey();
        }
    }
}