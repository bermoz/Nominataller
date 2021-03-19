using System;
using System.Collections.Generic;
using System.Text;

namespace Nominataller
{
    class RegistroPago
    {
        private DateTime fechapago;
        private Decimal valorpago;
        private Array detallespago;
        private Operario operario;

        public RegistroPago(DateTime fechapago, decimal valorpago, Array detallespago, Operario operario)
        {
            this.fechapago = fechapago;
            this.valorpago = valorpago;
            this.detallespago = detallespago;
            this.operario = operario;
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
