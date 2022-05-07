using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class RecibirDatos
    {
        public RecibirDatos()
        {

        }

        public void MostrarNombre(string nombre)
        {
            Console.WriteLine(nombre);
        }

        public void MostrarValor(int numero)
        {
            Console.WriteLine(numero);

        }

        public void MostrarFechaDeHoy(DateTime dateTime)
        {
            Console.WriteLine(dateTime);

        }

        public void MostrarAsignarArray(string[] arreglo)
        {
            Console.WriteLine(arreglo[0]);
            Console.WriteLine(arreglo[1]);
        }
    }
}
