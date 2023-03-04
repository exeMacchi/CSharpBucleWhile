using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01___Datos_alumnos_escuela
{
    internal class Ejercicio01
    {
        static void Main(string[] args)
        {
            /* 
                1. Para un curso de alumnos se necesita lo siguiente:
                    a. Promedio de altura de las mujeres.
                    b. Promedio de altura de los varones.
                    c. Cantidad de personas que tienen más de 2 hermanos.
            */

            float acumuladoAlturaHombre = 0, acumuladoAlturaMujer = 0;
            int contadorHermanos = 0, registros = 0, registrosHombres = 0, registrosMujeres = 0;
            bool registrar = true;

            while (registrar)
            {
                registros++;

                Console.WriteLine($"--------------------- Alumno {registros} ---------------------");
                Console.Write("Nombre: ");
                Console.ReadLine();
                Console.Write("Género (H = Hombre / M = Mujer): ");
                char generoAlumno = char.Parse(Console.ReadLine());
                Console.Write("Altura (metros): ");
                float estaturaAlumno = float.Parse(Console.ReadLine());
                Console.Write("Cantidad de hermanos: ");
                int hermanosAlumnos = int.Parse(Console.ReadLine());

                if (generoAlumno == 'H' || generoAlumno == 'h')
                {
                    acumuladoAlturaHombre += estaturaAlumno;
                    registrosHombres++;
                }
                else if (generoAlumno == 'M' || generoAlumno == 'm')
                {
                    acumuladoAlturaMujer += estaturaAlumno;
                    registrosMujeres++;
                }

                if (hermanosAlumnos > 2)
                {
                    contadorHermanos++;
                }


                Console.Write("¿Continuar registrando? (S = Sí / N = No): ");
                char respuesta = char.Parse(Console.ReadLine());

                if (respuesta == 'N' || respuesta == 'n')
                {
                    registrar = false;
                }
                else if (respuesta != 'S' && respuesta != 's')
                {
                    Console.WriteLine("Error: opción inválida.");
                    registrar = false;
                }
            }

            float promedioAlturaHombres = acumuladoAlturaHombre / registrosHombres;
            float promedioAlturaMujeres = acumuladoAlturaMujer / registrosMujeres;

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"Promedio de altura de los hombres: {Math.Round(promedioAlturaHombres, 2)}");
            Console.WriteLine($"Promedio de altura de las mujeres: {Math.Round(promedioAlturaMujeres, 2)}");
            Console.WriteLine($"Alumnos con más de 2 hermanos: {contadorHermanos}");
        }
    }
}
