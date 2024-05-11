using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Ingresa un número entero positivo para el tamaño de la pirámide invertida: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("El número ingresado debe ser positivo.");
        }
        else
        {
            PrintPiramideInvertida(n);
        }
    }

    public static void PrintPiramideInvertida(int n)
    {
        PrintPiramideInvertidaHelper(n, n);
    }

    public static void PrintPiramideInvertidaHelper(int numeroFila, int n)
    {
        if (numeroFila > 0)
        {
            PrintInvertirFila(1, numeroFila);
            Console.WriteLine();
            PrintPiramideInvertidaHelper(numeroFila - 1, n);
        }
    }

    public static void PrintInvertirFila(int start, int end)
    {
        if (start <= end)
        {
            Console.Write(end + " ");
            PrintInvertirFila(start, end - 1);
        }
    }
}