using System;


namespace _5.CONDICIONALESANIDADOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales Anidados

            //Diseñar un algoritmo que lea tres numeros A, B, C y visualice en pantalla el valor mas grande. El usuario debe ingresar tres valores diferentes.
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Se deben ingfresar tres valores diferentes");
            Console.WriteLine("Ingrese el valor del numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Se deben ingfresar tres valores diferentes");
            Console.WriteLine("Ingrese el valor del numero 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Se deben ingfresar tres valores diferentes");
            Console.WriteLine("Ingrese el valor del numero 3");
            num3 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                //Verdadera
                if(num1>num3)
                {
                    Console.WriteLine("El numero 1 es el mayor");
                }
                else
                {
                    Console.WriteLine("El numero 3 es el mayor");
                }

              
            }
            else
            {
               //Falsa
               if(num2>num3)
                {
                    Console.WriteLine("El numero 2 es el mayor");
                }
                else
                {
                    Console.WriteLine("El numero 3 es el mayor");
                }
            }

        }
    }
}
