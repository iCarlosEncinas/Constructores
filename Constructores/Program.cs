using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            contacto1.Nombre = "Carlos Encinas";
            contacto1.Telefono = "(644) 4 20 55 99";
            contacto1.Correo = "carlosencinas123@gmail.com";

            Console.WriteLine("Nombre:          " + contacto1.Nombre);
            Console.WriteLine("Teléfono:        " + contacto1.Telefono);
            Console.WriteLine("Correo:          " + contacto1.Correo);
            Console.WriteLine("Dirección:       " + contacto1.Direccion);

            Contacto contacto2 = new Contacto("Juan", "Juan@correo.com");

            Console.WriteLine("\nContacto 2");
            Console.WriteLine("Nombre:          " + contacto2.Nombre);
            Console.WriteLine("Correo:          " + contacto2.Correo);
            Console.WriteLine("Dirección:       " + contacto2.Direccion);

            Console.Read();
        }
    }
}
