using System;

public class Program
{
    public static void Main()
    {
        int filas1 = 3;
        int columnas1 = 3;
        int filas2 = 3;
        int columnas2 = 3;

        int[,] matriz1 = new int[filas1, columnas1];
        int[,] matriz2 = new int[filas2, columnas2];

        for (int i = 0; i < filas1; i++)
        {
            for (int j = 0; j < columnas1; j++)
            {
                matriz1[i, j] = i * columnas1 + j + 1;
            }
        }

        for (int i = 0; i < filas2; i++)
        {
            for (int j = 0; j < columnas2; j++)
            {
                matriz2[i, j] = (i + 1) * columnas2 + j + 1;
            }
        }

        if (filas1 != filas2 || columnas1 != columnas2)
        {
            Console.WriteLine("No es posible sumar las matrices porque tienen diferentes dimensiones.");
            return;
        }

        int[,] sumaMatrices = new int[filas1, columnas1];
        for (int i = 0; i < filas1; i++)
        {
            for (int j = 0; j < columnas1; j++)
            {
                sumaMatrices[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        Console.WriteLine("Matriz resultante de la suma:");
        for (int i = 0; i < filas1; i++)
        {
            for (int j = 0; j < columnas1; j++)
            {
                Console.Write(sumaMatrices[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}