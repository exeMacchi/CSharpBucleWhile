using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___Datos_ruleta
{
    internal class Ejercicio03
    {
        static void Main(string[] args)
        {
            /* 
                3. Se ingresan 100 números de la ruleta (0,1,2,…,36), para hallar y mostrar lo siguiente:
                    a. Cantidad de números impares.
                    b. Promedio de los números pares (no contar los ceros).
                    c. Cantidad de números que se encuentran en la segunda docena (13 al 24).
                    d. El número más grande. 
            */

            Random random = new Random();

            int tirada = 1;
            int contadorPares = 0, contadorImpares = 0, acumuladorPares = 0, contadorSegDocena = 0, numeroMaximo = 0;

            while (tirada <= 100)
            {
                int numero = random.Next(0, 37);
                Console.Write(numero + " - ");

                if ((numero % 2) == 0)
                {
                    if (numero > 0)
                    {
                        acumuladorPares += numero;
                        contadorPares++;
                    }
                }
                else
                {
                    contadorImpares++;
                }

                if (numero >= 13 && numero <= 24)
                {
                    contadorSegDocena++;
                }

                if (tirada == 1)
                {
                    numeroMaximo = numero;
                }
                else if (numero > numeroMaximo)
                {
                    numeroMaximo = numero;
                }

                tirada++;
            }

            float promedioPares = acumuladorPares / (float)contadorPares;

            Console.WriteLine();
            Console.WriteLine($"a. Cantidad de números impares: {contadorImpares}");
            Console.WriteLine($"b. Promedio de números pares: {Math.Round(promedioPares, 1)}");
            Console.WriteLine($"c. Cantidad de números en la segunda docena: {contadorSegDocena}");
            Console.WriteLine($"d. Número más grande: {numeroMaximo}");
        }
    }
}
