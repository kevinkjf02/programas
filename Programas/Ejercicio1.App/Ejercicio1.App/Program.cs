using System;

namespace Ejercicio1.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido....!!!");
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            var edad = Console.ReadLine();
            int edad1 = int.Parse(edad);
            Console.Write("Ingrese su peso: ");
            var peso = float.Parse(Console.ReadLine());//Trasforma a otro tipo de variable
            var persona = new Persona();
            persona.nombre = nombre;
            persona.edad = edad1;
            persona.peso = peso;
            Console.Write("Usted ingreso lo siguiente: "+"\n");
            Console.WriteLine("Su nombre es:" + persona.nombre);
            Console.WriteLine("Su edad es:" + persona.edad);
            Console.WriteLine("Su peso es:" + persona.peso);
            Console.Write("Muchas gracias...!!!:  , Digite cualquier tecla para salir... ");
            Console.ReadKey();









        }
        public void SaludoInicial(String[]args)
        {
            if (args.Length > 0)
                Console.WriteLine("Hola {0} {1} {2} ", args[0], args[1], args[2]);
            else
            {
                Console.WriteLine("Hola desconocido");

            }
            Console.WriteLine("Como Estas?");
            var estado = Console.ReadLine();
            Console.WriteLine("dsdsd", "entiendo");
            Console.ReadLine();
        }
    }
}
