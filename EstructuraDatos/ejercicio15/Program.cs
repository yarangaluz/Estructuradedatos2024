using System;

class Program
{
    static void Main()
    {

        Console.Write("Ingrese un número entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int suma = CalcularSumaDigitos(numero);

        Console.WriteLine($"La suma de los dígitos de {numero} es: {suma}");

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static int CalcularSumaDigitos(int numero)
    {

        int suma = 0;

        while (numero != 0)
        {
            int digito = numero % 10;

            suma += digito;

            numero /= 10;
        }

        return suma;
    }
}