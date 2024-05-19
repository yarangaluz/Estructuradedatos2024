using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var numeros = new List<int> { 10, 15, 20, 25, 30, 35, 40, 45, 50 };

        int divisor = 5;

        var numerosDivisibles = ObtenerNumerosDivisiblesPor(numeros, divisor);

        Console.WriteLine($"Números divisibles por {divisor}:");
        foreach (var numero in numerosDivisibles)
        {
            Console.WriteLine(numero);
        }
    }

    static List<int> ObtenerNumerosDivisiblesPor(List<int> numeros, int divisor)
    {
        return numeros.Where(n => n % divisor == 0).ToList();
    }
}
