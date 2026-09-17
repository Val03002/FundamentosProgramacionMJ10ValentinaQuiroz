using System;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
            //encuentre y muestre el valor máximo y mínimo de los números ingresados

            //int[] vector = new int[15];

            //int max = int.MinValue;
            //int min = int.MaxValue;

            //Console.WriteLine("Ingrese 15 números enteros:");
            //Console.WriteLine("Haga clic en Enter después de ingresar cada número.");
            //Console.ReadLine();

            //for (int i = 0; i < vector.Length; i++)
            //{
            //    Console.Write($"Número {i + 1}: ");
            //    vector[i] = int.Parse(Console.ReadLine());
            //    if (vector[i] > max)
            //    {
            //        max = vector[i];
            //    }
            //    if (vector[i] < min)
            //    {
            //        min = vector[i];
            //    }
            //}
            //Console.WriteLine($"El valor máximo es: {max}");
            //Console.WriteLine($"El valor mínimo es: {min}");

            //Escribir un algoritmo que permita: 
            //a.Crear dos vectores del mismo tamaño. 
            //b.Llenarlos con números.
            //c.Comparar posición por posición.
            //d.Indicar cuántos elementos son iguales. 

            int[] vector1 = new int[5];
            int[] vector2 = new int[5];

            Console.WriteLine("Ingrese 5 números enteros para el primer vector:");
            Console.WriteLine("Haga clic en Enter después de ingresar cada número.");

            for (int i = 0; i < vector1.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                vector1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese 5 números enteros para el segundo vector:");
            Console.WriteLine("Haga clic en Enter después de ingresar cada número.");

            for (int i = 0; i < vector2.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                vector2[i] = int.Parse(Console.ReadLine());
            }

            int iguales = 0;
            

            for (int i = 0; i < vector1.Length; i++)
            {
                if (vector1[i] == vector2[i])
                {
                    iguales++;
                }
               
            }

            for (int i = 0; i < vector1.Length; i++)
            {
                Console.WriteLine($"Posición {i + 1}: Vector1 = {vector1[i]}, Vector2 = {vector2[i]}");
            }

            Console.WriteLine($"Cantidad de numeros iguales: {iguales} ");

           



        }
    }
}
