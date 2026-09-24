using System;
using System.Collections;

namespace _15.ArreglosBidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int[,] numeros = new int[2, 3];

            //    //numeros[2, 1]=10; no se puede almacenar porque el indice de la fila no existe 
            //    //numeros[1, 3] = 15; no se puede almacenar pq el indice de la columna no existe
            //    numeros[0, 0] = 12;
            //    numeros[0, 1] = 100;
            //    numeros[0, 2] = 56;
            //    numeros[1, 0] = 45;
            //    numeros[1, 1] = 8;
            //    numeros[1, 2] = 10;

            //    Console.WriteLine($"El valor almacenado en numeros [1,0]:{numeros[1, 0]} ");

            //    //Recorrer para llenar
            //    char[,] simbolos = new char[3, 2];
            //    for (int i = 0; i < 3; i++)//recorrer filas
            //    {
            //        for (int j = 0; j < 2; j++)//recorrer columnas
            //        {
            //            Console.WriteLine($"Ingrese un simbolo para la posicion [{i},{j}]: ");
            //            simbolos[i, j] = char.Parse(Console.ReadLine());
            //        }
            //    }

            //    //Recorrer para recuperar datos
            //    for (int i = 0; i < simbolos.GetLength(0); i++)//GetLEngth(0) devuelve el numero de filas
            //    {
            //        for (int j = 0; j < simbolos.GetLength(1); j++)//getLength(1) devuelve el numero de columnas
            //        {
            //            Console.WriteLine($"El simbolo almacenado en simbolos [{i},{j}]: {simbolos[i, j]}");

            //        }
            //    } Console.WriteLine();

            //}   //Otra forma de forma
            //string[,] nombres =
            //{
            //    { "Juan","Pedro","Maria", "Felix" },
            //    {"Ana","Luis","Marta", "Carlos" },
            //    {"Jose","Lucia","Miguel", "Sofia" }



            //};

            //Crear una matriz[10, 20] en cada posicion de la matriz poner un numero 100; mostrar la matriz en consola

            int[,] matriz = new int[10, 20];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz[i, j] = 100;
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }


        }

    }
}