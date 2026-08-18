using System;


namespace _7.CondicionalesTaller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TALLER CONDICIONALES

            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("Escriba numero 1");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba numero 2");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba numero 3");
            numero3 = Convert.ToInt32(Console.ReadLine());


            if (numero1 != numero2 && numero2 != numero3 && numero3 != numero1)
            {

                if (numero1 > numero2 && numero2 > numero3 && numero3 < numero1)
                {
                    Console.WriteLine(numero1 + " " + numero2 + " " + numero3);
                    //Console.WriteLine("{0} {1} {2}",numero1,numero2,numero3);
                    //Console.WriteLine($"{numero1} {numero2} {numero3}");
                }
                if (numero2 > numero3 && numero1 < numero3 && numero3 < numero2)
                {
                    Console.WriteLine(numero2 + " " + numero3 + " " + numero1 + " ");
                }

                if (numero3 > numero2 && numero2 > numero1 && numero3 > numero1)
                {
                    Console.WriteLine(numero3 + " " + numero2 + " " + numero1 + " ");
                }

                if (numero1 > numero3 && numero3 > numero2 && numero1 > numero2)
                {
                    Console.WriteLine(numero1 + " " + numero3 + " " + numero2 + " ");
                }

                if (numero2 > numero1 && numero1 > numero3 && numero2 > numero3)
                {
                    Console.WriteLine(numero2 + " " + numero1 + " " + numero3 + " ");
                }

                if (numero3 > numero1 && numero2 < numero3 && numero1 > numero2)
                {
                    Console.WriteLine(numero3 + " " + numero1 + " " + numero2 + " ");
                }
            }
            else
            {
                Console.WriteLine("Se deben ingresar numeros diferentes");
            }
        }
    }
}
