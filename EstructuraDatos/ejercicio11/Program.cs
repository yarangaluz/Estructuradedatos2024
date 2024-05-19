using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una lista de números separados por comas:");
        string entrada = Console.ReadLine();

        string[] numerosString = entrada.Split(',');
        int[] numeros = new int[numerosString.Length];

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Convert.ToInt32(numerosString[i]);
        }

        OrdenarNumeros(numeros);

        Console.WriteLine("Lista de números ordenados de menor a mayor:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static void OrdenarNumeros(int[] numeros)
    {
        int n = numeros.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }
    }
}