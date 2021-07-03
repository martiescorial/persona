using System;

namespace persona
{
    public class Persona
    {
        private string nombre;

        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola soy {0}", nombre);
        }
    }

    public class PruebaPersona
    {
        public static void Main()
        {
            Persona persona1 = new Persona();
            
            Console.WriteLine("Introduzca el nombre de la primera persona");
            persona1.SetNombre(Console.ReadLine());

            Persona persona2 = new Persona();

            Console.WriteLine("Introduzca el nombre de la segunda persona");
            persona2.SetNombre(Console.ReadLine());

            persona1.Saludar();
            persona2.Saludar();
        }
    }
}
