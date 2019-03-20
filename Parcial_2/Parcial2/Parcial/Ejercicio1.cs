using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Ejercicio1
    {
        public void Ejer1()
        {
            int n1, n2, pro = 0;

            Console.WriteLine("Digite un nùmero entero: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 == 0)
            {
                Console.WriteLine("El prodcuto de 0 por cualquier nùmero es 0");
            }
            else
                if (n1 != 0)
                {
                    Console.WriteLine("Digite el segundo nùmero entero: ");
                    n2 = int.Parse(Console.ReadLine());
                    pro = n1 * n2;
                    Console.WriteLine("El producto es: " + pro);
                    
                }
            Console.ReadKey();            
        }
    }
}
