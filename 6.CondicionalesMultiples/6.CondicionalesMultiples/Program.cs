using System;

namespace _6.CondicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int respuesta = 0;
            Console.WriteLine("----------Menu-----------");
            Console.WriteLine("1.opcion 1     2.Opcion 2");
            Console.WriteLine("3.opcion 3     4.Opcion 4");
            Console.WriteLine("1.opcion 5     ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Elija una opcion del menu:");
            respuesta=int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Eligio la Opcion 1");
                    break;
                case 2:
                    Console.WriteLine("Eligio la Opcion 2");
                    break;
                case 3:
                    Console.WriteLine("Eligio la Opcion 3");
                    break;
                case 4:
                    Console.WriteLine("Eligio la Opcion 4");
                    break;
                case 5:
                    Console.WriteLine("Eligio la Opcion 5");
                    break;
                default:
                    Console.WriteLine("Elija una opcion valida");
                    break;
            }
        }
    }
}
