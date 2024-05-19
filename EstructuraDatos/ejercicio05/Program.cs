using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número para verificar si es primo: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool esPrimo = VerificarPrimo(num);

        if (esPrimo)
        {
            Console.WriteLine($"El número {num} es primo.");
        }
        else
        {
            Console.WriteLine($"El número {num} no es primo.");
        }

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static bool VerificarPrimo(int num)
    {

        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}