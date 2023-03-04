using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08___Maxima_y_menor_temperatura_2
{
    internal class Ejercicio08
    {
        static void Main()
        {
            // 8. Ingresar temperaturas mientras el promedio sea menor que 20 grados, y mostrar la menor y la mayor.

            bool registrar = true;
            int registro = 0;
            float tempMaxima = 0, tempMinima = 0, acumTemperatura = 0;
            float promedioTemperatura = 0;

            while (registrar)
            {
                Console.Write($"{++registro}. Ingrese la temperatura ({Math.Round(promedioTemperatura, 1)}): ");
                float temperatura = float.Parse(Console.ReadLine());

                if (registro == 1)
                {
                    tempMaxima = temperatura;
                    tempMinima = temperatura;
                }

                acumTemperatura += temperatura;
                promedioTemperatura = (acumTemperatura / registro);

                if (promedioTemperatura < 20)
                {
                    if (temperatura > tempMaxima)
                    {
                        tempMaxima = temperatura;
                    }

                    if (temperatura < tempMinima)
                    {
                        tempMinima = temperatura;
                    }
                }
                else
                {
                    if (temperatura > tempMaxima)
                    {
                        tempMaxima = temperatura;
                    }

                    registrar = false;
                }
            }

            Console.WriteLine($"\nTemperatura máxima registrada: {tempMaxima}");
            Console.WriteLine($"Temperatura mínima registrada: {tempMinima}");
        }
    }
}
