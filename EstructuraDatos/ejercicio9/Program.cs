using System;

public class Program
{
    public static void Main()
    {
        int filas = 5;
        int columnas = 5;

        int[,] matriz = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = i * columnas + j + 1;
            }
        }

        int filaCentral = filas / 2;
        int columnaCentral = columnas / 2;

        int elementoCentral = matriz[filaCentral, columnaCentral];

        Console.WriteLine("Elemento central de la matriz: " + elementoCentral);
    }
}