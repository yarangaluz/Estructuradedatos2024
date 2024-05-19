using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        var palabras = new List<string>
        {
            "Manzana",
            "Melón",
            "Mango",
            "Banana",
            "Cereza",
            "Albaricoque",
            "Aguacate"
        };

        char letra = 'M';

        var palabrasFiltradas = ObtenerPalabrasQueComienzanConLetra(palabras, letra);

        Console.WriteLine($"Palabras que comienzan con '{letra}':");
        foreach (var palabra in palabrasFiltradas)
        {
            Console.WriteLine(palabra);
        }
    }

    static List<string> ObtenerPalabrasQueComienzanConLetra(List<string> palabras, char letra)
    {
        return palabras.Where(p => p.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase)).ToList();
    }
}