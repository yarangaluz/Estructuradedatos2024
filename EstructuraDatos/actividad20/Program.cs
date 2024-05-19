using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var palabras = new List<string> { "oso", "radar", "nivel", "reconocer", "oso", "cívico", "somos", "luzazul", "pera" };

        // Longitud deseada para las palabras
        int longitudDeseada = 5;

        // Obteniendo las palabras que son palíndromos, tienen la longitud determinada y están ordenadas de menor a mayor
        var palabrasFiltradas = ObtenerPalindromosDeLongitudOrdenados(palabras, longitudDeseada);

        Console.WriteLine($"Palíndromos de longitud {longitudDeseada} y ordenados de menor a mayor:");
        foreach (var palabra in palabrasFiltradas)
        {
            Console.WriteLine(palabra);
        }
    }

    static List<string> ObtenerPalindromosDeLongitudOrdenados(List<string> palabras, int longitud)
    {
        return palabras.Where(p => p.Length == longitud && EsPalindromo(p)).OrderBy(p => p).ToList();
    }

    static bool EsPalindromo(string palabra)
    {
        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}