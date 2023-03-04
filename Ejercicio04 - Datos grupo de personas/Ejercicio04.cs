using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04___Datos_grupo_de_personas
{
    internal class Ejercicio04
    {
        static void Main(string[] args)
        {
            /* 
                4. Calcular el promedio de edad de un grupo de personas e indicar cuántas son mayores de 18 años.
                   El algoritmo cierra el grupo cuando hay 5 menores. 
            */

            int contadorMenores = 0, contadorMayores = 0, persona = 0, acumuladorEdad = 0;

            while (contadorMenores < 5)
            {
                persona++;
                Console.Write($"{persona}. Ingrese la edad de la persona: ");
                int edadPersona = int.Parse(Console.ReadLine());

                acumuladorEdad += edadPersona;

                if (edadPersona < 18)
                {
                    contadorMenores++;
                }
                else
                {
                    contadorMayores++;
                }

            }

            float promedioEdad = acumuladorEdad / (float)persona;

            Console.WriteLine($"\nPromedio de edad del grupo: {Math.Round(promedioEdad, 1)}");
            Console.WriteLine($"Cantidad de personas mayores de edad: {contadorMayores}");
        }
    }
}
