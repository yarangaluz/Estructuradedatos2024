using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var palabras = new List<string> { "manzana", "pera", "mango", "uva", "fresa", "tomate", "kiwi", "platano", "ceresa", "coco" };

        char letraDeseada = 'a';

        var palabrasConLetra = ObtenerPalabrasConLetra(palabras, letraDeseada);

        Console.WriteLine($"Palabras que contienen la letra '{letraDeseada}':");
        foreach (var palabra in palabrasConLetra)
        {
            Console.WriteLine(palabra);
        }
    }

    static List<string> ObtenerPalabrasConLetra(List<string> palabras, char letra)
    {
        return palabras.Where(p => p.IndexOf(letra, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
    }
}