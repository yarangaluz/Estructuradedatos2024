using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra para verificar si es un palíndromo: ");
        string palabra = Console.ReadLine();

        bool esPalindromo = VerificarPalindromo(palabra);

        if (esPalindromo)
        {
            Console.WriteLine($"La palabra \"{palabra}\" es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"La palabra \"{palabra}\" no es un palíndromo.");
        }

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static bool VerificarPalindromo(string palabra)
    {
        palabra = palabra.ToLower();

        string palabraInvertida = InvertirPalabra(palabra);

        return palabra == palabraInvertida;
    }

    static string InvertirPalabra(string palabra)
    {
        char[] caracteres = palabra.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
}