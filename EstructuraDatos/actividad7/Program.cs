using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creando un conjunto de palabras
        var palabras = new List<string> { "listen", "silent", "enlist", "inlets", "google", "goolge", "cat", "act", "tac", "rat", "tar", "art" };

        // Obteniendo los anagramas
        var anagramas = ObtenerAnagramas(palabras);

        // Mostrando el resultado
        Console.WriteLine("Palabras que son anagramas:");
        foreach (var grupo in anagramas)
        {
            Console.WriteLine(string.Join(", ", grupo));
        }
    }

    static List<List<string>> ObtenerAnagramas(List<string> palabras)
    {
        // Agrupar palabras por su versión ordenada de letras
        var gruposAnagramas = palabras.GroupBy(p => new string(p.OrderBy(c => c).ToArray()))
                                      .Where(g => g.Count() > 1)
                                      .Select(g => g.ToList())
                                      .ToList();

        return gruposAnagramas;
    }
}