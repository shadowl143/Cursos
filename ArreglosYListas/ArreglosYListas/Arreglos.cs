using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosYListas
{
    public class Arreglos
    {

        public Arreglos()
        {

        }

        public void ArreglosPersona()
        {
            //arreglos 
            string[] persona = new string[4]; //arreglos se comineza desde el cero

            persona[0] = "juan";
            persona[1] = "lopez";
            persona[2] = "calle sin numero";
            persona[3] = "123456789";

            for (int i = 0; i < persona.Length; i++)
            {
                Console.WriteLine(persona[i]);
            }


            Console.WriteLine("El arreglo persona tiene un tamaño de " + persona.Length);

            Console.WriteLine("Que valor tiene el arreglo en su primer posicion " + persona[0]);
            Console.WriteLine("Que valor tiene el arreglo en su primer posicion " + persona[3] + " ó " + persona[persona.Length - 1]);
        }

        public void ArreglosNumeros()
        {
            int[] arregloNumeros = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                Console.WriteLine(arregloNumeros[i]);
            }
            Console.WriteLine("El arreglo de numero tiene un tamaño de " + arregloNumeros.Length);

        }

        public void ArreglosBidemensionales()
        {
            string[,] arregloBidemensional = new string[4, 2];

            arregloBidemensional[0, 0] = "1 variable";
            arregloBidemensional[0, 1] = "1.1 variable locales y variables globales";
            arregloBidemensional[1, 0] = "2";
            arregloBidemensional[1, 1] = "2.1";
            arregloBidemensional[2, 0] = "3";
            arregloBidemensional[2, 1] = "3.1";
            arregloBidemensional[3, 0] = "4";
            arregloBidemensional[3, 1] = "4.1";


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(arregloBidemensional[i, j]);
                }
            }

        }

    }
}
