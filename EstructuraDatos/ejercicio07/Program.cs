using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número inicial del rango: ");
        int inicio = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el número final del rango: ");
        int fin = Convert.ToInt32(Console.ReadLine());

        int sumaPares = SumarNumerosParesEnRango(inicio, fin);

        Console.WriteLine($"La suma de los números pares en el rango [{inicio}, {fin}] es: {sumaPares}");

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static int SumarNumerosParesEnRango(int inicio, int fin)
    {
        int suma = 0;

        for (int i = inicio; i <= fin; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
        }

        return suma;
    }
}