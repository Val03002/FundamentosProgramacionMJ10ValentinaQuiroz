using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Condicionalespto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace JuegoPersonaje
    {
        class Program
        {
            static void Main(string[] args)
            {
                // 1. Generar un número aleatorio entre 0 y 5 para las vidas
                // Nota: El método Next(min, max) incluye el mínimo pero excluye el máximo,
                // por eso usamos Next(0, 6) para obtener números del 0 al 5.
                Random generador = new Random();
                int vidas = generador.Next(0, 6);

                Console.WriteLine("========================================");
                Console.WriteLine("      BIENVENIDO AL JUEGO");
                Console.WriteLine("========================================");
                Console.WriteLine("Vidas iniciales del personaje: " + vidas);
                Console.WriteLine("----------------------------------------");

                // 2. Verificar si el personaje tiene vidas para actuar
                if (vidas > 0)
                {
                    Console.WriteLine("El personaje está listo para la acción.");
                    Console.WriteLine("Ingresa un carácter para realizar una acción:");
                    Console.WriteLine(" [c] - Disparar");
                    Console.WriteLine(" [x] - Hablar con la Rana");
                    Console.WriteLine(" [t] - Modo Turbo");
                    Console.WriteLine(" [i] - Invencible");
                    Console.Write("\nTu elección: ");

                    // Leer la tecla que presiona el usuario y convertirla a minúscula por si acaso
                    char accion = char.ToLower(Console.ReadKey().KeyChar);
                    Console.WriteLine(); // Salto de línea estético después de presionar la tecla

                    // 3. Evaluar la acción ingresada mediante un switch
                    switch (accion)
                    {
                        case 'c':
                            Console.WriteLine("\n--> El personaje está disparando");
                            break;
                        case 'x':
                            Console.WriteLine("\n--> El personaje está hablando con la Rana");
                            break;
                        case 't':
                            Console.WriteLine("\n--> El personaje está en modo Turbo");
                            break;
                        case 'i':
                            Console.WriteLine("\n--> El personaje es Invencible");
                            break;
                        default:
                            Console.WriteLine("\n--> Tecla incorrecta. El personaje se quedó quieto.");
                            break;
                    }
                }
                else
                {
                    // Si las vidas son 0
                    Console.WriteLine("El personaje no posee vidas, y no puede realizar ninguna acción.");
                }

                Console.WriteLine("\nPresiona cualquier tecla para salir...");
                Console.ReadKey();
            }
        }
    }
}
    }
}
