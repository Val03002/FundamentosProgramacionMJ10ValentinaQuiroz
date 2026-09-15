using System;


namespace _14.ArreglosUnidimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimencionales - vectores
            int[] numeros = new int[5];
            numeros[0] = 15;
            numeros[1] = 102;
            numeros[2] = 54;
            numeros[3] = 26;
            numeros[4] = 5;
            //numeros[5] = 11; No se puede porque la posición 6 con indice 5 no esxiste 
            Console.WriteLine($"El número almacenado en la posición 4 con indice 3 es: {numeros[3]}");
            Console.ReadKey();

            //otras formas de declarar e inicializar vectores
            char[] simbolos = new char[] { '?', '/', 'o', '5' };
            bool[] valoresVerdad = { true, false, true, false, true, true };

            //Recorrer para llenar de datos el vector
            string[] nombres = new string[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Ingrese el nombre para el p{i + 1}: I{i}: ");
                nombres[i] = Console.ReadLine();
            } 4}

        k
