using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Ejercicio2
    {
        public void Ejer2()
        {
            int n1, n2;
            double pro;

            Console.WriteLine("Digite el primer nùmero entero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo nùmero entero: ");
            n2 = int.Parse(Console.ReadLine());

            if(n2!=0)
            {
                pro = n1 / n2;
                Console.WriteLine("El resultado es: " + pro);
            }
            else
                if(n2==0)
                {
                    Console.WriteLine("Error: No se puede dividir entre cero");
                }

            Console.ReadKey();
        }
    }
}
