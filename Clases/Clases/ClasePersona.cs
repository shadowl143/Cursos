using Clases.Escuela;

namespace Clases
{
    public abstract class ClasePersona
    {
        
        public virtual void CrearAlumnos()
        {
            Alumnos alumnos = new Alumnos();
            alumnos.Nombre = "Juanito";
            Console.WriteLine(alumnos.Nombre);
        }

        public void CrearMaestro()
        {
            Maestro maestro = new Maestro();
            maestro.Nombre = "Juanito";
        }

        public abstract void CrearContenido();
    }
} 