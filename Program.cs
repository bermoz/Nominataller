using System;


namespace Nominataller
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracion e instacia de un objeto
            Persona p1 = new Persona("123455", "Julian", "Restrepo", DateTime.Today);
            Operario op1 = new Operario("123455", "Julian", "Restrepo", DateTime.Today, "12345432", "Auxiliar 1", 1500000);

            // RegistroIngresoSalida, Jornada, RegistroPago


            // interface de usuario
            Console.Clear();
            Console.WriteLine("Nomina Taller");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(p1.Cedula);
            Console.WriteLine(p1.Nombres);
            Console.WriteLine(p1.Apellidos);
            Console.WriteLine(p1.FechaNacimiento);
            Console.WriteLine("--> Digite enter para continuar <---------------------");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Nomina Taller");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(op1.Cedula);
            Console.WriteLine(op1.Nombres);
            Console.WriteLine(op1.Apellidos);
            Console.WriteLine(op1.FechaNacimiento);
            Console.WriteLine("--> Digite enter para continuar <---------------------");
            Console.ReadLine();

        }

    }
}
