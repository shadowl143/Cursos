using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles
{
    public  class Mientras
    {


        public Mientras()
        {

        }


        public void EjecutarMientras(int opc)
        {
            int contador=0;
            while (contador < opc)
            {
                Console.WriteLine("Entro " + contador);
                contador++;
            }
        }

        public void EjecutarMientras(string opc)
        {
            while ("Llover" == opc)
            {
                opc = Clima();
            }
        }


        public void RevisarClima()
        {
            var opc = "Llover";
            var i = 0;
            do
            {
                if (i == 5)
                {
                    opc ="Soleado";
                }
                i++;
            } while ("Llover" == opc);
        }
        public string Clima()
        {
            var contador = 0;
            while (contador<10)
            {
                if (contador == 5)
                {
                    return "Soleado";
                }
                contador++;
            }
            return "";
        }
    }
}
