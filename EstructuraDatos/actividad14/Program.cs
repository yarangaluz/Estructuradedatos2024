using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var numeros = new List<int> { 1, 2, 3, 4, 5, 2, 7, 3, 9, 5 };

        var numerosNoDuplicados = ObtenerNumerosNoDuplicados(numeros);

        Console.WriteLine("Números que no están duplicados:");
        foreach (var numero in numerosNoDuplicados)
        {
            Console.WriteLine(numero);
        }
    }

    static List<int> ObtenerNumerosNoDuplicados(List<int> numeros)
    {
        return numeros.GroupBy(n => n)
                      .Where(g => g.Count() == 1)
                      .Select(g => g.Key)
                      .ToList();
    }
}