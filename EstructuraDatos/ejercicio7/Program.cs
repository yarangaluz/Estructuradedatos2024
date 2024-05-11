using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        int filas = 3;
        int columnas = 3;

        Complex[,] matriz = new Complex[filas, columnas];
        matriz[0, 0] = new Complex(5, -5);
        matriz[0, 1] = new Complex(9, 7);
        matriz[0, 2] = new Complex(-3, 8);
        matriz[1, 0] = new Complex(4, 1);
        matriz[1, 1] = new Complex(5, 3);
        matriz[1, 2] = new Complex(6, -2);
        matriz[2, 0] = new Complex(7, 4);
        matriz[2, 1] = new Complex(-8, 9);
        matriz[2, 2] = new Complex(0, 0);

        Console.WriteLine("Matriz de números complejos:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}