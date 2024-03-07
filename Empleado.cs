using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    class Empleado
    {

        int numEm;
        string nombre;
        decimal sueldo;

        public int NumEm { get => numEm; set => numEm = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Sueldo { get => sueldo; set => sueldo = value; }


    }
}
