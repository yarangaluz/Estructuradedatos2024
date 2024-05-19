using System;
class program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine($"El número {num} es par.");
        }
        else
        {
            Console.WriteLine($"El número {num} es impar.");
        }
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}