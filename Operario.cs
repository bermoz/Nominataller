using System;
using System.Collections.Generic;
using System.Text;

namespace Nominataller
{
    class Operario: Persona
    {
        private string telefono;
        private string cargo;
        private decimal salariobase;

        public Operario(string cedula, string nombres, string apellidos, DateTime fechanacimiento, string telefono,
                        string cargo, decimal salariobase) : base(cedula, nombres, apellidos, fechanacimiento)
        {
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechanacimiento;
            Telefono = telefono;
            Cargo = cargo;
            Salariobase = salariobase;
        }

        // Metodos Get y Set para encapsular los atributos
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public decimal Salariobase { get => salariobase; set => salariobase = value; }

        public override void Crear()
        {
            // Metodo ..

        }

        public override void Modificar()
        {


        }

        public override void Consultar()
        {
         

        }

        public override void Deshabilitar()
        {

        }

    }
}
