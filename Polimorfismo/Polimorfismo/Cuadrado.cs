using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cuadrado : IFigurasGeometricas
    {
        public string Area()
        {
            int lado1 = 25;
            int lado2 = 25;
            var resultado = lado1 * lado2;
            return "El área de una cuadrado  es = " + resultado.ToString();
        }

        public string Perimetro()
        {
            int lado = 25;
            var resultado = lado + lado + lado+lado;
            return "El perimetro de una cuadrado  es = " + resultado.ToString();
        }
    }
}
