using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05___Peso_acumulado_1
{
    internal class Ejercicio05
    {
        static void Main(string[] args)
        {
            /* 
                5. Hacer un algoritmo que muestre el peso acumulado de un grupo de personas e indique la cantidad de
                   éstas. El grupo se cierra cuando el peso acumulado supera los 500 kg. 
            */

            bool registrar = true;
            float pesoAcumulado = 0;
            int personas = 0;


            while (registrar)
            {
                personas++;
                Console.Write($"{personas}. Ingrese el peso de la persona (kg): ");
                float pesoPersona = float.Parse(Console.ReadLine());


                pesoAcumulado += pesoPersona;

                if (pesoAcumulado > 500)
                {
                    registrar = false;
                }
            }

            Console.WriteLine($"\nCantidad de personas: {personas}");
            Console.WriteLine($"Peso acumulado: {pesoAcumulado} kg.");
        }
    }
}
