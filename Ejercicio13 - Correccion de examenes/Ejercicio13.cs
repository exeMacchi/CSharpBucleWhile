using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13___Correccion_de_examenes
{
    internal class Ejercicio13
    {
        static void Main()
        {
            /* 
               13. Un profesor corrige varios exámenes de sus alumnos y según el puntaje de 1 a 100 (números naturales)
                   debe calificar al alumno respetando la siguiente tabla:
                      1-29 = 1
                      30-47 = 2
                      48-59 = 3
                      60-65 = 4
                      66-71 = 5
                      72-77 = 6
                      78-83 = 7
                      84-89 = 8
                      90-95 = 9
                      96-100 = 10
                   A medida que obtiene el resultado mostrar el puntaje y su condición:
                      Reprobó (menos de 4)
                      Aprobó (mayor o igual a 4 y menor a 7)
                      Promocionó (mayor o igual a 7).
                   Además se pide:
                      a. Los tres porcentajes (reprobados, aprobados y promocionados).
                      b. El mejor y el peor puntaje.
                      c. Promedio de nota total.
            */

            bool registrar = true, banPuntaje = false;
            int alumnos = 0;
            int notaAlumno, reprobados = 0, aprobados = 0, promocionados = 0, maxPuntaje = 0, minPuntaje = 0,
                acumNotas = 0;
            string condicion;

            while (registrar)
            {
                Console.WriteLine($"--------------------- Estudiante número {++alumnos} ---------------------");
                Console.Write("Puntaje del exámen: ");
                int puntaje = int.Parse(Console.ReadLine());

                if (puntaje > 0)
                {
                    // Conversión tabla a nota
                    if (puntaje >= 1 && puntaje <= 29) { notaAlumno = 1; }
                    else if (puntaje >= 30 && puntaje <= 47)  { notaAlumno = 2; }
                    else if (puntaje >= 48 && puntaje <= 59)  { notaAlumno = 3; }
                    else if (puntaje >= 60 && puntaje <= 65)  { notaAlumno = 4; }
                    else if (puntaje >= 66 && puntaje <= 71)  { notaAlumno = 5; }
                    else if (puntaje >= 72 && puntaje <= 77)  { notaAlumno = 6; }
                    else if (puntaje >= 78 && puntaje <= 83)  { notaAlumno = 7; }
                    else if (puntaje >= 84 && puntaje <= 89)  { notaAlumno = 8; }
                    else if (puntaje >= 90 && puntaje <= 95)  { notaAlumno = 9; }
                    else if (puntaje >= 96 && puntaje <= 100) { notaAlumno = 10; }
                    else { notaAlumno = 0; }

                    // Condición del alumno
                    if (notaAlumno < 4)
                        condicion = "REPROBADO";
                    else if (notaAlumno >= 4 && notaAlumno < 7)
                        condicion = "APROBADO";
                    else if (notaAlumno >= 7 && notaAlumno <= 10)
                        condicion = "PROMOCION";
                    else
                        condicion = "XXXX";


                    Console.WriteLine($"Condición del alumno: {condicion}");
                    Console.WriteLine($"Nota: {notaAlumno}");

                    if (condicion == "PROMOCION")
                    {
                        promocionados++;
                    }
                    else if (condicion == "APROBADO")
                    {
                        aprobados++;
                    }
                    else
                    {
                        reprobados++;
                    }

                    if (!banPuntaje)
                    {
                        maxPuntaje = puntaje;
                        minPuntaje = puntaje;
                        banPuntaje = true;
                    }
                    else
                    {
                        if (puntaje > maxPuntaje)
                        {
                            maxPuntaje = puntaje;
                        }
                        if (puntaje < minPuntaje)
                        {
                            minPuntaje = puntaje;
                        }
                    }

                    acumNotas += notaAlumno;
                }
                else
                {
                    registrar = false;
                }
            }

            int porcentajePromocionados = (promocionados * 100) / (alumnos - 1);
            int porcentajeAprobados = (aprobados * 100) / (alumnos - 1);
            int porcentajeReprobados = (reprobados * 100) / (alumnos - 1);

            float promedioNotas = acumNotas / (alumnos - 1);

            Console.WriteLine($"\n-------------------------- RESULTADOS --------------------------");
            Console.WriteLine($"Porcentaje de alumnos reprobados: {porcentajeReprobados}%");
            Console.WriteLine($"Porcentaje de alumnos aprobados: {porcentajeAprobados}%");
            Console.WriteLine($"Porcentaje de alumnos promocionados: {porcentajePromocionados}%");
            Console.WriteLine();
            Console.WriteLine($"Puntuación máxima: {maxPuntaje}");
            Console.WriteLine($"Puntuación mínima: {minPuntaje}");
            Console.WriteLine();
            Console.WriteLine($"Promedio de nota total: {Math.Round(promedioNotas)}");
        }
    }
}
