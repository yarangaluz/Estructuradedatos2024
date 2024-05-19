using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Jefe
    {
        public string Nombres { get; set; }
        public string Dni { get; set; }
        public string Cargo { get; set; }
        public string Area { get; set; }
        public decimal AñosAntiguedad { get; set; }
        

        public Jefe(string nombres, string dni, string cargo, string area, decimal añosAntiguedad)
        {
            Nombres = nombres;
            Dni = dni;
            Cargo = cargo;
            Area = area;
            AñosAntiguedad = añosAntiguedad;
        }

        public decimal CalcularSueldoBase()
        {
            if (Cargo == "Gerente")
            {
                if (Area == "Contabilidad")
                    return 6000;
                if (Area == "Planificacion")
                    return 7000;
            }
            else if (Cargo == "Subgerente")
            {
                if (Area == "Contabilidad")
                    return 5000;
                if (Area == "Planificacion")
                    return 6000;
            }
            return 0;
        }

        public decimal CalcularBonificacion()
        {
            decimal sueldoBase = CalcularSueldoBase();
            if (AñosAntiguedad <= 7)
                return sueldoBase * (decimal)0.05;
            if (AñosAntiguedad >= 8)
                return sueldoBase * (decimal)0.04;
            return 0;
        }

        public decimal CalcularMontoMovilidad()
        {
            decimal sueldoBase = CalcularSueldoBase();
            if (Cargo == "Gerente")
                return sueldoBase * 700;
            if (Cargo == "Subgerente")
                return sueldoBase * 400;
            return 0;
        }
        public decimal CalcularSueldoFinal()
        {
            decimal sueldoBase = CalcularSueldoBase();
            decimal bonificacion = CalcularBonificacion();
            decimal montoMovilidad = CalcularMontoMovilidad();
            return sueldoBase + bonificacion + montoMovilidad;
        }
    }
}
