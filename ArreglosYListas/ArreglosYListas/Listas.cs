using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosYListas
{
    public class Listas
    {

        public Listas()
        {

        }
        public void ListasEjemplo()
        {
            //Listas
            List<string> lista = new List<string>();
            lista.Add("Juan");
            lista.Add("lopez");

            var lvalor = lista[lista.Count - 1];
            lista.Add("123456");


            Console.WriteLine(lvalor);
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            string[] peliculas = new string[3];

            List<string> peliculas1 = new List<string>();


        }
    }
}
