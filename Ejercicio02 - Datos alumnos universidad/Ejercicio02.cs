using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02___Datos_alumnos_universidad
{
    internal class Ejercicio02
    {
        static void Main(string[] args)
        {
            /* 
                2. En la universidad se registran los siguientes datos por alumno:
                      • Edad.
                      • Cantidad de materias aprobadas (regular).
                      • Cantidad de materias aprobadas por finales.
                      • Sexo. 
                   Se pide lo siguiente:
                      a. Promedio de edad de los varones.
                      b. Cantidad de alumnos que aprobaron más de 3 finales.
                      c. Porcentaje de alumnas y alumnos en la universidad.
                      d. Promedio de materias regularizadas. 
            */

            bool registrar = true;
            int contadorAlumnos = 0, acumuladoEdadHombres = 0, contadorHombres = 0, contadorMujeres = 0,
                contadorAlumnosFinales = 0, acumuladorRegularizadas = 0;

            while (registrar)
            {
                contadorAlumnos++;

                Console.WriteLine($"------------------------- Estudiante {contadorAlumnos} -------------------------");
                Console.Write("Edad: ");
                int edadAlumno = int.Parse(Console.ReadLine());
                Console.Write("Sexo (H = Hombre / M = Mujer): ");
                char generoAlumno = char.Parse(Console.ReadLine());
                Console.Write("Cantidad de materias aprobadas (regularizadas): ");
                int cantidadRegularizadas = int.Parse(Console.ReadLine());
                Console.Write("Cantidad de materias aprobadas (final): ");
                int cantidadFinales = int.Parse(Console.ReadLine());


                if (generoAlumno == 'H' || generoAlumno == 'h')
                {
                    acumuladoEdadHombres += edadAlumno;
                    contadorHombres++;
                }
                else if (generoAlumno == 'M' || generoAlumno == 'm')
                {
                    contadorMujeres++;
                }

                if (cantidadFinales > 3)
                {
                    contadorAlumnosFinales++;
                }

                acumuladorRegularizadas += cantidadRegularizadas;

                Console.Write("¿Seguir registrando? (S = Sí / N = No): ");
                char respuesta = char.Parse(Console.ReadLine());


                if (respuesta == 'N' || respuesta == 'n')
                {
                    registrar = false;
                }
                else if (respuesta != 'S' && respuesta != 's')
                {
                    registrar = false;
                }
            }

            float promedioEdadHombres = acumuladoEdadHombres / (float)contadorHombres;

            int totalAlumnos = contadorHombres + contadorMujeres;
            int porcentajeHombres = (contadorHombres * 100) / totalAlumnos;
            int porcentajeMujeres = 100 - porcentajeHombres;

            float promedioMateriasRegularizadas = acumuladorRegularizadas / (float)contadorAlumnos;

            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine($"Promedio de edad de los varones: {Math.Round(promedioEdadHombres, 1)} años.");
            Console.WriteLine($"Cantidad de alumnos que aprobaron más de tres finales: {contadorAlumnosFinales}");
            Console.WriteLine($"Porcentaje de estudiantes hombres en la universidad: {porcentajeHombres}%");
            Console.WriteLine($"Porcentaje de estudiantes mujeres en la universidad: {porcentajeMujeres}%");
            Console.WriteLine($"Promedio de materias regularizadas: {Math.Round(promedioMateriasRegularizadas, 1)}");
        }
    }
}
