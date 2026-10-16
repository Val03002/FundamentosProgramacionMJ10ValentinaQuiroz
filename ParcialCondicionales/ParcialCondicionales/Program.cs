using System;


namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ingreso de datos
            // El programa debe solicitar al usuario los siguientes datos:
            // Nombre del empleado.
            //Número de años trabajados en la empresa, expresado como un número entero mayor o igual a 0.
            //Calificación del año actual.
            //Calificación del año anterior.
            //Las calificaciones únicamente pueden tomar uno de los siguientes valores:
            //0.0, 0.4, 0.6 o 1.0

            //Validación de las calificaciones
            //El programa debe verificar que tanto la calificación del año actual como la del año anterior correspondan a uno de los valores permitidos.
            //Si alguna de las dos calificaciones no es válida, el programa debe mostrar:
            //Error: calificación inválida. El programa terminará.
            //En este caso, el programa debe finalizar y no debe realizar el cálculo del promedio ni del aumento salarial.
            //Cálculo del promedio
            //Si las calificaciones son válidas, el programa debe calcular el promedio de las dos calificaciones mediante la siguiente fórmula:
            //promedioCalificación = (calificaciónActual + calificaciónAnterior) / 2
            string nombre = " ";
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            string numeroAñosTrabajados = " ";
            Console.WriteLine("Ingrese el número de años trabajados en la empresa: ");
            numeroAñosTrabajados = Console.ReadLine();

            string calificacionActual = " ";
            Console.WriteLine("Ingrese la calificación del año actual: ");
            calificacionActual = Console.ReadLine();

            string calificacionAnterior = " ";
            Console.WriteLine("Ingrese la calificación del año anterior: ");
            calificacionAnterior = Console.ReadLine();

            const string sueldoBase = "2.500.000";

            string CalificacionActual = "0";
            string CalificacionAnterior = "0";
            string valor1 = "0.0";
            string valor2 = "0.4";
            string valor3 = "0.6";
            string valor4 = "1.0";

            double promedio = ((Convert.ToDouble(calificacionActual) + Convert.ToDouble(calificacionAnterior)) / 2);

            int calificacionActualInt = Convert.ToInt32(calificacionActual);
            int calificacionAnteriorInt = Convert.ToInt32(calificacionAnterior);
            int promedioInt = Convert.ToInt32(promedio);

            int dato1 = Convert.ToInt32(numeroAñosTrabajados);

            int dato3 = Convert.ToInt32(calificacionAnterior);

            if (valor1 == calificacionActual || valor2 == calificacionActual || valor3 == calificacionActual || valor4 == calificacionActual)
            {
                if (valor1 == calificacionAnterior || valor2 == calificacionAnterior || valor3 == calificacionAnterior || valor4 == calificacionAnterior)
                {
                    Console.WriteLine("Calificaciones válidas.");
                }

                else
                {
                    Console.WriteLine("Error: calificación inválida. El programa terminará.");
                }
            }
            else
            {
                Console.WriteLine("Error: calificación inválida. El programa terminará.");



            }

            if (calificacionActual == valor1 && calificacionActual == valor2 && calificacionActual == valor3 && calificacionActual == valor4)
            {
               
                Console.WriteLine($"Su promedio es de {promedio} ");


            }
            else
            {
                Console.WriteLine("Error: calificación inválida. El programa terminará.");
            }

            if (promedio >= 0.0 && promedio < 0.4)
            {
                Console.WriteLine("Su sueldo aumentara en un 30%.");
            }

            if (promedio > 1 && promedio < 5)
            {
                Console.WriteLine("Su sueldo aumentara en un 5%.");
            }

            if (promedio <= 0.4 && promedio < 0.6)
            {
                Console.WriteLine("Su sueldo aumentara en un 10%.");
            }

            if (promedio <= 0.6 && promedio < 1.0)
            {
                Console.WriteLine("Su sueldo aumentara en un 20%.");
            }

            else (promedio)
            {
                Console.WriteLine($"Su sueldo no aumentara. su sueldo es{sueldoBase}");

            }

            //Se que tengo un problema bien grande con el promedio :(
            //En algunas partes para que no me quedaran 15 errores lo "corrigio" el programa, pq tampoco lo corrigio, lo organizo bien raro



        }
    } 
}
