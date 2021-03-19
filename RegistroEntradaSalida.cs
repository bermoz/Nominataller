using System;
using System.Collections.Generic;
using System.Text;

namespace Nominataller
{
    class RegistroEntradaSalida
    {
        private DateTime fechahoraentrada;
        private DateTime fechahorasalida;
        private DateTime cantidadhoras;

        public RegistroEntradaSalida(DateTime fechahoraentrada, DateTime fechahorasalida, DateTime cantidadhoras)
        {
            this.fechahoraentrada = fechahoraentrada;
            this.fechahorasalida = fechahorasalida;
            this.cantidadhoras = cantidadhoras;
        }


        // Metodo Virtuales que se pueden reescribir una vez heredados.
        public virtual void Crear()
        {
            // Metodo ..

        }

        public virtual void Modificar()
        {

        }

        public virtual void Consultar()
        {

        }

        public virtual void Deshabilitar()
        {

        }
    }
}
