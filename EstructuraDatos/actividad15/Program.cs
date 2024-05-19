using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Obteniendo los números primos ordenados de menor a mayor
        var numerosPrimosOrdenados = ObtenerNumerosPrimosOrdenados(numeros);

        Console.WriteLine("Números primos ordenados de menor a mayor:");
        foreach (var numero in numerosPrimosOrdenados)
        {
            Console.WriteLine(numero);
        }
    }

    static List<int> ObtenerNumerosPrimosOrdenados(List<int> numeros)
    {
        return numeros.Where(EsPrimo).OrderBy(n => n).ToList();
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        if (numero <= 3)
            return true;
        if (numero % 2 == 0 || numero % 3 == 0)
            return false;

        int i = 5;
        while (i * i <= numero)
        {
            if (numero % i == 0 || numero % (i + 2) == 0)
                return false;
            i += 6;
        }
        return true;
    }
}