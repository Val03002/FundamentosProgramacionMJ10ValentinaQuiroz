using System;

namespace _17.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de Fundamentos de programacion");
            MostrarMensaje("Val"); 
            Console.ReadKey();
            BorrarPantalla();
        }

        //Porcedimientos sin parametros
        static void BorrarPantalla()
        {
            Console.Clear();





        }
        //Procedimientos con parametros
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de Fundamentos de Programacion");


        }

    }

}

      