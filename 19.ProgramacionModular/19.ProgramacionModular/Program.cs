using System;


namespace _19.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperacion(CapturarOpcion());
            BorrarPantalla();

        }


        static void BorrarPantalla()
        {
            Console.Clear();
        }   


        static void realizarOperacion(int opcion)   

        {
            
        }
        static float Resta()
        {
            Console.WriteLine("Resta");

            Console.WriteLine("Ingrese un numero 1");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            float numero2 = float.Parse(Console.ReadLine());

            return numero1 - numero2;
        }

        static float Division()
        {
            Console.WriteLine("Division");
   
                Console.WriteLine("Ingrese un numero 1");
                float numero1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                float numero2 = float.Parse(Console.ReadLine());

            return numero1 / numero2;
        }       


        static float Multiplicacion()
        {
            Console.WriteLine("Multiplicacion");
            float multiplicacion = 1;
            float numero = 0;
            
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Desea ingresar otro numero? (s/n)");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's' || respuesta == 'S');
            return multiplicacion;
        }

        static float Suma()
        {
            Console.WriteLine("Suma");
            float suma = 0;
            float numero = 0;
            
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea ingresar otro numero? (s/n)");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's' || respuesta == 'S');
            return suma;
        }

        static void RealizarOperacion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"La Suma de los numeros ingresados es: {Suma()}");
                    break;
                case 2:
                    Console.WriteLine($"La Resta de los numeros ingresados es: {Resta()}");
                    break;
                case 3:
                    Console.WriteLine($"La Multiplicacion de los numeros ingresados es: {Multiplicacion()}");
                    break;
                case 4:
                    Console.WriteLine($"La Division de los numeros ingresados es: {Division()}");
                    break;
                case 0:
                    Console.WriteLine("Salir");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }

        static int CapturarOpcion()
        {
            
            return int.Parse(Console.ReadLine());
        }               

        static void MostrarMenu()
        {
            Console.WriteLine("-----------Menu------------");
            Console.WriteLine("1.Suma              2.Resta");
            Console.WriteLine("3.Multiplicacion 4.Division");
            Console.WriteLine("0.Salir");
            Console.WriteLine("---------------------------");



        }
    }
}