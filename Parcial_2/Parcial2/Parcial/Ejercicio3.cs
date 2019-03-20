using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Ejercicio3
    {
        public void Ejer3()
        {
           

            string[] Vector = new string[5];

            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Digite el nombre "+i+" :");
                Vector[i] = Console.ReadLine();
            }

            Console.WriteLine("***LOS DATOS SON***");
            for (int a = 0; a < 5; a++)
            {
                
                Console.WriteLine(Vector[a]);
                
            }
            Console.ReadKey();
        }
    }
}
