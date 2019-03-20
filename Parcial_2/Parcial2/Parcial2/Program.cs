using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial;

namespace Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite un nùmero de 1 a 4");
            n = int.Parse(Console.ReadLine());

            switch(n)
            {
                case 1:
                    Console.WriteLine("***EJERCICIO 1***");
                    Ejercicio1 ej1 = new Ejercicio1();
                    ej1.Ejer1();
                    break;

                case 2:
                    Console.WriteLine("***EJERCICIO 2***");
                    Ejercicio2 ej2 = new Ejercicio2();
                    ej2.Ejer2();
                    break;

                case 3:
                    Console.WriteLine("***EJERCICIO 3***");
                    Ejercicio3 ej3 = new Ejercicio3();
                    ej3.Ejer3();
                    break;

                case 4:
                    Console.WriteLine("***EJERCICIO 4***");
                    Ejercicio4 ej4 = new Ejercicio4();
                    ej4.Ejer4();
                    break;

                default:
                    Console.WriteLine("***Nùmero invalido***");
                    Console.ReadKey();
                    break;


            }
        }
    }
}
