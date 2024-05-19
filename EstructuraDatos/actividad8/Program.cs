using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var palabras = new List<string> { "radar", "level", "world", "deified", "rotor", "hello", "civic", "madam", "refer", "python" };

        var palindromos = ObtenerPalindromos(palabras);

        Console.WriteLine("Palabras que son palíndromos:");
        foreach (var palabra in palindromos)
        {
            Console.WriteLine(palabra);
        }
    }

    static List<string> ObtenerPalindromos(List<string> palabras)
    {
        return palabras.Where(EsPalindromo).ToList();
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