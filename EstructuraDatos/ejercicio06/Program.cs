using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una cadena de texto: ");
        string tex = Console.ReadLine();

        string texInvertido = InvertirTexto(tex);

        Console.WriteLine("La cadena de texto invertida es: " + texInvertido);

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static string InvertirTexto(string tex)
    {

        char[] caracteres = tex.ToCharArray();

        Array.Reverse(caracteres);

        string texInvertido = new string(caracteres);

        return texInvertido;
    }
}