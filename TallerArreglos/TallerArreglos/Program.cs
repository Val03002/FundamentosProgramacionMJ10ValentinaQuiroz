using System;
using System.Security.Cryptography;

namespace TallerArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa
            //caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
            //primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
            //matriz con el intercambio de filas.

            //int filas=0;
            //int columnas = 0;
            //char[,] simbolos = new char[filas, columnas];

            //Console.WriteLine("Ingrese el número de filas de la matriz:");
            //filas = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el número de columnas de la matriz:");
            //columnas = int.Parse(Console.ReadLine());

            //int[,] matriz = new int[filas, columnas];

            //for (int i = 0; i < filas; i++)
            //{
            //    for (int j = 0; j < columnas; j++)
            //    {
            //        Console.WriteLine($"Ingrese el valor para la posición [{i},{j}]:");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Matriz original:");
            //for (int i = 0; i < filas; i++)
            //{
            //    for (int j = 0; j < columnas; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //     for (int i = 0; i < simbolos.GetLength(0); i++) ;
            //    {
            //      for(int j = 0; j < simbolos.GetLength(1); j++) ;
            //      {
            //        char temp = simbolos[0, j];
            //        simbolos[0, j] = simbolos[filas - 1, j];
            //        simbolos[filas - 1, j] = temp;
            //      }
            //    }

            //int[,] matriz = new int[10, 20];

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 20; j++)
            //    {
            //        matriz[i, j] = 100;
            //    }
            //}
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();

              //Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de
              //5x5 llena de números aleatorios.
              //El algoritmo debe permitir:
              // Usa la función Random para generar los números aleatorios.
             // Crea un arreglo adicional para almacenar la frecuencia de cada número.

            // Crear un generador de números aleatorios
            Random random = new Random();

            Console.WriteLine("Matriz de 5x5 con números aleatorios del 1 al 10:");
            int numeros = int.Parse(Console.ReadLine());
            numeros = random.Next(1, 11);



            int[,] matriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(1, 11);
                }
            }

            int[] frecuencia = new int[10];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    frecuencia[matriz[i, j] - 1]++;
                }
            }

            Console.WriteLine("Frecuencia de cada número del 1 al 10:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Número {i + 1}: {frecuencia[i]}");
            }






        }
    }
}
