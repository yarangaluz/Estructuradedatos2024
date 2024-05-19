using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        List<int> cuadrados = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            int cuadrado = i * i;
            cuadrados.Add(cuadrado);
        }

        Console.WriteLine("Cuadrados de los primeros 10 números naturales:");
        foreach (int cuadrado in cuadrados)
        {
            Console.WriteLine(cuadrado);
        }

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}