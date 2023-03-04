using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06___Peso_acumulado_2
{
    internal class Ejercicio06
    {
        static void Main(string[] args)
        {
            /* 
                6. Hacer un algoritmo que muestre el peso acumulado de un grupo de personas e indique la cantidad de
                   éstas. El grupo nunca debe superar los 500 kg. (Si al ingresar una nueva persona al grupo se superan
                   los 500 kg, se descarta a la persona y se cierra el grupo).
            */

            bool registrar = true;
            float pesoAcumulado = 0;
            int personas = 1;


            while (registrar)
            {

                Console.Write($"{personas}. Ingrese el peso de la persona (kg): ");
                float pesoPersona = float.Parse(Console.ReadLine());

                if ((pesoAcumulado + pesoPersona) <= 500)
                {
                    personas++;
                    pesoAcumulado += pesoPersona;
                }
                else
                {
                    registrar = false;
                }
            }

            Console.WriteLine($"\nCantidad de personas: {personas - 1}");
            Console.WriteLine($"Peso acumulado: {pesoAcumulado} kg.");
        }
    }
}
