using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var numeros = new List<int> { 3, 2, 5, 8, 1, 6, 4, 7, 9, 2 };

        // Obteniendo los números ordenados de menor a mayor y sin duplicados
        var numerosOrdenadosSinDuplicados = ObtenerNumerosOrdenadosSinDuplicados(numeros);

        Console.WriteLine("Números ordenados de menor a mayor y sin duplicados:");
        foreach (var numero in numerosOrdenadosSinDuplicados)
        {
            Console.WriteLine(numero);
        }
    }

    static List<int> ObtenerNumerosOrdenadosSinDuplicados(List<int> numeros)
    {
        return numeros.Distinct().OrderBy(n => n).ToList();
    }
}