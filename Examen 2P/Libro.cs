using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2P
{
    internal class Libro
    {
        public Libro(string nombre, string autor, string editorial, int noPaginas, string idioma)
        {
            Nombre = nombre;
            Autor = autor;
            Editorial = editorial;
            NoPaginas = noPaginas;
            Idioma = idioma;
        }
        public Libro() { }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int NoPaginas { get; set; }
        public string Idioma { get; set; }
    }
}
