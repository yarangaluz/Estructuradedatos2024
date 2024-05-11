using System;

public class Program
{
    public static void Main()
    {
        double[,] matriz1 = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[,] matriz2 = new double[,] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

        double[,] covarianza = CalcularMatrizCovarianza(matriz1, matriz2);

        Console.WriteLine("Matriz de covarianza:");
        for (int i = 0; i < covarianza.GetLength(0); i++)
        {
            for (int j = 0; j < covarianza.GetLength(1); j++)
            {
                Console.Write(covarianza[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static double[,] CalcularMatrizCovarianza(double[,] matriz1, double[,] matriz2)
    {
        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);
        int totalElementos = filas * columnas;

        double mediaMatriz1 = CalcularMedia(matriz1);
        double mediaMatriz2 = CalcularMedia(matriz2);

        double[,] covarianza = new double[2, 2];

        double covarianza11 = 0; 
        double covarianza12 = 0; 
        double covarianza21 = 0; 
        double covarianza22 = 0; 

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                covarianza11 += (matriz1[i, j] - mediaMatriz1) * (matriz1[i, j] - mediaMatriz1);
                covarianza12 += (matriz1[i, j] - mediaMatriz1) * (matriz2[i, j] - mediaMatriz2);
                covarianza21 += (matriz2[i, j] - mediaMatriz2) * (matriz1[i, j] - mediaMatriz1);
                covarianza22 += (matriz2[i, j] - mediaMatriz2) * (matriz2[i, j] - mediaMatriz2);
            }
        }

        covarianza11 /= totalElementos;
        covarianza12 /= totalElementos;
        covarianza21 /= totalElementos;
        covarianza22 /= totalElementos;

        covarianza[0, 0] = covarianza11;
        covarianza[0, 1] = covarianza12;
        covarianza[1, 0] = covarianza21;
        covarianza[1, 1] = covarianza22;

        return covarianza;
    }

    public static double CalcularMedia(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int totalElementos = filas * columnas;

        double sumaTotal = 0;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                sumaTotal += matriz[i, j];
            }
        }

        return sumaTotal / totalElementos;
    }
}
