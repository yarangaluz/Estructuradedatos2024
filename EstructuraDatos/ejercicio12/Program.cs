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

        int sumaTotal = 0;
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                sumaTotal += matriz[i, j];
            }
        }

        int totalElementos = filas * columnas;

        double media = (double)sumaTotal / totalElementos;

        Console.WriteLine("Media de los elementos de la matriz: " + media);
    }
}