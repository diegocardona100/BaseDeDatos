using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    class Reporte
    {

        decimal sueldoMensual;
        int mes;
        string nombreempleado;

        public decimal SueldoMensual { get => sueldoMensual; set => sueldoMensual = value; }
        public int Mes { get => mes; set => mes = value; }
        public string Nombreempleado { get => nombreempleado; set => nombreempleado = value; }
    }
}
