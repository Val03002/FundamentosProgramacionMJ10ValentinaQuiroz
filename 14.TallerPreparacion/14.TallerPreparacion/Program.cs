using System;

namespace _14.TallerPreparacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que permita calcular el promedio de calificaciones, el algoritmo le permitirá al usuario, introducir tantas calificaciones como así desee, en el momento en que seleccione que no desea continuar capturando calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas previamente. 


            //double sumaCalificaciones = 0;

            //double contador = 0;


            //Console.WriteLine("Ingrese su nombre: ");
            //Console.ReadLine();

            //while (true)
            //{
            //    Console.WriteLine("Ingrese una calificación: ");
            //    double calificacion = double.Parse(Console.ReadLine());
            //    sumaCalificaciones += calificacion;
            //    contador++;
            //    Console.WriteLine("¿Desea capturar otra calificación? (s/n): ");
            //    string respuesta = Console.ReadLine();
            //    if (respuesta.ToLower() != "s")
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine("El promedio de las calificaciones es: " + (sumaCalificaciones / contador));
            //Console.ReadLine();


            //Se requiere un algoritmo para mostrar por pantalla los divisores de un número ingresado por teclado. Tener en cuenta que dados dos números enteros a y b, se dice que b es divisor de a si se cumple que al efectuar una división entera a/b el residuo es 0, en C# utilizar el operador Mod para obtener el residuo de una división de dos números. 

            int numero= 0;
            int divisor = 1;
            int contadorDivisores = 0;
            int numeroIngresado = 0;



            Console.WriteLine("Ingrese un número: ");
            numeroIngresado = int.Parse(Console.ReadLine());

         

            while(true)
                
            {
                if (numeroIngresado % divisor == 0)
                {
                    contadorDivisores++;
                    Console.WriteLine("El número " + divisor + " es divisor de " + numeroIngresado);
                }
                divisor++;
                if (divisor > numeroIngresado)
                {
                    break;
                }
            }













        }
    }
}
