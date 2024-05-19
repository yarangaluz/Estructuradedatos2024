using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una cadena de texto: ");
        string texto = Console.ReadLine();

        int contadorVocales = ContarVocales(texto);

        Console.WriteLine($"El número de vocales en la cadena de texto es: {contadorVocales}");

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }

    static int ContarVocales(string texto)
    {
     
        texto = texto.ToLower();

        int contador = 0;

        foreach (char caracter in texto)
        {
            if (EsVocal(caracter))
            {
                contador++;
            }
        }

        return contador;
    }

    static bool EsVocal(char caracter)
    {
        return "aeiou".Contains(caracter);
    }
}