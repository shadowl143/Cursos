using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Vehiculos
    {
        string nombre;
        string nombreCompuesto;
        public string Nombre { 
            get { return nombre.ToUpper(); } 
            set { nombre = value; } }
        public int CantidadPuertas { get; set; }
        public string Llantas { get; set; }
        public int CilindrosMotor { get; set; }
        public string Transmicion { get; set; }

        public string NombreCompuesto
        {
            get
            {
                return nombreCompuesto;
            }
            set
            {
                nombreCompuesto = Nombre + " Cantidad de llantas " + Llantas;
            }
        }


    }
}
