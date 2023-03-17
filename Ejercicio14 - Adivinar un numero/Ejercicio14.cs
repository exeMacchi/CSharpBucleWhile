using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14___Adivinar_un_numero
{
    class Ejercicio14
    {
        static void Main()
        {
            // Un juego de adivinar un número aleatorio

            Random random = new Random();
            int numeroAleatorio = random.Next(0, 100);
            int contadorIntentos = 1;
            int numeroUsuario;

            Console.Write("-------------------- ");
            Console.Write("Bienvenido al juego \"Adivina el número\"");
            Console.Write(" --------------------\n");
            Console.Write("Ingrese un número (del 0 al 100): ");
            numeroUsuario = int.Parse(Console.ReadLine());

            while (numeroUsuario != numeroAleatorio)
            {
                if (numeroUsuario > numeroAleatorio)
                {
                    Console.Write("El número es menor. Ingrese otro número: ");
                    numeroUsuario = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("El número es mayor. Ingrese otro número: ");
                    numeroUsuario = int.Parse(Console.ReadLine());
                }
                contadorIntentos++;
            }

            Console.WriteLine($"¡Felicitaciones, adivinó el número! ({numeroAleatorio})");
            if (contadorIntentos != 1)
            {
                Console.WriteLine($"Necesitó {contadorIntentos} intentos para lograrlo.\n");
            }
            else
            {
                Console.WriteLine("¡Wow! Lo logró a la primera. Usted es un adivino.");
            }
        }
    }
}
