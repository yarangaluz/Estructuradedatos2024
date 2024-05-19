using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Empleado
    {
        

public class Arquitecto
    {
        private int codigo;
        private string nombres;
        private string condicionContrato;
        private string especialidad;
        private string tipoActividad;
        private string tipoAfiliacion;

        public Arquitecto(int codigo, string nombres, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliacion)
        {
            this.codigo = codigo;
            this.nombres = nombres;
            this.condicionContrato = condicionContrato;
            this.especialidad = especialidad;
            this.tipoActividad = tipoActividad;
            this.tipoAfiliacion = tipoAfiliacion;
        }

        public int CalcularSueldoBase()
        {
            switch (condicionContrato)
            {
                case "Estable":
                    return 4000;
                case "Contratado":
                    return 2000;
                default:
                    throw new ArgumentException("Condición de contrato no válida: " + condicionContrato);
            }
        }

        public double CalcularBonificacion()
        {
            switch (especialidad)
            {
                case "Estructuras":
                    return 0.16;
                case "Recursos Hídricos":
                    return 0.18;
                default:
                    throw new ArgumentException("Especialidad no válida: " + especialidad);
            }
        }

        public double CalcularDescuentos()
        {
            return 0.15 + 0.08;
        }

        public double CalcularSueldoNeto()
        {
            double sueldoBruto = CalcularSueldoBase() + CalcularBonificacion() * CalcularSueldoBase();
            double descuentos = CalcularDescuentos() * sueldoBruto;
            return sueldoBruto - descuentos;
        }

        public double CalcularSueldoBruto()
        {
            return CalcularSueldoBase() + CalcularBonificacion() * CalcularSueldoBase();
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Codigo: " + codigo);
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Condición de contrato: " + condicionContrato);
            Console.WriteLine("Especialidad: " + especialidad);
            Console.WriteLine("Tipo de actividad: " + tipoActividad);
            Console.WriteLine("Tipo de afiliación: " + tipoAfiliacion);
            Console.WriteLine("Sueldo base: " + CalcularSueldoBase());
            Console.WriteLine("Bonificación: " + CalcularBonificacion() * 100 + "%");
            Console.WriteLine("Descuentos: " + CalcularDescuentos() * 100 + "%");
            Console.WriteLine("Sueldo bruto: " + CalcularSueldoBruto());
        }
    }
}
}
