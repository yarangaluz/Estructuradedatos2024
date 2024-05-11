using System;

public class Program
{
    public static void Main()
    {

        int[,] matriz = new int[,] {
            {1, 2, -1, -5, -20},
            {-8, 4, 11, 2, 1},
            {3, 8, 10, 1, 3},
            {-4, -1, 1, 7, -6}
        };

        int sumaMaxima = 0;
        int submatrizFilaInicio = 0;
        int submatrizFilaFin = 0;
        int submatrizColumnaInicio = 0;
        int submatrizColumnaFin = 0;

        EncontrarSubmatrizMaxima(matriz, out sumaMaxima, out submatrizFilaInicio, out submatrizFilaFin, out submatrizColumnaInicio, out submatrizColumnaFin);

        Console.WriteLine("La submatriz de mayor suma es:");
        for (int i = submatrizFilaInicio; i <= submatrizFilaFin; i++)
        {
            for (int j = submatrizColumnaInicio; j <= submatrizColumnaFin; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("La suma de la submatriz de mayor suma es: " + sumaMaxima);
    }

    public static void EncontrarSubmatrizMaxima(int[,] matriz, out int sumaMaxima, out int submatrizFilaInicio, out int submatrizFilaFin, out int submatrizColumnaInicio, out int submatrizColumnaFin)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        sumaMaxima = int.MinValue;
        submatrizFilaInicio = 0;
        submatrizFilaFin = 0;
        submatrizColumnaInicio = 0;
        submatrizColumnaFin = 0;

        for (int i = 0; i < filas; i++)
        {
            int[] temp = new int[columnas];

            for (int j = i; j < filas; j++)
            {
                for (int k = 0; k < columnas; k++)
                {
                    temp[k] += matriz[j, k];
                }

                int maxActual = 0;
                int submatrizColumnaInicioActual = 0;

                for (int k = 0; k < columnas; k++)
                {
                    maxActual += temp[k];

                    if (maxActual < 0)
                    {
                        maxActual = 0;
                        submatrizColumnaInicioActual = k + 1;
                    }

                    if (maxActual > sumaMaxima)
                    {
                        sumaMaxima = maxActual;
                        submatrizFilaInicio = i;
                        submatrizFilaFin = j;
                        submatrizColumnaInicio = submatrizColumnaInicioActual;
                        submatrizColumnaFin = k;
                    }
                }
            }
        }
    }
}