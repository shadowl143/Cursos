using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Rectangulo : IFigurasGeometricas
    {
        public string Area()
        {
            int bases = 25;
            int altura = 25;
            var resultado = bases * altura;
            return "El área de una rectangulo  es = " + resultado.ToString();
        }

        public string Perimetro()
        {
            int lado = 25;
            int lado1 = 45;
            var resultado = lado + lado1 + lado + lado1;
            return "El permietro de una rectangulo  es = " + resultado.ToString();
        }
    }
}
