using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAprobadasReprobadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadEstudiantes = 0, aprobados = 0, reprobados = 0;

            Console.WriteLine("Ingrese la cantidad de Estudiantes: ");
            cantidadEstudiantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.WriteLine("Ingrese la nota del estudiante {0}", i + 1);
                double nota = double.Parse(Console.ReadLine());

                if (nota >= 7)
                {
                    Console.WriteLine("El estudiantes esta aprobado");
                    aprobados++;
                }
                else
                {
                    reprobados++;
                    Console.WriteLine("El estudiantes esta reprobado");
                }
            }

            Console.WriteLine("El numero de estudiantes fueron: " + cantidadEstudiantes);
            Console.WriteLine("El numero de aprobados fue: " + aprobados);
            Console.WriteLine("El numero de reprobados fue: " + reprobados);


            //Uso del SWITCH

            //Console.WriteLine("Menu");
            //Console.WriteLine("1. Agregar");
            //Console.WriteLine("2. Eliminar");
            //Console.WriteLine("3. Editar");
            //Console.WriteLine("4. Salir");

            //Console.WriteLine("Ingrege una opcion del menu");
            //int opcionMenu = int.Parse(Console.ReadLine());

            //switch (opcionMenu)
            //{
            //    case 1:
            //        Console.WriteLine("Agregado correctamente");
            //        break;
            //    case 2:
            //        Console.WriteLine("Eliminado correctamente");
            //        break;
            //    case 3:
            //        Console.WriteLine("Editado correctamente");
            //        break;
            //    case 4:
            //        Console.WriteLine("Terminado correctamente");
            //        break;
            //    default:
            //        Console.WriteLine("Opcion no valida");
            //        break;
            //}

            Console.ReadKey();

        }
    }
}
