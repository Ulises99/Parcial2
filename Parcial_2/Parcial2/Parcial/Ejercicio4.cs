using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Ejercicio4
    {
        public void Ejer4()
        {
            int i=0, a=0;

            int[] Vector = new int[5];

            do
            {
                Console.WriteLine("Ingrese la edad "+i+" :");
                Vector[i] = int.Parse(Console.ReadLine());
                i++;
            }
            while (i < 5);

            Console.WriteLine("***LAS EDADES SON***");
            do
            {
                
                Console.WriteLine(Vector[a]);
                a++;
            }
            while (a < 5);

            Console.ReadKey();
        }

    }
}
