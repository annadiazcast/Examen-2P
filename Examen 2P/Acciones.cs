using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2P
{
    internal class Acciones
    {
        public List<Libro> listalibros=new List<Libro>();
        Libro Libros=new Libro();
        
        public void AgregarLibro()
        {for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Dame el nombre del libro");
                Libros.Nombre = Console.ReadLine();
                Console.WriteLine("Dame el autor");
                Libros.Autor = Console.ReadLine();
                Console.WriteLine("Dame la editorial");
                Libros.Editorial = Console.ReadLine();
                Console.WriteLine("Dame el no. de paginas");
                Libros.NoPaginas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dame el idioma del libro");
                Libros.Idioma = Console.ReadLine();
                Console.WriteLine(" ");
                listalibros.Add(new Libro(Libros.Nombre, Libros.Autor, Libros.Editorial, Libros.NoPaginas, Libros.Idioma));
            }

                
          
        }
        public void MostrarLibros()
        {
            foreach (var l in listalibros)
            {
                Console.WriteLine("Nombre del libro: "+l.Nombre);
                Console.WriteLine("Autor: "+l.Autor);
                Console.WriteLine("Editorial: "+l.Editorial);
                Console.WriteLine("No. Pagina: "+l.NoPaginas);
                Console.WriteLine("Idioma: "+l.Idioma);
            }
        }
        public int ContarLibros()
        {
            return listalibros.Count;
        }
        public void EliminarLibros(string NombreLibro)
        {
            var libro=listalibros.Find(y=>y.Nombre==NombreLibro);
            if (libro != null)
            { listalibros.Remove(libro); }
            else
            {
                Console.WriteLine("No se encontro el libro");
            }
        }
        public void ActualizarLibros()
        {
            Console.WriteLine("Dame el nombre del libro que deseas actualizar");
            string Nombreantiguo=Console.ReadLine();

            var libro = listalibros.Find(y => y.Nombre == Nombreantiguo);
            if (libro==null)
            {
                Console.WriteLine("Dame el nuevo nombre del libro");
                string nuevonombre=Console.ReadLine();
                Console.WriteLine("Dame el nuevo autor");
                string nuevoautor=Console.ReadLine();
                Console.WriteLine("Dame la nueva editorial");
                string nuevaeditorial=Console.ReadLine();
                Console.WriteLine("Dame el nuevo no. de paginas");
                int nuevonopaginas=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dame el nuevo idioma");
                string nuevoidioma=Console.ReadLine();

                libro.Nombre = nuevonombre;
                libro.Autor = nuevoautor;
                libro.Editorial= nuevaeditorial;
                libro.NoPaginas= nuevonopaginas;
                libro.Idioma = nuevoidioma;
                Console.WriteLine("Los datos se han actualizado con exito");
            }
            else
            {
                Console.WriteLine("No se ha encontrado el libro");
            }
        }


    }
}
