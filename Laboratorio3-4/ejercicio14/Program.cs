using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[,] matriz = new int[5, 5] { { 2, 4, 6, 8, 10 },
                                         { 1, 3, 5, 7, 9 },
                                         { 11, 13, 15, 17, 19 },
                                         { 12, 14, 16, 18, 20 },
                                         { 21, 23, 25, 27, 29 } };

        double media = CalcularMedia(matriz);
        Console.WriteLine("Media de los elementos de la matriz: " + media);

        double mediana = CalcularMediana(matriz);
        Console.WriteLine("Mediana de los elementos de la matriz: " + mediana);

        double desviacionEstandar = CalcularDesviacionEstandar(matriz);
        Console.WriteLine("Desviación estándar de los elementos de la matriz: " + desviacionEstandar);
    }

    public static double CalcularMedia(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int totalElementos = filas * columnas;
        int sumaTotal = 0;

        foreach (int elemento in matriz)
        {
            sumaTotal += elemento;
        }

        return (double)sumaTotal / totalElementos;
    }

    public static double CalcularMediana(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int totalElementos = filas * columnas;
        int[] elementosOrdenados = new int[totalElementos];
        int indice = 0;

        foreach (int elemento in matriz)
        {
            elementosOrdenados[indice++] = elemento;
        }

        Array.Sort(elementosOrdenados);

        if (totalElementos % 2 == 0)
        {
   
            int medio1 = elementosOrdenados[totalElementos / 2 - 1];
            int medio2 = elementosOrdenados[totalElementos / 2];
            return (double)(medio1 + medio2) / 2;
        }
        else
        {
            return elementosOrdenados[totalElementos / 2];
        }
    }

    public static double CalcularDesviacionEstandar(int[,] matriz)
    {
        double media = CalcularMedia(matriz);
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int totalElementos = filas * columnas;
        double sumaCuadradosDiferencias = 0;

        foreach (int elemento in matriz)
        {
            sumaCuadradosDiferencias += Math.Pow(elemento - media, 2);
        }

        double varianza = sumaCuadradosDiferencias / totalElementos;

        return Math.Sqrt(varianza);
    }
}