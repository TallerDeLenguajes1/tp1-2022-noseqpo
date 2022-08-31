using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    internal class PuntoDos
    {
        public static void ProblemaUno()
        {
            string temp;

            Console.WriteLine("Ingrese un numero entero");
            temp = Console.ReadLine();

            try
            {
                int numero = Int32.Parse(temp);

                Console.WriteLine("El cuadrado de {0} es {1}", numero, Math.Pow(numero, 2));
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void ProblemaDos()
        {
            string temp;
            string temp2;

            Console.WriteLine("Ingrese dividendo:");
            temp = Console.ReadLine();
            Console.WriteLine("Ingrese divisor:");
            temp2 = Console.ReadLine();

            try
            {
                int divd = Int32.Parse(temp);
                int divs = Int32.Parse(temp2);

                Console.WriteLine("La division es: " + divd/divs);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
