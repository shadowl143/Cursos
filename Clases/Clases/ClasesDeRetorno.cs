using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ClasesDeRetorno
    {
        public ClasesDeRetorno()
        {

        }

        //Metodo que retorne un string 
        public string AsignarNombre()
        {
            //var palabra = "El Chavo del ocho";
            //return palabra;
            return "Chilindrina";
        }
        
        public int Valor()
        {
            int numero = 1;
            int numeroDos = 2;
            return numero + numeroDos;
        } 

        public DateTime FechaDeHoy()
        {
            return DateTime.Now;
        }

        public string[] AsignarArray()
        {
            string[] arr = new string[2];
            arr[0] = "Jose";
            arr[1] = "Joselito";
            //return new string[2] {"Jose","joselito" };
            return arr;
        }

    }
}
