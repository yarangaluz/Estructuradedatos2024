using System;

public class Program
{
    public static void Main()
    {
        int filas = 100;
        int columnas = 100;

        Random random = new Random();

        int[,] matriz = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = random.Next(1000);
            }
        }
        Console.WriteLine("Matriz de números aleatorios:");
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