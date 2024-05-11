using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        Console.Write("Ingresa un número entero positivo para el tamaño de la pirámide: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("El número ingresado debe ser positivo.");
        }
        else
        {
            PrintPiramide(1, n);
        }
    }
        public static void PrintPiramide(int numeroFilas, int n)
        {
            if (numeroFilas <= n)
            {
                PrintFilas(1, numeroFilas);
                Console.WriteLine();
                PrintPiramide(numeroFilas + 1, n);
            }
        }
        public static void PrintFilas(int start, int end)
        {
            if(start <= end)
            {
                Console.Write(start + " ");
                PrintFilas(start + 1, end);
            }
        }
}