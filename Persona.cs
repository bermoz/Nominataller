using System;
using System.Collections.Generic;
using System.Text;

namespace Nominataller
{
    class Persona
    {        
        // Declaracion de Campos (fields) publicos
        private string cedula;
        private string nombres;
        private string apellidos;
        private DateTime fechanacimiento;
                
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime FechaNacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public enum Genero { Masculino, Femenino };

        // Metodo Constructor
        public Persona(string cedula, string nombres, string apellidos, DateTime fechanacimiento)
        {
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;            
            FechaNacimiento = fechanacimiento;
        }

        // Metodo Virtuales que se pueden reescribir una vez heredados.
        public virtual void Crear() {
            // Metodo ..
            
        }

        public virtual void Modificar() { 
        
        }

        public virtual void Consultar() { 
        
        }

        public virtual void Deshabilitar() { 
        
        }

    }
}
