// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

namespace parcial1
{
    class Program
    {
        private static string control;
        private static int indice;
        private static string control2;

        static void Main(string[] args)
        {
            string nombre;
            int edad;
            int nota1;
            int nota2;
            int parcial;
            int notafinal;
            int opciones;
            string dato;
            string cerrar;

            estudiantes[] arregloestudiantes = new estudiantes;

            while (control == "si")
            {
                Console.WriteLine("ingrese los datos a continuacion");
                Console.WriteLine("ingrese su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese su edad");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese su nota de laboratorio 1");
                nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese su nota de laboratorio 2");
                nota2 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese su nota de parcial");
                parcial = int.Parse(Console.ReadLine());

                notafinal = (int)((nota1 * .3) + (nota2 * .3) + (parcial * .4));

                arregloestudiantes[indice] = new estudiantes(nombre, edad, nota1, nota2, parcial, notafinal);
                Console.WriteLine("¿desea agregar otro registro? si/no");
                control = (Console.ReadLine());
                if (control == "si")

                {
                    indice = indice + 1;

                    Array.Resize(ref arregloestudiantes, arregloestudiantes.Length +);


                    {
                    else { control = "no"; }
                    }


                    while (control2 == "si") ;
                    {
                        Console.WriteLine("¿desea ver los estudiantes aprobados? ingrese 1");
                        Console.WriteLine("¿desea ver los estudiantes reprobados? ingrese 2");
                        if (opciones == 1)

                            enumerable<estudiantes> consultaestudiantes = from estudiantes in arregloestudiantes
                                                                          where estudiantes.notafinal >= 6
                                                                          select estudiantes;
                        foreach (estudiantes consulta in consultaestudiantes)
                        {

                            Console.WriteLine(consulta.mostrar());
                        }
                    }
                    else if (opciones == 3) ;
                    {
                        Console.WriteLine("¿desea continuar? si/no");
                        cerrar = Console.ReadLine();
                        if (cerrar == "no") ;

                        control2 = "no";
                    }
                }
                Console.Read();


