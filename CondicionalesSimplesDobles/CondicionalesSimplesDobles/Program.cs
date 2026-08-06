using System;

namespace CondicionalesSimplesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTRUCTURAS DE CONTROL CONDICIONAL
            //CONDICIONAL SIMPLE
            //1. CREA UN ALGORITMO QUE LEA LA EDAD DE UN USUARIO SI EL USUARIO ES MAYOR DE 18, SE DEBE MOSTRAR UN MENSAJE "BIENVENIDO A MI SITIO WEB, de lo contrario mostrar no es apto para visitar este sitio web"
            /*
                        byte edad = 0;
                        Console.WriteLine("Ingrese su edad");
                        edad = Convert.ToByte(Console.ReadLine());

                        if (edad >=18)
                        {
                            //Si la condicion es verdadera
                            Console.WriteLine("Bienvenido a mi sitio web");



                        }*/
/*

            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, siel sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona indicando que debe abonar impuesto.

            float sueldo = 0;
            string nombre = " ";
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo correspondiente");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine("Usted debe abonar a impuestos debido a la cantidad de su sueldo " + nombre);
            }
            else
            {
                Console.WriteLine("Persona exenta de impuestos");
            }

            byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad >= 18)
            {
                //Si la condicion es verdadera
                Console.WriteLine("Bienvenido a mi sitio web");



            }
            else
            {
                Console.WriteLine("No es apto para el contenido del sitio web");
            }
*/
            //CREAR UN ALGORITMO QUE PERMITA INGRSAR DOS NUMEROS, SI EL PRIMER NUMERO ES MAYOR AL SEGUNDO NUMERO INFORMAR SU SUMA Y DIFERENCIA, EN CASO CONTRARIO INFORMAR EL PRODUCTO Y LA DIVISION DEL PRIMER NUMERO RESPECTO AL SEGUNDO

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Ingrese el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine(numero1 - numero2);
            }
            else
            {
                Console.WriteLine(numero1 * numero2);
                Console.WriteLine(numero1 / numero2)
            }
            }
        }

    }

