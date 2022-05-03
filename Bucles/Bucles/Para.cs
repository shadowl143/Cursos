using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles
{
    public class Para
    {
        int numero=10;

        public Para()
        {
            int numero = 2;
            Console.WriteLine(numero);
            Console.WriteLine(this.numero);

        }


        public void EjecutarFor()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            //int resultado = 0;
            for (int i = 0; i < 10; i++)
            {
                //resultado=resultado+i;
                Console.WriteLine(i);
            }
            timer.Stop();
            Console.WriteLine("El tiempo de ejecucion fue " + timer.ElapsedMilliseconds);
        }

        public void EjecutarForMultiplicar()
        {
            int tabla = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine(tabla * i);
            }
        }

        public void EjecutarForDosEnDos()
        {
            // int tabla = Convert.ToInt32(Console.ReadLine());
            int interaccion = 1;
            for (int i = 0; i <= 50; i += 2)
            {
                //i=i+3 === i+=3 i=0 i=2 i=4 i=6
                Console.Write(i + ",");
                interaccion++;
            }
            Console.WriteLine("numero de iteraciones: " + interaccion);
        }

        int contador = 0;
        public void EjecutarRecursividad(int i)
        {

            if (i < 10)
            {
                contador++;
                Console.WriteLine(this.contador);
                EjecutarRecursividad(this.contador);
            }
        }

        public void TomarTiempo()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            EjecutarRecursividad(0);
            timer.Stop();
            Console.WriteLine("El tiempo de ejecucion fue " + timer.ElapsedMilliseconds);

        }
    }
}
