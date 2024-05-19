using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número para calcular su factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());

        long factorial = CalcularFactorial(num);
        Console.WriteLine($"El factorial de {num} es: {factorial}");

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static long CalcularFactorial(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1; 
        }
        else
        {
            long factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}