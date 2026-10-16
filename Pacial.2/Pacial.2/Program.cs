using System;
using System.Security.Cryptography;


namespace Pacial._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una institución educativa requiere un programa para procesar el rendimiento académico de los 25 estudiantes del curso de Ciencias Naturales. Por cada estudiante se debe calcular su nota definitiva y determinar si aprobó o reprobó.
            //Utilizando obligatoriamente una estructura repetitiva, el programa debe:
            //Solicitar por teclado las tres calificaciones del período(Examen 1, Examen 2 y Trabajo de Investigación) para cada uno de los 25 estudiantes.Cada nota debe estar entre 0.0 y 5.0.
            //Calcular el promedio de las tres notas y mostrar en pantalla si el estudiante Aprobó(promedio >= 3.5) o Reprobó.
            //Al finalizar el procesamiento de todo el curso, el programa debe mostrar un resumen estadístico que incluya:
            //La cantidad total de estudiantes que aprobaron.
            //La cantidad total de estudiantes que reprobaron.
            //El promedio general de todo el curso(el promedio de los promedios de los 25 estudiantes
               
                int aprobados = 0;
                int reprobados = 0;
                double sumaPromedios = 0.0;
                int totalEstudiantes = 25;

                Console.WriteLine("Bienvenido al sistema de notas de Ciencias Naturales");

               
                for (int i = 1; i <= totalEstudiantes; i++)
                {
                    Console.WriteLine($" Estudiante {i} ");

                   
                    Console.Write("Ingrese la nota del Examen 1 (0.0 - 5.0): ");
                    double examen1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese la nota del Examen 2 (0.0 - 5.0): ");
                    double examen2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese la nota del Trabajo (0.0 - 5.0): ");
                    double trabajo = Convert.ToDouble(Console.ReadLine());

                   
                    double promedioEstudiante = (examen1 + examen2 + trabajo)/3;


                    Console.WriteLine($"Su promedio es: {promedioEstudiante}");


                    if (promedioEstudiante >= 3.0)
                    {
                        Console.WriteLine("Resultado: APROBÓ");
                        aprobados = aprobados + 1;
                    }
                    else
                    {
                        Console.WriteLine("Resultado: REPROBÓ");
                        reprobados = reprobados + 1;
                    }


                    sumaPromedios = sumaPromedios + promedioEstudiante;
                }
                double promedioGeneral = sumaPromedios / totalEstudiantes;



                Console.WriteLine("RESUMEN");
                Console.WriteLine($"Bienvenido a las notas de Ciencias Naturales");
                Console.WriteLine($"Cantidad de estudiantes aprobados: {aprobados}");
                Console.WriteLine($"Cantidad de estudiantes reprobados: {reprobados}");
                Console.WriteLine($"Promedio general del curso: {promedioGeneral}");


                Console.ReadLine();
                Console.WriteLine("Presione cualquier tecla para salir");
                if (aprobados > 0)
                {
                    {
                        Console.WriteLine("Los estudiantes aprobados son: " + aprobados);
                    }

                }


                //El codigo funciona si se le pone la coma pero no da con punto
            
        }
    }
}

