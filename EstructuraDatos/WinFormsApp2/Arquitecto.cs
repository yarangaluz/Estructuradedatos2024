using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Arquitecto
    {
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string CondicionContrato { get; set; }
        public string TipoEspecialidad { get; set; }
        public string TipoActividad { get; set; }
        public string TipoAfiliacion { get; set; }
        private static decimal porc_Afp = (decimal)0.15;
        private static decimal porc_Snp = (decimal)0.08;
        private static int contador = 0;

        public Arquitecto(string codigo, string nombres, string condicionContrato, string tipoEspecialidad, string tipoActividad, string tipoAfiliacion)
        {
            contador++;
            Codigo = codigo;
            Nombres = nombres;
            CondicionContrato = condicionContrato;
            TipoEspecialidad = tipoEspecialidad;
            TipoActividad = tipoActividad;
            TipoAfiliacion = tipoAfiliacion;
        }

        public decimal CalcularSueldoBase()
        {
            if (CondicionContrato == "Estable")
            {
                if (TipoActividad == "Supervision de Obras")
                    return 4000;
                if (TipoActividad == "Supervision de Vias")
                    return 6000;
            }
            else if (CondicionContrato == "Contratado")
            {
                if (TipoActividad == "Supervision de Obras")
                    return 2000;
                if (TipoActividad == "Supervision de Vias")
                    return 4500;
            }
            return 0;
        }

        public decimal CalcularBonificacion()
        {
            decimal sueldoBase = CalcularSueldoBase();
            if (TipoEspecialidad == "Estructuras")
                return sueldoBase * (decimal)0.16;
            if (TipoEspecialidad == "Recursos Hidricos")
                return sueldoBase * (decimal)0.18;
            return 0;
        }

        public decimal CalcularDescuentos()
        {
            decimal sueldoBase = CalcularSueldoBase();
            if (TipoAfiliacion == "AFP")
                return sueldoBase * porc_Afp;
            if (TipoAfiliacion == "SNP")
                return sueldoBase * porc_Snp;
            return 0;
        }

        public decimal CalcularSueldoBruto()
        {
            decimal sueldoBase = CalcularSueldoBase();
            decimal bonificacion = CalcularBonificacion();
            return sueldoBase + bonificacion;
        }

        public decimal CalcularSueldoNeto()
        {
            decimal sueldoBruto = CalcularSueldoBruto();
            decimal descuentos = CalcularDescuentos();
            return sueldoBruto - descuentos;
        }

        public static int GetContador()
        {
            return contador;
        }
    }

}
