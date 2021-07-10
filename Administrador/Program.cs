using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1;



namespace Administrador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****************Administracion*****************");


            Console.WriteLine("\n Menu de Opciones");
            Console.WriteLine("\n1.-Crear Usuario");
            Console.WriteLine("\n2-Salir");

            string opcion;

            do
            {
                opcion = Console.ReadLine();

                if (opcion != "1" && opcion != "2") ;
                {
                    Console.WriteLine("\n Verificar Opcion ingresada debe ser 1 o 2");

                }

            } while (opcion != "1" && opcion != "2");

            if (opcion == "1")
            {
                Console.WriteLine("\n Ingrese el nombre del Usuario");
                string usuario = Console.ReadLine();

                Console.WriteLine("\n Ingrese la contrasena");
                string contrasena = Console.ReadLine();

                Usuario.CrearUsuario(usuario.Trim, contrasena);
                Console.WriteLine("\n El usuario ha sido agreado con exito");

                else
                {
                    Console.WriteLine("\nIngrese Cualquier tecla para salir");
                    Console.ReadLine();
                }

            }
        }
    }
}
