using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            int fibonacci = Fibonacci(i);
            Console.WriteLine($"Fibonacci({i}) = {fibonacci}");
        }

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            int a = 0;
            int b = 1;
            int temp = 0;

            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }

            return temp;
        }
    }
}