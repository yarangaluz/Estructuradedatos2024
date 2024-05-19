using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
 
        var palabras = new List<string> { "manzana", "pera", "mango", "uva", "fresa", "tomate", "kiwi", "platano", "ceresa", "coco" };

        // Determinando la letra deseada
        char letraDeseada = 'a';

        // Obteniendo las palabras que contienen la letra especificada y están ordenadas de mayor a menor
        var palabrasConLetraOrdenadas = ObtenerPalabrasConLetraOrdenadas(palabras, letraDeseada);

        Console.WriteLine($"Palabras que contienen la letra '{letraDeseada}' y están ordenadas de mayor a menor:");
        foreach (var palabra in palabrasConLetraOrdenadas)
        {
            Console.WriteLine(palabra);
        }
    }

    static List<string> ObtenerPalabrasConLetraOrdenadas(List<string> palabras, char letra)
    {
        return palabras.Where(p => p.Contains(letra))
                       .OrderByDescending(p => p)
                       .ToList();
    }
}