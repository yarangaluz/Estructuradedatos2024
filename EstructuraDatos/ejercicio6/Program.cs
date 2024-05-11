using System;

public class Program
{
    public static void Main()
    {
        int filas = 3;
        int columnas = 3;

        double[,] matriz = new double[filas, columnas];
        matriz[0, 0] = 5.5;
        matriz[0, 1] = 9.7;
        matriz[0, 2] = 3.8;
        matriz[1, 0] = 4.1;
        matriz[1, 1] = 5.3;
        matriz[1, 2] = 6.2;
        matriz[2, 0] = 7.4;
        matriz[2, 1] = 8.9;
        matriz[2, 2] = 9.0;

        Console.WriteLine("Matriz de números reales:");
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