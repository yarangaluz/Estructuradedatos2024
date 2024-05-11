using System;

public class Ejercicio1
{
    public static void Main()
    {

        PrintNumerosPares(1);
    }
    public static void PrintNumerosPares(int num)
    {
        if (num <= 100)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
            PrintNumerosPares(num + 1);
        }
    }
}

