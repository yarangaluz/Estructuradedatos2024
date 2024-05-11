using System;

public class Program
{
    public static void Main()
    {
        int filas = 3;
        int columnas = 3;

        int[,] matriz = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = i * columnas + j + 1;
            }
        }

        int numero = 2;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] *= numero;
            }
        }

        Console.WriteLine("Matriz resultante:");
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