using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var palabras = new List<string> { "manzana", "pera", "mango", "uva", "fresa", "tomate", "kiwi", "platano", "ceresa", "coco" };

        int longitudDeseada = 5;

        // Obteniendo las palabras con la longitud especificada y ordenadas
        var palabrasOrdenadasPorLongitud = ObtenerPalabrasOrdenadasPorLongitud(palabras, longitudDeseada);

        Console.WriteLine($"Palabras con longitud de {longitudDeseada} caracteres, ordenadas de menor a mayor:");
        foreach (var palabra in palabrasOrdenadasPorLongitud)
        {
            Console.WriteLine(palabra);
        }
    }

    static List<string> ObtenerPalabrasOrdenadasPorLongitud(List<string> palabras, int longitud)
    {
        return palabras.Where(p => p.Length == longitud)
                       .OrderBy(p => p)
                       .ToList();
    }
}