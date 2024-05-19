using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double area = CalcularAreaCirculo(radio);

        Console.WriteLine($"El área del círculo con radio {radio} es: {area}");

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}