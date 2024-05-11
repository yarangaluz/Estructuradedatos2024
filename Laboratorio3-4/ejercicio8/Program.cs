using System;

public class Program
{
    public static void Main()
    {
        int filas = 2;
        int columnas = 2;

        int[][][] matrizDeMatrices = new int[filas][][];

        matrizDeMatrices[0] = new int[2][]; 
        matrizDeMatrices[0][0] = new int[] { 1, 2 };
        matrizDeMatrices[0][1] = new int[] { 3, 4, 5 };

        matrizDeMatrices[1] = new int[3][]; 
        matrizDeMatrices[1][0] = new int[] { 6 };
        matrizDeMatrices[1][1] = new int[] { 7, 8, 9 };
        matrizDeMatrices[1][2] = new int[] { 10, 11 };

        Console.WriteLine("Matriz de matrices:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write("[ ");
                if (matrizDeMatrices[i][j] != null)
                {
                    foreach (int elemento in matrizDeMatrices[i][j])
                    {
                        Console.Write(elemento + " ");
                    }
                }
                Console.Write("] ");
            }
            Console.WriteLine();
        }
    }
}