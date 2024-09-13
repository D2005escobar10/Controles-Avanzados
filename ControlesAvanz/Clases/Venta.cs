using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesAvanz.Clases
{
    internal class Venta
    {
        public int Anio { get; set; }

        public int Mes {  get; set; }

        public string Departamentos { get; set; }

        public double Ventas { get; set; }

        public string MesNombre
        {
            get
            {
                return CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[Mes - 1];
            }
        }

        public Venta(int anio, int mes, string departamentos, double ventas)
        {
            Anio = anio;
            Mes = mes;
            Departamentos = departamentos;
            Ventas = ventas;
        }
    }
}
