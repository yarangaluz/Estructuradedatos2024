using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double suma = num1 + num2;
        double resta = num1 - num2;
        double multiplicacion = num1 * num2;

        double division = 0;
        if (num2 != 0)
        {
            division = num1 / num2;
        }
        else
        {
            Console.WriteLine("No es posible dividir por cero.");
        }

        Console.WriteLine($"La suma de {num1} y {num2}");
        Console.WriteLine($"La resta de {num1} y {num2} es: {resta}");
        Console.WriteLine($"La multiplicación de {num1} y {num2} es: {multiplicacion}");
        if (num2 != 0)
        {
            Console.WriteLine($"La división de {num2} y {num2} es: {division}");
        }
        Console.WriteLine("Presione cualquier tecla para salir");
        Console.ReadKey();
    }
}