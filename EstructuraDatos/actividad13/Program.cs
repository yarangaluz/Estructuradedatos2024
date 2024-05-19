using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var numeros = new List<int> { 1, 2, 3, 4, 5, 2, 7, 3, 9, 5 };

        var numerosDuplicados = ObtenerNumerosDuplicados(numeros);

        Console.WriteLine("Números duplicados:");
        foreach (var numero in numerosDuplicados)
        {
            Console.WriteLine(numero);
        }
    }

    static List<int> ObtenerNumerosDuplicados(List<int> numeros)
    {
        return numeros.GroupBy(n => n)
                      .Where(g => g.Count() > 1)
                      .Select(g => g.Key)
                      .ToList();
    }
}