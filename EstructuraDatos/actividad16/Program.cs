using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var palabras = new List<string> { "radar", "level", "deified", "civic", "noon", "rotor", "stats", "madam", "apple" };

        // Obteniendo los palíndromos ordenados de menor a mayor
        var palindromosOrdenados = ObtenerPalindromosOrdenados(palabras);

        Console.WriteLine("Palíndromos ordenados de menor a mayor:");
        foreach (var palabra in palindromosOrdenados)
        {
            Console.WriteLine(palabra);
        }
    }

    static List<string> ObtenerPalindromosOrdenados(List<string> palabras)
    {
        return palabras.Where(EsPalindromo).OrderBy(p => p).ToList();
    }

    static bool EsPalindromo(string palabra)
    {
        int longitud = palabra.Length;
        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}