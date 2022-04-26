using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Triangulo : IFigurasGeometricas
    {
        public string Area()
        {
            int altura = 25;
            int bases = 25;
            var resultado = altura * bases / 2;
            return "El area de una triangulo  es = "+ resultado.ToString();
            
        }

        public string Perimetro()
        {
            int lado = 25;
            var resultado = lado + lado +lado;
            return "El permietro de una triangulo  es = " + resultado.ToString();
        }
    }
}
