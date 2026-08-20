using System;


namespace Taller_condicionales7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esInvencible = false;
            Console.WriteLine("¿El personaje es invencible? (true/false)");

            string entrada = Console.ReadLine();

            esInvencible= bool.Parse(entrada);

            Random aleatorio = new Random();
           
            int municiones = aleatorio.Next(0, 100);

            Console.WriteLine($"-----------Estado del personaje-----------");
            Console.WriteLine($"---------¿Es invencible? {esInvencible}---");
            Console.WriteLine($"---------Municiones: {municiones}---------");
            Console.WriteLine("-------------------------------------------");

            if (municiones > 0&& esInvencible)
            {
                Console.WriteLine("El personaje puede disparar y es invencible.");
            }
            else if (municiones > 0 && !esInvencible)
            {
                Console.WriteLine("El personaje puede disparar pero no es invencible.");
            }
            else if (municiones == 0 && esInvencible)
            {
                Console.WriteLine("El personaje no puede disparar pero es invencible.");
            }
            else
            {
                Console.WriteLine("El personaje no puede disparar y no es invencible.");

            }
        }

          

    }
}
