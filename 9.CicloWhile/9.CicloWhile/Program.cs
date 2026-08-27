using System;

namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int acumulador = 0;
            //int numero = 0;

            //Console.WriteLine("Ingrese el numero a sumar");
            //numero =int.Parse(Console.ReadLine());

            //while(numero>=0)
            //{
            //    acumulador += numero;
            //    Console.WriteLine("Ingrese el numero a sumar");
            //    numero = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"La suma de los numeros ingresados es: {acumulador}");


            //int contador = 0;
            //int numero = 0;
            //int cantidadnumero = 0;
            //int contadorPositivo = 0;
            //int contadorNegativos = 0;
            //int contadorCeros = 0;


            //Console.WriteLine("Ingrese la cantidad de numeros que va a introducir");
            //cantidadnumero = int.Parse(Console.ReadLine());

            //while (contador<cantidadnumero)
            //{
            //    contador++;
            //    Console.WriteLine("Ingrese numero a evaluar");

            //    numero = int.Parse(Console.ReadLine());
            //    if (numero > 0)
            //    {
            //        contadorPositivo++;
            //    }
            //    else
            //    {
            //        if (numero < 0)
            //        {
            //            contadorNegativos++;

            //        }
            //        else
            //        {
            //            contadorCeros++;
            //        }

            //    }



            //}

            //Console.WriteLine($"Cantidad de positivos:{contadorPositivo}");
            //Console.WriteLine($"Cantidad de positivos:{contadorNegativos}");
            //Console.WriteLine($"Cantidad de positivos:{contadorCeros}");


            int numero = 0;
            int contador = 1;
            int rango = 0;
            int contadorPares = 0;

            Console.WriteLine("Ingrese los numeros qu quiere evaluar");
            rango=int.Parse(Console.ReadLine());

            while (contador <= rango)
            {
                if (contador % 2 == 0)
                {
                    contadorPares++;
                    Console.WriteLine($"{contador}");
                }
                contador++;
            }

            Console.WriteLine($"La cantidad de numeros pares del 1 al{rango} es : {contadorPares}");
            

        }
    }
}
