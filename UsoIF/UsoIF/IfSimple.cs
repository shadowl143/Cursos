using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoIF
{
    public class IfSimple
    {

        public IfSimple()
        {

        }

        public void UsoDelIf(int edad)
        {
            if (edad==0)
            {
                Console.WriteLine("Tienes menos de un año");
            }
            Console.WriteLine("Falta el else");
        }

        public void UsoDelIfElse(int edad)
        {
            if (edad == 0)
            {
                Console.WriteLine("Tienes menos de un año");
            }else
            {
                Console.WriteLine("Tienes por lo menos un año");
            }
        }

        public string UsoDelIfElseResturn(int edad)
        {
            if (edad == 0)
            {
                return "Tienes menos de un año";
            }
            else
            {
                return "Tienes por lo menos un año";
            }
        }

        public void VariosIf(int edad)
        {
            if (edad == 0)
            {
                Console.WriteLine("Igual a 0");
            }
            if (edad>1)
            {
                Console.WriteLine("mayor que uno");

            }
            if (edad > 22)
            {
                Console.WriteLine("Mayor que dos");

            }
            else
            {
                Console.WriteLine("No es mayor que 22");

            }
        }

        public void IfAnidado(string sexo,int edad)
        {
            if (sexo != "Hombre")
            {
                this.MostrarMensajes(edad, sexo, "18 años");
            }
            else
            {
                this.MostrarMensajes(edad, sexo, "18 años");

            }
        }

        private void MostrarMensajes(int edad,string sexo,string mensaje)
        {
            if (edad > 18)
            {
                Console.WriteLine("La persona es" + sexo + " y es mayor de" + mensaje);

            }
            else
            {
                Console.WriteLine("La persona es" + sexo + " y es mayor de" + mensaje);
            }
        }

        public void IfAnidadoDos(string sexo, int edad)
        {
            if (sexo != "Hombre")
            {
                this.MostrarMensajes(edad, sexo, "Edad");
            }
            else
            {
                this.MostrarMensajes(edad, sexo, "Edad");
            }
        }

        public void IFElseIF(int edad)
        {
            if (edad > 0)
            {
                Console.Write("Es mayor que cero");
            }else if (edad <= -1)
            {
                Console.WriteLine("Es un numero negativo");
            }
            else
            {
                Console.WriteLine("Ninuguno de los anteriores");
            }
        }
    }
}
