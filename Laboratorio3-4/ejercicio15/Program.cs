using System;

public class Program
{
    public static void Main()
    {
        int[,] matriz = new int[5, 5] { { 2, 4, 6, 8, 10 },
                                         { 1, 3, 5, 7, 9 },
                                         { 11, 13, 15, 17, 19 },
                                         { 12, 14, 16, 18, 20 },
                                         { 21, 23, 25, 27, 45 } };

        int maximo = EncontrarMaximo(matriz);
        Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
    }

    public static int EncontrarMaximo(int[,] matriz)
    {
        int maximo = matriz[0, 0]; 
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] > maximo)
                {
                    maximo = matriz[i, j]; 
                }
            }
        }

        return maximo;
    }
}