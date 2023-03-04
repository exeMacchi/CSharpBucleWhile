using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11___Datos_hasta_que_la_suma_sea_1000
{
    internal class Ejercicio11
    {
        static void Main()
        {
            /* 
                11. Se ingresan números hasta que la suma alcance los 1.000. Hallar:
                        a. La cantidad de números negativos.
                        b. La suma de los números que se encuentran entre el 1 y el 10 (incluidos).
                        c. El promedio de los mayores a 10. 
            */

            bool registrar = true;
            int acumulado = 0, contadorNegativos = 0, sumaPB = 0, acumPC = 0;
            uint registro = 0, contadorPC = 0;

            while (registrar)
            {
                Console.Write($"{++registro}. Ingrese un número ({acumulado}): ");
                int numero = int.Parse(Console.ReadLine());

                if ( (numero + acumulado) <= 1000)
                {
                    acumulado += numero;

                    if (numero < 0)
                    {
                        contadorNegativos++;
                    }
                    else if (numero >= 1 && numero <= 10)
                    {
                        sumaPB += numero;
                    }
                    else if (numero > 10)
                    {
                        acumPC += numero;
                        contadorPC++;
                    }
                }
                else
                {
                    registrar = false;
                }
            }

            float promedioPC = acumPC / (float)contadorPC;

            Console.WriteLine($"\na. Cantidad de números negativos: {contadorNegativos}");
            Console.WriteLine($"b. Suma de los números entre 1 y 10: {sumaPB}");
            Console.WriteLine($"c. Promedio mayores a 10: {Math.Round(promedioPC, 2)}");
        }
    }
}
