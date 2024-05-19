using System;
public class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cadena de texto: ");
        string texto = Console.ReadLine();

        int contadorVocales = contarVocales(texto);

        Console.WriteLine($"la cantidad de vocales en el texto {texto} es: {contadorVocales}");
        Console.WriteLine("presione para salir.");
        Console.ReadLine();
    }
    static int contarVocales(string texto)
    {
        texto = texto.ToLower();
        int contador = 0;
        foreach(char caracter in texto)
        {
            if(EsVocal(caracter))
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