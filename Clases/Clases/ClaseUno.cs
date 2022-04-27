namespace Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class ClasePublica:ClasePersona
    {

        
        //variables
        public int numeroUno = 0;
        private int numeroServico = 0;
        private int numeroUnoP = 0;

        public ClasePublica()
        {

        }

        public ClasePublica(int numero)
        {
            this.numeroUno = numero;
        }

        // la suma de numero1 + numero 2 = {varible}+{variable}=resultado
        // nivel de acceso + tipo de retorno (void si no retorna nada )+nombre camelCase de la clase+(opcional) parametros
        public void LLamarVariablePublica()
        {

            this.numeroUno++;
            //variable de tipo local 
            var numeroUnoLocal = 2;
            Console.WriteLine(numeroUno);
        }

        public string SaludoAmigo()
        {
            return "Hola amigo!!";
        }

        public string SaludoAmigo(string vasr)
        {
            return "Hola amigo!! "+vasr;
        }

        public int Sumar(int num1,int num2)
        {
            return num1 + num2;
        }

        public string Numero(int numeroElegido)
        {
            var texto = "hola amigos ";
            var concatenar = texto + "estamos en un curso de C# el numero que se eligio fue: ";
            return concatenar +numeroElegido.ToString();
        }
        //usar por herencia o en su mismo metodo
        private void MetodoPrivado()
        {

        }
        /// <summary>
        /// este metodo nunca sale de su clase
        /// </summary>
        protected void MetodoProtected()
        {

        }


        //Uso de herencia
        public void FormarVehiculo()
        {
            Carros carros = new Carros();

            carros.Nombre = "Cordoba";
            carros.CantidadPuertas = 4;
            carros.CilindrosMotor = 4;
            carros.CajuelaDelantera = false;
            carros.Llantas = "4";

            Console.WriteLine("Nombre: "+carros.Nombre);
            Console.WriteLine(carros.CantidadPuertas);
            Console.WriteLine(carros.CilindrosMotor);
            Console.WriteLine(carros.CajuelaDelantera);
            Console.WriteLine(carros.Nombre);
            ///Console.WriteLine(carros.NombreCompuesto);
           

        }

        public override void CrearAlumnos()
        {
            Console.WriteLine("Conocimo como override");
        }

        public override void CrearContenido()
        {
            throw new NotImplementedException();
        }
    }

}
