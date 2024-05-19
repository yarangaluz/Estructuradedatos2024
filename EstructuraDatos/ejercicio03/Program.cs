using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingreese la base del triángulo: ");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura del triángulo: ");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

        Console.WriteLine($"El área del triángulo con base {baseTriangulo} y altura {alturaTriangulo} es: {areaTriangulo}");

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}