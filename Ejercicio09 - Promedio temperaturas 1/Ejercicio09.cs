using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09___Promedio_temperaturas_1
{
    internal class Ejercicio09
    {
        static void Main()
        {
            /* 
                9. Se ingresan pares de temperaturas (T1 y T2). Hallar el promedio de las temperaturas T1 y el promedio
                   de las temperaturas T2 hasta que la suma del par ingresado sea mayor que 40 grados. 
            */

            bool registrar = true;
            uint registroT1 = 0, registroT2 = 0;
            float acumT1 = 0, acumT2 = 0, promedioT1 = 0, promedioT2 = 0;

            while (registrar)
            {
                Console.Write($"{++registroT1}. Ingrese la temperatura (T1) ({Math.Round(promedioT1, 1)}): ");
                float temperaturaT1 = float.Parse(Console.ReadLine());

                Console.Write($"{++registroT2}. Ingrese la temperatura (T2) ({Math.Round(promedioT2, 1)}): ");
                float temperaturaT2 = float.Parse(Console.ReadLine());

                acumT1 += temperaturaT1;
                acumT2 += temperaturaT2;
                promedioT1 = (acumT1 / registroT1);
                promedioT2 = (acumT2 / registroT2);

                if (promedioT1 + promedioT2 > 40)
                {
                    registrar = false;
                }
            }

            Console.WriteLine($"Promedio de temperatura T1: {promedioT1}");
            Console.WriteLine($"Promedio de temperatura T2: {promedioT2}");
        }
    }
}
