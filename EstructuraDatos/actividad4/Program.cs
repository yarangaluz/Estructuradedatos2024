using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var conjunto1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var conjunto2 = new List<int> { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        var interseccion = ObtenerInterseccion(conjunto1, conjunto2);


        Console.WriteLine("Números en ambos conjuntos:");
        foreach (var numero in interseccion)
        {
            Console.WriteLine(numero);
        }
    }

    static List<int> ObtenerInterseccion(List<int> conjunto1, List<int> conjunto2)
    {
        return conjunto1.Intersect(conjunto2).ToList();
    }
}