using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var palabras = new List<string> { "manzana", "pera", "mango", "uva", "fresa", "tomate", "kiwi", "platano", "ceresa", "coco" };

        int longitudDeseada = 5;

        var palabrasConLongitud = ObtenerPalabrasConLongitud(palabras, longitudDeseada);

        Console.WriteLine($"Palabras con longitud de {longitudDeseada} caracteres:");
        foreach (var palabra in palabrasConLongitud)
        {
            Console.WriteLine(palabra);
        }
    }

    static List<string> ObtenerPalabrasConLongitud(List<string> palabras, int longitud)
    {
        return palabras.Where(p => p.Length == longitud).ToList();
    }
}