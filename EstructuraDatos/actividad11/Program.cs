using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
 
        var numeros = new List<int> { 10, 3, 5, 8, 2, 6, 1, 9, 7, 4 };

        var numerosOrdenados = ObtenerNumerosOrdenados(numeros);

        Console.WriteLine("Números ordenados de menor a mayor:");
        foreach (var numero in numerosOrdenados)
        {
            Console.WriteLine(numero);
        }
    }

    static List<int> ObtenerNumerosOrdenados(List<int> numeros)
    {
        return numeros.OrderBy(n => n).ToList();
    }
}