using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Ingresa un número entero para la tabla de multiplicar: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("El número ingresado debe ser positivo.");
        }
        else
        {
            PrintTabladeMultiplicar(n, 1);
        }
    }

    public static void PrintTabladeMultiplicar(int n, int multiplicador)
    {
        if (multiplicador <= 10)
        {
            Console.WriteLine(n + " x " + multiplicador + " = " + (n * multiplicador));
            PrintTabladeMultiplicar(n, multiplicador + 1);
        }
    }
}