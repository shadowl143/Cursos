using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    public class ClaseSwitch
    {

        public ClaseSwitch()
        {

        }



        public void EjecutarSwitch(int opcion)
        {
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Elegiste la opcion " + opcion);
                    break;
                case 1:
                    Console.WriteLine("Elegiste la opcion " + opcion);
                    break;
                case 2:
                    Console.WriteLine("Elegiste la opcion " + opcion);
                    break;
                default:
                    Console.WriteLine("no se encontro la opcion " + opcion);
                    break;
            }
        }

        public void EjecutarOperacion(int opc)
        {
            switch (opc)
            {
                case 0:
                    Sumar();
                    break;
                case 1:
                    Restar();
                    break;
                case 2:
                    Multiplar();
                    break;
                case 3:
                    Dividir();
                    break;
            }
        }

        public void Sumar()
        {
            Console.WriteLine("Se sumaron dos numeros " + (1 + 2));
        }

        public void Multiplar()
        {
            Console.WriteLine("Se sumaron dos numeros " + (1 * 2));
        }

        public void Restar()
        {
            Console.WriteLine("Se sumaron dos numeros " + (1 - 2));
        }

        public void Dividir()
        {
            Console.WriteLine("Se sumaron dos numeros " + Convert.ToDecimal((1 / 2)));
        }

        public  void MostrarError()
        {
            /***
             * (),
             * potencias
             * * /
             * +-
             * **/

            try
            {
                var numero = 1;
                var numero2 = 2;
                var numero3 = 2;
                var division = numero / (numero3 - numero2);
                Console.WriteLine(division);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Existe un erro en la operacion "+ex.Message);
            }
            finally
            {
                var numero = 1;
                var numero2 = 2;
                var numero3 = 2;
                var division = numero / numero3 - numero2;
                Console.WriteLine(division);
            }
           
        }
    }
}
