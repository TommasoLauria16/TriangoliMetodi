using System;
using LibreriaTriangoli;

namespace TriangoliMetodi
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1 = MetodiTriangoli.MisuraLato();
            double l2 = MetodiTriangoli.MisuraLato();
            double l3 = MetodiTriangoli.MisuraLato();
            double? perimetro = MetodiTriangoli.Perimetro(l1, l2, l3);
            string risultato = MetodiTriangoli.RiconosciTriangoli(l1, l2, l3);
            Console.WriteLine($"IL TRIANGOLO E' {risultato};\nIL PERIMETRO E' {perimetro}. ");
        }
    }
}
