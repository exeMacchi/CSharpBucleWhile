using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10___Promedio_temperaturas_2
{
    internal class Ejercicio10
    {
        static void Main()
        {
            /* 
                10. Se ingresan pares de temperaturas (T1 y T2) hasta que T1 sea cero. Hallar el promedio de las
                    temperaturas que están entre 5° y 15° (incluidos). 
            */

            bool registrar = true;
            uint registro = 0, registroT1 = 0, registroT2 = 0;
            float acumT1 = 0, acumT2 = 0;

            while (registrar)
            {
                Console.Write($"{++registro}. Ingrese la temperatura (T1): ");
                float temperaturaT1 = float.Parse(Console.ReadLine());

                if (temperaturaT1 != 0)
                {
                    Console.Write($"{registro}. Ingrese la temperatura (T2): ");
                    float temperaturaT2 = float.Parse(Console.ReadLine());
                    Console.WriteLine();


                    if (temperaturaT1 >= 5 && temperaturaT1 <= 15)
                    {
                        acumT1 += temperaturaT1;
                        registroT1++;
                    }
                    if (temperaturaT2 >= 5 && temperaturaT2 <= 15)
                    {
                        acumT2 += temperaturaT2;
                        registroT2++;
                    }
                }
                else
                {
                    registrar = false;
                }
            }

            float promedioT1 = acumT1 / registroT1;
            float promedioT2 = acumT2 / registroT2;

            Console.WriteLine($"\nPromedio temperatura T1: {Math.Round(promedioT1, 1)}ºC");
            Console.WriteLine($"Promedio temperatura T2: {Math.Round(promedioT2, 1)}ºC");
        }
    }
}
