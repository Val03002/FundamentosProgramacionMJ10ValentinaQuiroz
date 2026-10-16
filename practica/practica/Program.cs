using System;

namespace practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tieneAmuleto = false;
            Console.WriteLine("¿Tienes su Amuleto? (true/false)");
           
            string entrada = Console.ReadLine();

            tieneAmuleto = bool.Parse(entrada);

            Random aleatorio =new Random();
            int TieneMana = aleatorio.Next(0, 100);

            Console.WriteLine($"---------Puedes entrar al portal?---------");
            Console.WriteLine($"Tienes el amuleto: {tieneAmuleto}");
            Console.WriteLine($"tienes mana: {TieneMana}");

            if (tieneAmuleto && TieneMana >= 50)
            {
                Console.WriteLine("Puedes entrar al portal");
            }
            else
            {
                Console.WriteLine("No puedes entrar al portal");
            }



        }
    }
}
