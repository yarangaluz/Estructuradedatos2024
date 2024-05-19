using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> num = new List<int> { 2, 3, 4, 5, 6, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        List<int> primos = ObtenerNumerosPrimos(num);

        Console.WriteLine("Números primos:");
        foreach (int primo in primos)
        {
            Console.WriteLine(primo);
        }
    }

    static bool EsPrimo(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static List<int> ObtenerNumerosPrimos(List<int> numeros)
    {
        List<int> numerosPrimos = new List<int>();

        foreach (int num in numeros)
        {
            if (EsPrimo(num))
            {
                numerosPrimos.Add(num);
            }
        }

        return numerosPrimos;
    }
}
    
