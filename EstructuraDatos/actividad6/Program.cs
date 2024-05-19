using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var conjunto1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var conjunto2 = new List<int> { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        var diferencia = ObtenerDiferencia(conjunto2, conjunto1);


        Console.WriteLine("Números en el segundo conjunto pero no en el primero:");
        foreach (var numero in diferencia)
        {
            Console.WriteLine(numero);
        }
    }

    static List<int> ObtenerDiferencia(List<int> conjuntoA, List<int> conjuntoB)
    {
        return conjuntoA.Except(conjuntoB).ToList();
    }
}