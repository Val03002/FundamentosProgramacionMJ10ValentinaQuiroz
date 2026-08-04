using System;


namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Orden de evaluacion de operadores numericos
            float dato1 = 4 * 3 / 2;
            float dato2 = 4f / 3f * 2f;
            float dato3 = 4f * (2 / 3);
            float dato4 = 4 + 6 * 3;
            float dato5 = 4 + 6 * (2 - 1);
            Console.WriteLine(dato3);

            //Operadores logicos
            //Conjuncion - AND - Y - &&
            Console.WriteLine("TABLA CONJUNCION");
            Console.WriteLine("V && V = " + (true && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && V = " + (false && true));
            Console.WriteLine("F && F = " + (false && false));
            Console.WriteLine("----------------------");

            //Disyuncion - OR - O - ||
            Console.WriteLine("TABLA DISYUNCION");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("----------------------");

            //Operador logico de negacion !

            bool dato8 = true;
            bool dato9 = !dato8;

            //OPERADORES DE COMPARACION
            bool dato6 = 5 > 4;
            bool dato7 = 100 == 99;
            bool dato10 = 1002 != 102;
            bool dato11 = 10 >= 10;
            bool dato12 = 12 < 11 && 0 == 1;
            bool dato13 = dato8 && 0 != 10 || !dato10;


        }
    }
}
