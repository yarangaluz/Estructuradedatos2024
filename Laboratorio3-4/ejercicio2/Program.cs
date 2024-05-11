using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Ejercicio2
    {
        public static void Main()
        {
            Console.Write("Ingresar un número entero positivo: ");
            int n = Convert.ToInt32(Console.Read());

            if (n <= 0)
            {
                Console.WriteLine("El número ingresado debe ser positivo.");
            }
            else
            {
                int suma = SumaNumeros(1, n);
                Console.WriteLine("La suma de los números del 1 al " + n + " es : " + suma);
            }
        }
        public static int SumaNumeros(int inicio, int n)
        {
            if (inicio <= n)
            {
                return inicio + SumaNumeros(inicio + 1, n);
            }
            else
            {
                return 0;
            }
        }
    }