using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2P
{
    internal class Program
    {
        public enum Menu
        {
            Agregar=1,Mostrar,Contar,Eliminar,Actualizar,Salir
        }
        static void Main(string[] args)
        {
           Acciones acc = new Acciones();
            while (true) 
            {
                switch (menu())
                {
                    case Menu.Agregar:
                        acc.AgregarLibro();
                        break;
                    case Menu.Mostrar:
                        acc.MostrarLibros();
                        break;
                    case Menu.Contar:
                        Console.WriteLine("El numero de libros es: "+acc.ContarLibros());
                        break;
                    case Menu.Eliminar:
                        Console.WriteLine("Dime el nombre del libro que quieres eliminar");
                        string nombre=Console.ReadLine();
                        acc.EliminarLibros(nombre);
                        break;
                    case Menu.Actualizar:
                        acc.ActualizarLibros();
                        break;
                    case Menu.Salir:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción Invalida");
                        break;
                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Contar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Actualizar");
            Console.WriteLine("6. Salir");
            Menu opc = (Menu)Convert.ToUInt32(Console.ReadLine());
            return opc;

        }
    }
}
