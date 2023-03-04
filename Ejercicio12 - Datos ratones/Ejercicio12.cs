using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12___Datos_ratones
{
    internal class Ejercicio12
    {
        static void Main()
        {
            /* 
                12. Se ingresan el peso y la edad de ratones hasta que aparezca un ratón cuya edad sea el doble que el
                promedio de los ya ingresados (debe ingresar al menos un ratón para calcular este promedio;
                este último ratón no debe ser tenido en cuenta para el cálculo). Mostrar:
                    a) la edad del ratón de mayor peso.
                    b) la edad del de menor peso.
                    c) el promedio de las edades. 
            */

            bool registrar = true;
            int registro = 0;
            float promedioEdades = 0, maxPeso = 0, menPeso = 0;
            int edadMayorPeso = 0, edadMenorPeso = 0, acumEdades = 0;

            while (registrar)
            {
                Console.WriteLine($"---------------------- Ratón {++registro} ----------------------");
                Console.Write("Edad: ");
                int edadRaton = int.Parse(Console.ReadLine());
                Console.Write("Peso: ");
                float pesoRaton = float.Parse(Console.ReadLine());

                if (registro == 1)
                {
                    promedioEdades = edadRaton;
                }
                else
                {
                    if (!(edadRaton >= (promedioEdades * 2)))
                    {
                        acumEdades += edadRaton;
                        promedioEdades = acumEdades / (registro - 1);

                        if (registro == 2)
                        {
                            edadMayorPeso = edadRaton;
                            maxPeso = pesoRaton;
                            edadMenorPeso = edadRaton;
                            menPeso = pesoRaton;
                        }
                        else
                        {
                            if (pesoRaton > maxPeso)
                            {
                                maxPeso = pesoRaton;
                                edadMayorPeso = edadRaton;
                            }
                            if (pesoRaton < menPeso)
                            {
                                menPeso = pesoRaton;
                                edadMenorPeso = edadRaton;
                            }
                        }
                    }
                    else
                    {
                        registrar = false;
                    }
                }
            }

            Console.WriteLine($"\nEdad ratón con mayor peso: {edadMayorPeso}");
            Console.WriteLine($"Edad ratón con menor peso: {edadMenorPeso}");
            Console.WriteLine($"Promedio de edades: {Math.Round(promedioEdades, 1)}");
        }
    }
}
