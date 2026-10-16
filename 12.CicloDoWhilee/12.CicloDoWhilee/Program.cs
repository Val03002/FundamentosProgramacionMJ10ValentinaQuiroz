using System;

namespace _12.CicloDoWhilee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nombre;
            //double numeroCuenta = 0;
            //int saldo = 0;
            //int totalUsuarios = 0;
            //double sumaSaldos = 0;
            //double promedioSaldos = 0;

            //do
            //{
            //    Console.WriteLine("Ingrese su nombre: ");
            //    nombre = Console.ReadLine();

            //    Console.WriteLine("Ingrese su número de cuenta: ");
            //    numeroCuenta = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Ingrese su saldo: ");
            //    saldo = int.Parse(Console.ReadLine());

            //    if (saldo >= 3000000)
            //    {
            //        Console.WriteLine($"El usuario {nombre} con número de cuenta {numeroCuenta} tiene un saldo de {saldo} y es apto para el crédito.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"El usuario {nombre} con número de cuenta {numeroCuenta} tiene un saldo de {saldo} y no es apto para el crédito.");
            //    }
            //    Console.WriteLine("¿Desea ingresar otro usuario? (s/n)");
            //} while (Console.ReadLine().ToLower() == "s");

            //if (totalUsuarios > 0)
            //{
            //    promedioSaldos = sumaSaldos / totalUsuarios;
            //}

            //Console.WriteLine("------ RESULTADOS FINALES -------");
            //Console.WriteLine($"Número total de usuarios ingresados: {totalUsuarios}");
            //Console.WriteLine($"Promedio de saldos: {promedioSaldos:N0}");

            //Crea un algoritmo que permita el usuario ingresar una contraseña. Que se repita hasta que ingrese la contraseña correcta (por ejemplo: 1234) y mostrar cuantos intentos realizo.

            string contraseñaCorrecta = "1234";
            string contraseñaIngresada;
           
          
            int intentos = 0;

            do
            {
                Console.WriteLine("Ingrese la contraseña: ");
                contraseñaIngresada = Console.ReadLine();
                intentos++;
                if (contraseñaIngresada != contraseñaCorrecta)
                {
                    Console.WriteLine("Contraseña incorrecta. Intente nuevamente.");
                }
            } while (contraseñaIngresada != contraseñaCorrecta);

            Console.WriteLine("¡Contraseña correcta! Acceso concedido.");
            Console.WriteLine($"Número de intentos realizados: {intentos}");
            






        }
    }
}
