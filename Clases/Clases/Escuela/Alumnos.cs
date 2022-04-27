using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Escuela
{
    public class Alumnos:Personas
    {
        int numero;

        public void SetNumero(int numero)
        {
            this.numero = numero;
        }
        public int GetNumero()
        {
            return this.numero;
        }


        public string Matricula { get; set; }
        public string Grado { get; set; }
        public string Salon { get; set; }
    }
}
